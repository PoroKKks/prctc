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

namespace SytnikPP
{

    public partial class OperatorMenu : Form
    {
        DataBase dataBase;
        readonly string login;


        public OperatorMenu(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.login = login;

            var name = dataBase.GetUserNameByLogin(login).Split(' ');
            label_Name.Text = "ФИ: " + name[0] + ' ' + name[1];
        }

        public OperatorMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new RequestOperator(dataBase))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        => Close();

        private void OperatorMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
