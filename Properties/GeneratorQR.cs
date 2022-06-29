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
            string path = @"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt";
            StreamReader ALL = new StreamReader(path);
            string DATA = ALL.ReadToEnd();
            QRcode_Txt.Text = DATA.ToString();
        }

        private void Generate_BTN_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(QRcode_Txt.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            QR_PIC.Image = code.GetGraphic(5);
        }
    }
}
