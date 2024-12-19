namespace SytnikPP
{
    partial class RedactRequest
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
            comboBoxType = new ComboBox();
            comboBoxModel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxRequest = new ComboBox();
            label5 = new Label();
            labelStartData = new Label();
            labelRequestStatus = new Label();
            labelMaster = new Label();
            button1 = new Button();
            buttonEdit = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(12, 136);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(234, 29);
            comboBoxType.TabIndex = 0;
            comboBoxType.SelectionChangeCommitted += comboBoxType_SelectionChangeCommitted;
            // 
            // comboBoxModel
            // 
            comboBoxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(12, 208);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(234, 29);
            comboBoxModel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 2;
            label1.Text = "Вид техники";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 3;
            label2.Text = "Модель техники";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 5;
            label3.Text = "Описание проблемы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 38);
            label4.Name = "label4";
            label4.Size = new Size(297, 31);
            label4.TabIndex = 6;
            label4.Text = "Редактирование заявки";
            // 
            // comboBoxRequest
            // 
            comboBoxRequest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRequest.FormattingEnabled = true;
            comboBoxRequest.Location = new Point(531, 136);
            comboBoxRequest.Name = "comboBoxRequest";
            comboBoxRequest.Size = new Size(121, 29);
            comboBoxRequest.TabIndex = 7;
            comboBoxRequest.SelectionChangeCommitted += comboBoxRequest_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(531, 95);
            label5.Name = "label5";
            label5.Size = new Size(117, 24);
            label5.TabIndex = 8;
            label5.Text = "Номер заявки";
            // 
            // labelStartData
            // 
            labelStartData.AutoSize = true;
            labelStartData.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStartData.Location = new Point(531, 178);
            labelStartData.Name = "labelStartData";
            labelStartData.Size = new Size(97, 18);
            labelStartData.TabIndex = 9;
            labelStartData.Text = "labelStartData";
            // 
            // labelRequestStatus
            // 
            labelRequestStatus.AutoSize = true;
            labelRequestStatus.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRequestStatus.Location = new Point(531, 211);
            labelRequestStatus.Name = "labelRequestStatus";
            labelRequestStatus.Size = new Size(125, 18);
            labelRequestStatus.TabIndex = 10;
            labelRequestStatus.Text = "labelRequestStatus";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMaster.Location = new Point(531, 242);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(82, 18);
            labelMaster.TabIndex = 11;
            labelMaster.Text = "labelMaster";
            // 
            // button1
            // 
            button1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(604, 12);
            button1.Name = "button1";
            button1.Size = new Size(89, 35);
            button1.TabIndex = 12;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkGray;
            buttonEdit.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(285, 383);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(163, 40);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 293);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 130);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // RedactRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(705, 450);
            Controls.Add(richTextBox1);
            Controls.Add(buttonEdit);
            Controls.Add(button1);
            Controls.Add(labelMaster);
            Controls.Add(labelRequestStatus);
            Controls.Add(labelStartData);
            Controls.Add(label5);
            Controls.Add(comboBoxRequest);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxModel);
            Controls.Add(comboBoxType);
            Name = "RedactRequest";
            Text = "RedactRequest";
            Load += RedactRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxType;
        private ComboBox comboBoxModel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxRequest;
        private Label label5;
        private Label labelStartData;
        private Label labelRequestStatus;
        private Label labelMaster;
        private Button button1;
        private Button buttonEdit;
        private RichTextBox richTextBox1;
    }
}