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
    public partial class RequestAddClient : Form
    {
        DataBase dataBase;
        int userID;
        Dictionary<int, string> requstStatuses;
        Dictionary<int, string> types;
        Dictionary<int, string> models;

        public RequestAddClient(DataBase dataBase, string login)
        {
            InitializeComponent();

            this.dataBase = dataBase;
            requstStatuses = dataBase.GetRequestStatuses();
            types = dataBase.GetTechTypes();
            userID = dataBase.GetUserIdByLogin(login);
            models = new();

            foreach (var type in types)
                comboBoxType.Items.Add(type.Value);
            comboBoxType.SelectedIndex = 0;
        }
        private void CreateQuery_Load(object sender, EventArgs e)
           => comboBoxType_SelectionChangeCommitted(sender, e);

        public RequestAddClient()
        {
            InitializeComponent();
        }

        private void RequestAddClient_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            models = dataBase.GetTechModelsByType(types.First(kvp => kvp.Value == comboBoxType.Text));

            foreach (var model in models)
                comboBoxModel.Items.Add(model.Value);
            comboBoxModel.SelectedIndex = 0;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите описание проблемы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                dataBase.CreateRequest(DateTime.Now, richTextBox1.Text, null, 1, models.First(kvp => kvp.Value == comboBoxModel.Text).Key, null, userID);
                MessageBox.Show("Заявка успешно отправлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        => Close();
    }
}

