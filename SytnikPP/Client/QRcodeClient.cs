using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SytnikPP
{
    public partial class QRcodeClient : Form
    {
        public QRcodeClient()
        {
            InitializeComponent();

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(@"https://google.com", QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(12);

            Bitmap bmp;
            using (var ms = new MemoryStream(qrCodeAsPngByteArr))
            {
                bmp = new Bitmap(ms);
            }

            pictureBox1.Image = bmp;
        }

      




        private void QRcodeClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
       => Close();
    }
}
