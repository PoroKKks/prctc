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
    public partial class DetaliSpecialist : Form
    {
        DataBase dataBase;
        int userID;
        List<Request> requests;

        public DetaliSpecialist(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            userID = dataBase.GetUserIdByLogin(login);
            requests = dataBase.GetAllRequests().Where(req => req.masterData.HasValue && req.masterData.Value.Key == userID).ToList();

            foreach (Request req in requests)
                comboBox.Items.Add(req.requestID);
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }

        public DetaliSpecialist()
        {
            InitializeComponent();
        }

        private void DetaliSpecialist_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("У вас нет заявок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OrderRepairPart(int.Parse(comboBox.Text), richTextBox1.Text);
            MessageBox.Show("Деталь успешно заказана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        => Close();


    }
}
