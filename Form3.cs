using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class CovidPositive : Form
    {
        public CovidPositive()
        {
            InitializeComponent();
        }
        private void DATA_BTN3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\Desktop\OOP\Contract Tracing File\COVID.txt";
            StreamReader ALL = new StreamReader(path);
            string DATA = ALL.ReadToEnd();
            INFO_BOX3.Text = DATA.ToString();
        }
    }
}
