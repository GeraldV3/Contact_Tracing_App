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
            string FilterDate = DATE_VIEW.Text;
            int Results = 0;
            List<string> dates = new List<string>();
            StreamReader reader = new StreamReader(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt");
            while (!reader.EndOfStream)
            {
                string DATA = reader.ReadLine();
                if (DATA.Contains(FilterDate))
                {
                    Results++;
                }
            }
            if (Results != 0)
            {
                StreamWriter fileDATE = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Filter\DATE.txt", true);
                foreach (string DATA in dates)
                {
                    fileDATE.WriteLine();
                }
                MessageBox.Show("We found " + Results.ToString() + " in the Record");
                FilterDateInfo FORM = new FilterDateInfo();
                FORM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nothing in the Record!");
            }
        }
    }
}