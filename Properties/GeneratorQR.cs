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
using System.Media;

namespace Contact_Tracing_App.Properties
{
    public partial class QR_Generator : Form
    {
        SoundPlayer Click = new SoundPlayer(@"C:\Users\pc\Desktop\OOP\Contact Tracing App\Picture and Sounds\Click.wav");
        public QR_Generator()
        {
            InitializeComponent();
            string path1 = @"C:\Users\pc\Desktop\OOP\Contract Tracing File\QRCODE.txt";
            StreamReader INFO = new StreamReader(path1);
            string DATA = INFO.ReadToEnd();
            QR_TXT.Text = DATA.ToString();
        }
        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            Click.Play();
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData INFO = QR.CreateQrCode(QR_TXT.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode CODE = new QRCode(INFO);
            QRPIC.Image = CODE.GetGraphic(5);
        }
    }
}
