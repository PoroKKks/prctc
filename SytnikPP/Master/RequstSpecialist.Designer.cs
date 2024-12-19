namespace SytnikPP
{
    partial class RequstSpecialist
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
            dataGridView = new DataGridView();
            button_Back = new Button();
            buttonEND = new Button();
            buttonOtchet = new Button();
            labelCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 0;
            label1.Text = "Заявки";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 192);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(788, 229);
            dataGridView.TabIndex = 1;
            // 
            // button_Back
            // 
            button_Back.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Back.Location = new Point(712, 12);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(88, 35);
            button_Back.TabIndex = 2;
            button_Back.Text = "Назад";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // buttonEND
            // 
            buttonEND.BackColor = Color.DarkGray;
            buttonEND.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEND.Location = new Point(200, 454);
            buttonEND.Name = "buttonEND";
            buttonEND.Size = new Size(161, 45);
            buttonEND.TabIndex = 3;
            buttonEND.Text = "Завершить заявку";
            buttonEND.UseVisualStyleBackColor = false;
            buttonEND.Click += buttonEND_Click;
            // 
            // buttonOtchet
            // 
            buttonOtchet.BackColor = Color.DarkGray;
            buttonOtchet.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOtchet.Location = new Point(458, 454);
            buttonOtchet.Name = "buttonOtchet";
            buttonOtchet.Size = new Size(161, 45);
            buttonOtchet.TabIndex = 4;
            buttonOtchet.Text = "Создать отчет";
            buttonOtchet.UseVisualStyleBackColor = false;
            buttonOtchet.Click += buttonOtchet_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCount.Location = new Point(12, 435);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(38, 18);
            labelCount.TabIndex = 5;
            labelCount.Text = "label";
            // 
            // RequstSpecialist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(812, 511);
            Controls.Add(labelCount);
            Controls.Add(buttonOtchet);
            Controls.Add(buttonEND);
            Controls.Add(button_Back);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Name = "RequstSpecialist";
            Text = "RequstSpecialist";
            Load += RequstSpecialist_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private Button button_Back;
        private Button buttonEND;
        private Button buttonOtchet;
        private Label labelCount;
    }
}