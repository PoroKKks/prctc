namespace SytnikPP
{
    partial class CommentSpecialist
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
            buttonBack = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox = new ComboBox();
            buttonComment = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(388, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(84, 38);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 114);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 1;
            label1.Text = "Оставить комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 2;
            label2.Text = "Заявка";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(12, 213);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 3;
            // 
            // buttonComment
            // 
            buttonComment.BackColor = Color.DarkGray;
            buttonComment.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComment.Location = new Point(120, 473);
            buttonComment.Name = "buttonComment";
            buttonComment.Size = new Size(224, 40);
            buttonComment.TabIndex = 5;
            buttonComment.Text = "Оставить комментарий";
            buttonComment.UseVisualStyleBackColor = false;
            buttonComment.Click += buttonComment_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 268);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(460, 199);
            richTextBox.TabIndex = 6;
            richTextBox.Text = "";
            // 
            // CommentSpecialist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 525);
            Controls.Add(richTextBox);
            Controls.Add(buttonComment);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Name = "CommentSpecialist";
            Text = "CommentSpecialist";
            Load += CommentSpecialist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label label1;
        private Label label2;
        private ComboBox comboBox;
        private Button buttonComment;
        private RichTextBox richTextBox;
    }
}