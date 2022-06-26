using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App.Properties
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }
        private void ShowAll_PBOX_Click(object sender, EventArgs e)
        {
            AllData DATA = new AllData();
            DATA.ShowDialog();
        }
        private void FilterRecord_PBOX_Click(object sender, EventArgs e)
        {
            var Files = Directory.EnumerateFiles(@"C:\Users\pc\Desktop\OOP\Contract Tracing File");
            List<string> DATE = new List<string>();
            string Date = DATE_VIEW.Text;
            byte Results = 0;
            foreach (string file in Files)
            {
                string channel = File.ReadAllText(file);
                if (channel.Contains(Date))
                {
                    var date = channel.Substring(channel.IndexOf(Date));
                    Results++;
                }
            }
            if (Results != 0)
            {
                MessageBox.Show("We found " + Results + " record on the List");
            }
            else
            {
                MessageBox.Show("Nothing in the List");
            }
        }
    }
}

