namespace SytnikPP
{
    partial class OperatorMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorMenu));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label_Name = new Label();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(77, 316);
            button1.Name = "button1";
            button1.Size = new Size(238, 33);
            button1.TabIndex = 1;
            button1.Text = "Заявки";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(142, 81);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(77, 18);
            label_Name.TabIndex = 2;
            label_Name.Text = "labelName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 110);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 3;
            label2.Text = "Роль: Оператор";
            // 
            // button2
            // 
            button2.Location = new Point(310, 12);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 4;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OperatorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 412);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label_Name);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "OperatorMenu";
            Text = "OperatorMenu";
            Load += OperatorMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label_Name;
        private Label label2;
        private Button button2;
    }
}