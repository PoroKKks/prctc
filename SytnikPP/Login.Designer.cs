namespace SytnikPP
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            textBox_Login = new TextBox();
            textBox_password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxCaptcha = new TextBox();
            buttonLogin = new Button();
            pictureBoxRefresh = new PictureBox();
            pictureBoxCaptcha = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelCaptcha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 29);
            label1.Name = "label1";
            label1.Size = new Size(271, 43);
            label1.TabIndex = 0;
            label1.Text = "Вход в учетную";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 82);
            label2.Name = "label2";
            label2.Size = new Size(131, 43);
            label2.TabIndex = 1;
            label2.Text = "запись";
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(203, 176);
            textBox_Login.Multiline = true;
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(187, 35);
            textBox_Login.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(203, 238);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(187, 34);
            textBox_password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 171);
            label3.Name = "label3";
            label3.Size = new Size(113, 40);
            label3.TabIndex = 4;
            label3.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 232);
            label4.Name = "label4";
            label4.Size = new Size(137, 40);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Location = new Point(92, 320);
            textBoxCaptcha.Multiline = true;
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(122, 39);
            textBoxCaptcha.TabIndex = 6;
            textBoxCaptcha.TextChanged += textBoxCaptcha_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ButtonShadow;
            buttonLogin.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonFace;
            buttonLogin.Location = new Point(189, 395);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(124, 43);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Image = (Image)resources.GetObject("pictureBoxRefresh.Image");
            pictureBoxRefresh.Location = new Point(404, 325);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(29, 34);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRefresh.TabIndex = 12;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(248, 309);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(142, 50);
            pictureBoxCaptcha.TabIndex = 13;
            pictureBoxCaptcha.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(404, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(404, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelCaptcha
            // 
            labelCaptcha.AutoSize = true;
            labelCaptcha.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCaptcha.Location = new Point(92, 299);
            labelCaptcha.Name = "labelCaptcha";
            labelCaptcha.Size = new Size(43, 18);
            labelCaptcha.TabIndex = 14;
            labelCaptcha.Text = "Капча";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(511, 450);
            Controls.Add(labelCaptcha);
            Controls.Add(pictureBoxCaptcha);
            Controls.Add(pictureBoxRefresh);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxCaptcha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_password);
            Controls.Add(textBox_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Login;
        private TextBox textBox_password;
        private Label label3;
        private Label label4;
        private TextBox textBoxCaptcha;
        private Button buttonLogin;
        private PictureBox pictureBoxRefresh;
        private PictureBox pictureBoxCaptcha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelCaptcha;
    }
}