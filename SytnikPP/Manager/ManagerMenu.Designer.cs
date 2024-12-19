namespace SytnikPP.Manager
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            pictureBox1 = new PictureBox();
            button_Request = new Button();
            button1 = new Button();
            labelName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_Request
            // 
            button_Request.BackColor = Color.DarkGray;
            button_Request.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Request.Location = new Point(86, 304);
            button_Request.Name = "button_Request";
            button_Request.Size = new Size(238, 33);
            button_Request.TabIndex = 3;
            button_Request.Text = "Заявки";
            button_Request.UseVisualStyleBackColor = false;
            button_Request.Click += button_Request_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 4;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(142, 95);
            labelName.Name = "labelName";
            labelName.Size = new Size(77, 18);
            labelName.TabIndex = 5;
            labelName.Text = "labelName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 118);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 6;
            label1.Text = "Роль: Менеджер";
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 412);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(button1);
            Controls.Add(button_Request);
            Controls.Add(pictureBox1);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            Load += ManagerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_Request;
        private Button button1;
        private Label labelName;
        private Label label1;
    }
}