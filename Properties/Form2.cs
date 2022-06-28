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
            byte Results = 0;
            StreamReader reader = new StreamReader(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt");
            List<string> dates = new List<string>();
            while (!reader.EndOfStream)
            {
                string DATA = reader.ReadLine();
                if (DATA.Contains(FilterDate))
                {
                    Results++;
                    dates.Add(DATA);
                }
            }
            if (Results != 0)
            {
                reader.Close();
                StreamWriter fileDATE = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\DATE.txt");
                foreach (string DATA in dates)
                {
                    fileDATE.WriteLine(DATA);
                }
                MessageBox.Show("We found " + Results.ToString() + " in the Record");
                fileDATE.Close();
                FilterDateInfo FORM = new FilterDateInfo();
                FORM.ShowDialog();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Nothing in the Record!");
            }
        }
        private void Diagnosed_BOX_Enter(object sender, EventArgs e)
        {

        }
    }
}