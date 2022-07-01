using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Contact_Tracing_App.Properties
{
    public partial class QR_Generator : Form
    {
        public QR_Generator()
        {
            InitializeComponent();
            string path1 = @"C:\Users\pc\Desktop\OOP\Contract Tracing File\QRCODE.txt";
            StreamReader INFO = new StreamReader(path1);
            string DATA = INFO.ReadToEnd();
            QRcode_Txt.Text = DATA.ToString();
        }

        private void Generate_BTN_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData INFO = QR.CreateQrCode(QRcode_Txt.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode CODE = new QRCode(INFO);
            QR_PIC.Image = CODE.GetGraphic(5);
        }
    }
}
