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

    public partial class CommentSpecialist : Form
    {
        DataBase dataBase;
        int userID;
        List<Request> requests;

        public CommentSpecialist(DataBase dataBase, string login)
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


        public CommentSpecialist()
        {
            InitializeComponent();
        }

        private void CommentSpecialist_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("У вас нет заказов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            dataBase.CreateComment(int.Parse(comboBox.Text), richTextBox.Text);
            MessageBox.Show("Комментарий успешно оставлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        => Close();
    }
}
