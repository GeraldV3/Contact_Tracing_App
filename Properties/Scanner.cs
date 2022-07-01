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

namespace Contact_Tracing_App.Properties
{
    public partial class Scanner_Form : Form
    {
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
            Timer.Start();
        }
    }
}
