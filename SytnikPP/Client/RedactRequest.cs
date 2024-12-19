using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SytnikPP
{
    public partial class RedactRequest : Form
    {
        DataBase dataBase;
        int userID;
        List<Request> requests;
        Dictionary<int, string> types;
        Dictionary<int, string> models;


        public RedactRequest(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            userID = dataBase.GetUserIdByLogin(login);
            requests = dataBase.GetAllRequests().Where(req => req.clientData.Key == userID && req.completionDate == null && req.requestStatus.Key != 3).ToList();

            types = dataBase.GetTechTypes();
            models = new();

            foreach (var request in requests)
                comboBoxRequest.Items.Add(request.requestID);
            if (comboBoxRequest.Items.Count > 0)
                comboBoxRequest.SelectedIndex = 0;

            foreach (var type in types)
                comboBoxType.Items.Add(type.Value);
        }

        public RedactRequest()
        {
            InitializeComponent();
        }

        private void RedactRequest_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            comboBoxRequest_SelectionChangeCommitted(sender, e);
        }

        private void comboBoxRequest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var req = requests.First(req => req.requestID == int.Parse(comboBoxRequest.Text));

            labelStartData.Text = "Дата заявки: " + req.startDate.ToLocalTime().Date.ToString("dd.MM.yyyy");
            labelRequestStatus.Text = "Статус завки: " + req.requestStatus.Value;
            labelMaster.Text = "Имя мастера: " + (req.masterData.HasValue ? req.masterData.Value.Value : "Нет");

            comboBoxType.SelectedItem = req.techType.Value;
            comboBoxType_SelectionChangeCommitted(sender, e);

            comboBoxModel.SelectedItem = req.techModel.Value;

            richTextBox1.Text = req.problemDescription;
        }

        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            models = dataBase.GetTechModelsByType(types.First(type => type.Value == comboBoxType.Text));

            foreach (var model in models)
                comboBoxModel.Items.Add(model.Value);
            comboBoxModel.SelectedIndex = 0;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataBase.EditRequest(int.Parse(comboBoxRequest.Text), richTextBox1.Text, models.First(model => model.Value == comboBoxModel.Text).Key);
            MessageBox.Show("Заявка успешно отредактирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
         => Close();
    }
}
