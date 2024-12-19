namespace SytnikPP
{
    partial class SpecialistMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialistMenu));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button_Request = new Button();
            button_Detali = new Button();
            button_Comment = new Button();
            label_Name = new Label();
            label2 = new Label();
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
            // button1
            // 
            button1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 1;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_Request
            // 
            button_Request.BackColor = Color.DarkGray;
            button_Request.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Request.Location = new Point(80, 270);
            button_Request.Name = "button_Request";
            button_Request.Size = new Size(238, 33);
            button_Request.TabIndex = 2;
            button_Request.Text = "Заявки";
            button_Request.UseVisualStyleBackColor = false;
            button_Request.Click += button_RequestClick;
            // 
            // button_Detali
            // 
            button_Detali.BackColor = Color.DarkGray;
            button_Detali.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Detali.Location = new Point(80, 309);
            button_Detali.Name = "button_Detali";
            button_Detali.Size = new Size(238, 33);
            button_Detali.TabIndex = 3;
            button_Detali.Text = "Заказать детали";
            button_Detali.UseVisualStyleBackColor = false;
            button_Detali.Click += button_Detali_Click;
            // 
            // button_Comment
            // 
            button_Comment.BackColor = Color.DarkGray;
            button_Comment.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Comment.Location = new Point(80, 348);
            button_Comment.Name = "button_Comment";
            button_Comment.Size = new Size(238, 33);
            button_Comment.TabIndex = 4;
            button_Comment.Text = "Оставить комментарий";
            button_Comment.UseVisualStyleBackColor = false;
            button_Comment.Click += button_Comment_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(142, 79);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(44, 18);
            label_Name.TabIndex = 5;
            label_Name.Text = "Label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 112);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 6;
            label2.Text = "Роль: Мастер";
            // 
            // SpecialistMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 412);
            Controls.Add(label2);
            Controls.Add(label_Name);
            Controls.Add(button_Comment);
            Controls.Add(button_Detali);
            Controls.Add(button_Request);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "SpecialistMenu";
            Text = "SpecialistMenu";
            Load += SpecialistMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button_Request;
        private Button button_Detali;
        private Button button_Comment;
        private Label label_Name;
        private Label label2;
    }
}