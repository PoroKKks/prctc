using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;
using System.IO;

using System.Net.Http.Json;
using Newtonsoft.Json;




namespace SytnikPP
{
    public partial class Login : Form
    {

        DataBase dataBase;
        private int loginAttempts = 0;
        private string currentCaptcha = string.Empty;
        private System.Windows.Forms.Timer blockTimer;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '●';
            pictureBox1.Visible = false;
            textBox_Login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }

        public Login()
        {
            InitializeComponent();
            dataBase = new(@"Server=192.168.188.11;Database=SytnikDBPP;Trusted_Connection=True;TrustServerCertificate=True;");
            blockTimer = new System.Windows.Forms.Timer();
            blockTimer.Interval = 180000;
            blockTimer.Tick += BlockTimer_Tick;
        }


        private Image GetCaptchaImage(string captchaCode, int height, int width, int fontSize)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                using (Font font = new Font("Arial", fontSize))
                {
                    graphics.DrawString(captchaCode, font, Brushes.Black, new PointF(10, 10));
                }
            }
            return bitmap;
        }

        private void RefreshCaptcha()
        {
            currentCaptcha = Exec.GenerateCaptchaString(4);
            pictureBoxCaptcha.Image = GetCaptchaImage(currentCaptcha, pictureBoxCaptcha.Height, pictureBoxCaptcha.Width, 24);
            CheckCaptcha();
        }

        private void CheckCaptcha()
        {
            if (loginAttempts != 0 && textBoxCaptcha.Text == currentCaptcha)
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
        }

        private void BlockLogin()
        {
            buttonLogin.Enabled = false;
            textBoxCaptcha.Enabled = false;
            pictureBoxRefresh.Enabled = false;
            blockTimer.Start();
        }

        private void BlockTimer_Tick(object? sender, EventArgs e)
        {
            buttonLogin.Enabled = true;
            textBoxCaptcha.Enabled = true;
            pictureBoxRefresh.Enabled = true;
            RefreshCaptcha();
            blockTimer.Stop();
        }
        private void BlockLoginCompletely()
        {
            textBox_Login.Enabled = false;
            textBox_password.Enabled = false;
            pictureBox2.Enabled = false;
            textBoxCaptcha.Enabled = false;
            pictureBoxRefresh.Enabled = false;
            buttonLogin.Enabled = false;
        }
        private void Log(string login, bool result)
        {
            List<UserData>? data = new List<UserData>();
            const string path = @".\logger.dat";
            var loginTime = DateTime.Now;

            if (!File.Exists(path))
                File.Create(path).Close();

            if (File.ReadAllText(path).Length != 0)
                data = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(path));
            if (data == null)
                return;

            data.Add(new UserData(loginTime, login, result));
            File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        private void RefreshForm()
        {
            loginAttempts = 0;
            textBox_Login.Text = string.Empty;
            textBox_password.Text = string.Empty;
            textBoxCaptcha.Text = string.Empty;
            labelCaptcha.Visible = false;
            textBoxCaptcha.Visible = false;
            pictureBoxCaptcha.Visible = false;
            pictureBoxRefresh.Visible = false;
            buttonLogin.Enabled = true;
        }


        private void OpenMainForm(User userType, string login)
        {
            switch (userType)
            {
                case User.Customer:
                    using (var form = new MenuClient(dataBase, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Specialist:
                    using (var form = new SpecialistMenu(dataBase, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Operator:
                    using (var form = new OperatorMenu(dataBase, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Manager:
                    using (var form = new Manager.ManagerMenu(dataBase, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
            }
        }

        

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        => RefreshCaptcha();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBox_Login.Text;
            var password = textBox_password.Text;

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                User user = dataBase.Auth(login, password);
                switch (loginAttempts)
                {
                    case 0:
                        if (user != User.None)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Введите капчу!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            labelCaptcha.Visible = true;
                            textBoxCaptcha.Visible = true;
                            pictureBoxCaptcha.Visible = true;
                            pictureBoxRefresh.Visible = true;
                            RefreshCaptcha();
                            loginAttempts++;
                        }
                        break;
                    case 1:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован на 3 минуты!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLogin();
                            loginAttempts++;
                        }
                        break;
                    case 2:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLoginCompletely();
                            loginAttempts++;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void textBoxCaptcha_TextChanged(object sender, EventArgs e)
         => CheckCaptcha();

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            var login = textBox_Login.Text;
            var password = textBox_password.Text;

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                User user = dataBase.Auth(login, password);
                switch (loginAttempts)
                {
                    case 0:
                        if (user != User.None)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Введите капчу!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            labelCaptcha.Visible = true;
                            textBoxCaptcha.Visible = true;
                            pictureBoxCaptcha.Visible = true;
                            pictureBoxRefresh.Visible = true;
                            RefreshCaptcha();
                            loginAttempts++;
                        }
                        break;
                    case 1:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован на 3 минуты!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLogin();
                            loginAttempts++;
                        }
                        break;
                    case 2:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLoginCompletely();
                            loginAttempts++;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
