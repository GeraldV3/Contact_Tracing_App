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
    }
}
