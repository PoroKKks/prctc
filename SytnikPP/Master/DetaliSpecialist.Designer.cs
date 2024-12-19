namespace SytnikPP
{
    partial class DetaliSpecialist
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
            label1 = new Label();
            label2 = new Label();
            comboBox = new ComboBox();
            button1 = new Button();
            buttonBack = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 114);
            label1.Name = "label1";
            label1.Size = new Size(211, 31);
            label1.TabIndex = 0;
            label1.Text = "Заказать детали";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 1;
            label2.Text = "Заявка";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(12, 213);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 473);
            button1.Name = "button1";
            button1.Size = new Size(224, 40);
            button1.TabIndex = 4;
            button1.Text = "Заказать деталь";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(382, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 36);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 268);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(460, 199);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // DetaliSpecialist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 525);
            Controls.Add(richTextBox1);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetaliSpecialist";
            Text = "DetaliSpecialist";
            Load += DetaliSpecialist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox;
        private Button button1;
        private Button buttonBack;
        private RichTextBox richTextBox1;
    }
}