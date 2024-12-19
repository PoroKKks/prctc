using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SytnikPP.Manager
{
    public partial class ManagerMenu : Form
    {
        DataBase dataBase;
        readonly string login;

        public ManagerMenu(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.login = login;

            var name = dataBase.GetUserNameByLogin(login).Split(' ');
            labelName.Text = "ФИ: " + name[0] + ' ' + name[1];
        }


        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_Request_Click(object sender, EventArgs e)
        {
            using (var form = new RequestManager(dataBase))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        => Close();
    }
}
