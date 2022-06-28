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
            YesNo_LBL.Visible = true;
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
        private void COVID_BOX_Enter(object sender, EventArgs e)
        {
            if (COVID_BOX.Text == "Yes/No")
                COVID_BOX.Text = "";
                COVID_BOX.ForeColor = Color.Black;
        }
        private void COVID_BOX_Leave(object sender, EventArgs e)
        {
            if (COVID_BOX.Text == "")
                COVID_BOX.Text = "Yes/No";
                COVID_BOX.ForeColor = Color.Gray;
        }
        private void Covid19_BOX_Click(object sender, EventArgs e)
        {
            string Diagnosed = COVID_BOX.Text;
            byte Results = 0;
            StreamReader reader = new StreamReader(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt", true);
            List<string> Covid = new List<string>();
            while (!reader.EndOfStream)
            {
                string Positive = reader.ReadLine();
                if (Positive.Contains(Diagnosed))
                {
                    Results++;
                    Covid.Add(Positive);
                }
            }
            if (Results != 0)
            {
                reader.Close();
                StreamWriter file2 = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\COVID.txt");
                foreach (string Positive in Covid)
                {
                    file2.WriteLine(Positive);
                }
                MessageBox.Show("We found " + Results.ToString() + " in the Record");
                file2.Close();
                CovidPositive Next = new CovidPositive();
                Next.ShowDialog();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Wrong Spelling!");
            }
        }
        private void COVID_BOX_Click(object sender, EventArgs e)
        {
            YesNo_LBL.Visible = false;
        }
    }
}