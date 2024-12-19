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
    public partial class SpecialistMenu : Form
    {
        DataBase dataBase;
        readonly string login;

        public SpecialistMenu(DataBase dataBase, string login)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            this.login = login;

            var name = dataBase.GetUserNameByLogin(login).Split(' ');
            label_Name.Text = "ФИ: " + name[0] + ' ' + name[1];
        }

        public SpecialistMenu()
        {
            InitializeComponent();
        }

        private void SpecialistMenu_Load(object sender, EventArgs e)
        {

        }



        private void button_RequestClick(object sender, EventArgs e)
        {
            using (var form = new RequstSpecialist(dataBase, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void button_Detali_Click(object sender, EventArgs e)
        {
            using (var form = new DetaliSpecialist(dataBase, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void button_Comment_Click(object sender, EventArgs e)
        {
            using (var form = new CommentSpecialist(dataBase, login))
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
