﻿using System;
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
                LastName_BOX.ForeColor = Color.Silver;
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter(@"C:\Users\pc\Desktop\Hello.txt");
            File.WriteLine("Last Name : " + LastName_BOX.Text);
            File.WriteLine("First Name : " + FirstName_BOX.Text);
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
                FirstName_BOX.ForeColor = Color.Silver;
        }
    }
}

