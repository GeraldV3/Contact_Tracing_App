using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Aztec;
using ZXing;
using ZXing.Windows.Compatibility;
using System.Media;

namespace Contact_Tracing_App.Properties
{
    public partial class Scanner_Form : Form
    {
        SoundPlayer Click = new SoundPlayer(@"C:\Users\pc\Desktop\OOP\Contact Tracing App\Picture and Sounds\NEW Sound.wav");
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public Scanner_Form()
        {
            InitializeComponent();
        }
        private void Scanner_Form_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                Camera_Device.Items.Add(Device.Name);
            Camera_Device.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            Click.Play();
            FinalFrame = new VideoCaptureDevice(CaptureDevice[Camera_Device.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Webcam_PIC.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Scanner_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)Webcam_PIC.Image);
                try
                {
                    string decoded = result.ToString().Trim();
                    if (decoded != "")
                    {
                        Info_BOX.Text = decoded;
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void Reader_BTN_Click(object sender, EventArgs e)
        {
            String DATA = Info_BOX.Text;
            if (DATA == "")
            {
                MessageBox.Show("Try again!", "Empty!");
            }
            else
            {
                Click.Play();
                StreamWriter QRdata = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\SCANNED QRCode.txt", true);
                QRdata.WriteLine(DATA);
                QRdata.Close();
                MessageBox.Show("Your Information is Now Registered!");
                MessageBox.Show("Thank You!");
                Application.Restart();
            }
        }
    }
}
