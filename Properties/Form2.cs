﻿using System;
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
    }
}
