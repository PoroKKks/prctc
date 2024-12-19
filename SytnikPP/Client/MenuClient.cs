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
    public partial class MenuClient : Form
    {

        DataBase dataBase;
        readonly string login;

        public MenuClient(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.login = login;

            var name = dataBase.GetUserNameByLogin(login).Split(' ');
            labelName.Text = "ФИ: " + name[0] + ' ' + name[1];
        }

        public MenuClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new RequestAddClient(dataBase, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void MenuClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            using (var form = new RedactRequest(dataBase, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            using (var form = new CommentClient(dataBase, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            using (var form = new QRcodeClient())
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        => Close();
    }
}
