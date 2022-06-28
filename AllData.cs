using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class AllData : Form
    {
        public AllData()
        {
            InitializeComponent();
        }
        private void DATA_BTN_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt";
            StreamReader ALL = new StreamReader(path);
            string DATA = ALL.ReadToEnd();
            INFO_BOX.Text = DATA.ToString();
        }
    }
}
