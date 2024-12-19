namespace SytnikPP.Manager
{
    partial class RequestManager
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            labelCount = new Label();
            buttonObrab = new Button();
            buttonUstanov = new Button();
            buttonDelete = new Button();
            comboBoxSpecialist = new ComboBox();
            comboBoxStatus = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 69);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 0;
            label1.Text = "Заявки";
            // 
            // button1
            // 
            button1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(691, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 232);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 29);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 384);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 4;
            label2.Text = "Фильтр";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCount.Location = new Point(693, 384);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(95, 22);
            labelCount.TabIndex = 5;
            labelCount.Text = "labelCount";
            // 
            // buttonObrab
            // 
            buttonObrab.BackColor = Color.DarkGray;
            buttonObrab.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonObrab.Location = new Point(262, 480);
            buttonObrab.Name = "buttonObrab";
            buttonObrab.Size = new Size(158, 29);
            buttonObrab.TabIndex = 2;
            buttonObrab.Text = "Обработать";
            buttonObrab.UseVisualStyleBackColor = false;
            buttonObrab.Click += buttonObrab_Click;
            // 
            // buttonUstanov
            // 
            buttonUstanov.BackColor = Color.DarkGray;
            buttonUstanov.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUstanov.Location = new Point(262, 546);
            buttonUstanov.Name = "buttonUstanov";
            buttonUstanov.Size = new Size(158, 29);
            buttonUstanov.TabIndex = 7;
            buttonUstanov.Text = "Установить статус";
            buttonUstanov.UseVisualStyleBackColor = false;
            buttonUstanov.Click += buttonUstanov_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DarkGray;
            buttonDelete.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(630, 544);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(158, 31);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить заявку";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxSpecialist
            // 
            comboBoxSpecialist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSpecialist.FormattingEnabled = true;
            comboBoxSpecialist.Location = new Point(12, 480);
            comboBoxSpecialist.Name = "comboBoxSpecialist";
            comboBoxSpecialist.Size = new Size(226, 29);
            comboBoxSpecialist.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(12, 546);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(226, 29);
            comboBoxStatus.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 455);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 11;
            label3.Text = "Специалист";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 521);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 516);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 13;
            label5.Text = "Статус";
            // 
            // RequestManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 587);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxSpecialist);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUstanov);
            Controls.Add(buttonObrab);
            Controls.Add(labelCount);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "RequestManager";
            Text = "RequestManager";
            Load += RequestManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Label labelCount;
        private Button buttonObrab;
        private Button buttonUstanov;
        private Button buttonDelete;
        private ComboBox comboBoxSpecialist;
        private ComboBox comboBoxStatus;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}