namespace SytnikPP
{
    partial class CommentClient
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
            comboBoxRequest = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            labelCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 43);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 0;
            label1.Text = "Оставить комментарий";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.Location = new Point(472, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(85, 33);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // comboBoxRequest
            // 
            comboBoxRequest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRequest.FormattingEnabled = true;
            comboBoxRequest.Location = new Point(12, 169);
            comboBoxRequest.Name = "comboBoxRequest";
            comboBoxRequest.Size = new Size(121, 29);
            comboBoxRequest.TabIndex = 2;
            comboBoxRequest.SelectionChangeCommitted += comboBoxRequest_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 3;
            label2.Text = "Заявка";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 223);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 192);
            dataGridView1.TabIndex = 4;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(260, 426);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(38, 15);
            labelCount.TabIndex = 5;
            labelCount.Text = "label3";
            // 
            // CommentClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(569, 450);
            Controls.Add(labelCount);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBoxRequest);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "CommentClient";
            Text = "CommentClient";
            Load += CommentClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private ComboBox comboBoxRequest;
        private Label label2;
        private DataGridView dataGridView1;
        private Label labelCount;
    }
}