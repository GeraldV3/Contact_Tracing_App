using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App.Properties
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }
        private void LastName_BOX_Enter(object sender, EventArgs e)
        {
            if (LastName_BOX.Text == "Last Name")
                LastName_BOX.Text = "";
                LastName_BOX.ForeColor = Color.Black;
        }
        private void LastName_BOX_Leave(object sender, EventArgs e)
        {
            if (LastName_BOX.Text == "")
                LastName_BOX.Text = "Last Name";
                LastName_BOX.ForeColor = Color.Gray;
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter(@"C:\Users\pc\Desktop\Hello.txt");
            File.WriteLine("Last Name : " + LastName_BOX.Text);
            File.WriteLine("First Name : " + FirstName_BOX.Text);
            File.WriteLine("Middle Name : " + MiddleName_BOX.Text);
            File.WriteLine("Ext. Name : " + ExtName_BOX.Text);
            File.WriteLine("ID : " + ID_BOX.Text);
            File.WriteLine("ID Number : " + IDNumber_BOX.Text);
            File.WriteLine("Home Number : " + HomeNumber_BOX.Text);
            File.Close();
        }
        private void FirstName_BOX_Enter(object sender, EventArgs e)
        {
            if (FirstName_BOX.Text == "First Name")
                FirstName_BOX.Text = "";
                FirstName_BOX.ForeColor = Color.Black;
        }
        private void FirstName_BOX_Leave(object sender, EventArgs e)
        {
            if (FirstName_BOX.Text == "")
                FirstName_BOX.Text = "First Name";
                FirstName_BOX.ForeColor = Color.Gray;
        }
        private void MiddleName_BOX_Enter(object sender, EventArgs e)
        {
            if (MiddleName_BOX.Text == "Middle Name")
                MiddleName_BOX.Text = "";
                MiddleName_BOX.ForeColor = Color.Black;
        }

        private void MiddleName_BOX_Leave(object sender, EventArgs e)
        {
            if (MiddleName_BOX.Text == "")
                MiddleName_BOX.Text = "Middle Name";
                MiddleName_BOX.ForeColor = Color.Gray;
        }

        private void ExtName_BOX_Enter(object sender, EventArgs e)
        {
            if (ExtName_BOX.Text == "Ext. Name")
                ExtName_BOX.Text = "";
                ExtName_BOX.ForeColor = Color.Black;
        }
        private void ExtName_BOX_Leave(object sender, EventArgs e)
        {
            if (ExtName_BOX.Text == "")
                ExtName_BOX.Text = "Ext. Name";
                ExtName_BOX.ForeColor = Color.Gray;
        }

        private void ID_BOX_Enter(object sender, EventArgs e)
        {
            if (ID_BOX.Text == "ID")
                ID_BOX.Text = "";
                ID_BOX.ForeColor = Color.Black;
        }
        private void ID_BOX_Leave(object sender, EventArgs e)
        {
           if (ID_BOX.Text == "")
               ID_BOX.Text = "ID";
               ID_BOX.ForeColor = Color.Gray;
        }

        private void IDNumber_BOX_Enter(object sender, EventArgs e)
        {
            if (IDNumber_BOX.Text == "ID Number")
                IDNumber_BOX.Text = "";
                IDNumber_BOX.ForeColor = Color.Black;
        }
        private void IDNumber_BOX_Leave(object sender, EventArgs e)
        {
            if (IDNumber_BOX.Text == "")
                IDNumber_BOX.Text = "ID Number";
                IDNumber_BOX.ForeColor = Color.Gray;
        }

        private void HomeNumber_BOX_Enter(object sender, EventArgs e)
        {
            if (HomeNumber_BOX.Text == "Home Number")
                HomeNumber_BOX.Text = "";
                HomeNumber_BOX.ForeColor = Color.Black;
        }
        private void HomeNumber_BOX_Leave(object sender, EventArgs e)
        {
            if (HomeNumber_BOX.Text == "")
                HomeNumber_BOX.Text = "Home Number";
                HomeNumber_BOX.ForeColor = Color.Gray;
        }
    }
}

