namespace SytnikPP
{
    partial class RequestAddClient
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
            comboBoxType = new ComboBox();
            label3 = new Label();
            comboBoxModel = new ComboBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            buttonSend = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 72);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 0;
            label1.Text = "Создание заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 1;
            label2.Text = "Выберите тип";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(12, 161);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(406, 29);
            comboBoxType.TabIndex = 2;
            comboBoxType.SelectionChangeCommitted += comboBoxType_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 217);
            label3.Name = "label3";
            label3.Size = new Size(150, 24);
            label3.TabIndex = 3;
            label3.Text = "Выберите модель";
            // 
            // comboBoxModel
            // 
            comboBoxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(12, 257);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(406, 29);
            comboBoxModel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 308);
            label4.Name = "label4";
            label4.Size = new Size(158, 24);
            label4.TabIndex = 5;
            label4.Text = "Опишите проблему";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 342);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(406, 96);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.DarkGray;
            buttonSend.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSend.Location = new Point(104, 452);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(217, 40);
            buttonSend.TabIndex = 7;
            buttonSend.Text = "Отправить заявку";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(335, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(83, 35);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // RequestAddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(430, 504);
            Controls.Add(buttonBack);
            Controls.Add(buttonSend);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(comboBoxModel);
            Controls.Add(label3);
            Controls.Add(comboBoxType);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RequestAddClient";
            Text = "RequestAddClient";
            Load += RequestAddClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxType;
        private Label label3;
        private ComboBox comboBoxModel;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button buttonSend;
        private Button buttonBack;
    }
}