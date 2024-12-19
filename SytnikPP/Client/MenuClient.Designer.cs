namespace SytnikPP
{
    partial class MenuClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuClient));
            buttonRequest = new Button();
            buttonComment = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            buttonRedact = new Button();
            buttonQR = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRequest
            // 
            buttonRequest.BackColor = Color.DarkGray;
            buttonRequest.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRequest.ForeColor = SystemColors.ControlText;
            buttonRequest.Location = new Point(77, 284);
            buttonRequest.Name = "buttonRequest";
            buttonRequest.Size = new Size(238, 33);
            buttonRequest.TabIndex = 0;
            buttonRequest.Text = "Создать заявку";
            buttonRequest.UseVisualStyleBackColor = false;
            buttonRequest.Click += button1_Click;
            // 
            // buttonComment
            // 
            buttonComment.BackColor = Color.DarkGray;
            buttonComment.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComment.ForeColor = SystemColors.ControlText;
            buttonComment.Location = new Point(77, 362);
            buttonComment.Name = "buttonComment";
            buttonComment.Size = new Size(238, 35);
            buttonComment.TabIndex = 1;
            buttonComment.Text = "Комментрарии";
            buttonComment.UseVisualStyleBackColor = false;
            buttonComment.Click += buttonComment_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Baskerville Old Face", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(309, 12);
            button3.Name = "button3";
            button3.Size = new Size(88, 23);
            button3.TabIndex = 2;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(142, 91);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 18);
            labelName.TabIndex = 4;
            labelName.Text = "Здравствуйте";
            // 
            // buttonRedact
            // 
            buttonRedact.BackColor = Color.DarkGray;
            buttonRedact.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRedact.ForeColor = Color.Black;
            buttonRedact.Location = new Point(77, 323);
            buttonRedact.Name = "buttonRedact";
            buttonRedact.Size = new Size(238, 33);
            buttonRedact.TabIndex = 5;
            buttonRedact.Text = "Редактировать заявку";
            buttonRedact.UseVisualStyleBackColor = false;
            buttonRedact.Click += buttonRedact_Click;
            // 
            // buttonQR
            // 
            buttonQR.BackColor = Color.DarkGray;
            buttonQR.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonQR.ForeColor = SystemColors.ControlText;
            buttonQR.Location = new Point(77, 403);
            buttonQR.Name = "buttonQR";
            buttonQR.Size = new Size(238, 35);
            buttonQR.TabIndex = 6;
            buttonQR.Text = "QR-Код";
            buttonQR.UseVisualStyleBackColor = false;
            buttonQR.Click += buttonQR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 7;
            label2.Text = "Роль: Заказчик";
            // 
            // MenuClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 473);
            Controls.Add(label2);
            Controls.Add(buttonQR);
            Controls.Add(buttonRedact);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(buttonComment);
            Controls.Add(buttonRequest);
            Name = "MenuClient";
            Text = "MenuClient";
            Load += MenuClient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRequest;
        private Button buttonComment;
        private Button button3;
        private PictureBox pictureBox1;
        private Label labelName;
        private Button buttonRedact;
        private Button buttonQR;
        private Label label2;
    }
}