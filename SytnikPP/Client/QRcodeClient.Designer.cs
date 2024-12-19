namespace SytnikPP
{
    partial class QRcodeClient
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(348, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(97, 37);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 374);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // QRcodeClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(457, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            Name = "QRcodeClient";
            Text = "QRcodeClient";
            Load += QRcodeClient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private PictureBox pictureBox1;
    }
}