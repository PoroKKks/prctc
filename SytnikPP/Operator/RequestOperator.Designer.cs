namespace SytnikPP
{
    partial class RequestOperator
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
            buttonBack = new Button();
            dataGridView = new DataGridView();
            label2 = new Label();
            textBoxFilter = new TextBox();
            comboBox1 = new ComboBox();
            buttonMaster = new Button();
            buttonData = new Button();
            labelAVG = new Label();
            dateTimePicker = new DateTimePicker();
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
            // buttonBack
            // 
            buttonBack.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(706, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 37);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 119);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(788, 229);
            dataGridView.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 363);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 3;
            label2.Text = "Фильтр";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(12, 394);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(788, 23);
            textBoxFilter.TabIndex = 4;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 426);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(384, 23);
            comboBox1.TabIndex = 5;
            // 
            // buttonMaster
            // 
            buttonMaster.BackColor = Color.DarkGray;
            buttonMaster.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMaster.Location = new Point(12, 461);
            buttonMaster.Name = "buttonMaster";
            buttonMaster.Size = new Size(384, 38);
            buttonMaster.TabIndex = 7;
            buttonMaster.Text = "Назначить специалиста";
            buttonMaster.UseVisualStyleBackColor = false;
            buttonMaster.Click += buttonMaster_Click;
            // 
            // buttonData
            // 
            buttonData.BackColor = Color.DarkGray;
            buttonData.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonData.Location = new Point(412, 461);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(388, 38);
            buttonData.TabIndex = 8;
            buttonData.Text = "Изменить дату";
            buttonData.UseVisualStyleBackColor = false;
            buttonData.Click += buttonData_Click;
            // 
            // labelAVG
            // 
            labelAVG.AutoSize = true;
            labelAVG.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAVG.Location = new Point(12, 86);
            labelAVG.Name = "labelAVG";
            labelAVG.Size = new Size(223, 18);
            labelAVG.TabIndex = 9;
            labelAVG.Text = "Среднее время выполнения заявок:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Location = new Point(412, 426);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(388, 29);
            dateTimePicker.TabIndex = 7;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCount.Location = new Point(723, 367);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(77, 18);
            labelCount.TabIndex = 10;
            labelCount.Text = "labelCount";
            // 
            // RequestOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(812, 511);
            Controls.Add(labelCount);
            Controls.Add(dateTimePicker);
            Controls.Add(labelAVG);
            Controls.Add(buttonData);
            Controls.Add(buttonMaster);
            Controls.Add(comboBox1);
            Controls.Add(textBoxFilter);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "RequestOperator";
            Text = "RequestOperator";
            Load += RequestOperator_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private DataGridView dataGridView;
        private Label label2;
        private TextBox textBoxFilter;
        private ComboBox comboBox1;
        private Button buttonMaster;
        private Button buttonData;
        private Label labelAVG;
        private DateTimePicker dateTimePicker;
        private Label labelCount;
    }
}