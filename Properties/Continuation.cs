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
    public partial class Continuation : Form
    {
        public Continuation()
        {
            InitializeComponent();
        }
        private void Submet_BTN_Click(object sender, EventArgs e)
        {
            StreamWriter File1 = new StreamWriter(@"C:\Users\pc\Desktop\Hello.txt", true);
            File1.WriteLine("Directly Interaction with Covid patient? " + Interaction_BOX.Text);
            File1.WriteLine("Drug Allergy? " + Drug_BOX.Text);
            File1.Close();
        }
        private void Interaction_BOX_Enter(object sender, EventArgs e)
        {
            if (Interaction_BOX.Text == "Directly Interaction with Covid Patient?")
                Interaction_BOX.Text = "";
                Interaction_BOX.ForeColor = Color.Black;
        }
        private void Interaction_BOX_Leave(object sender, EventArgs e)
        {
            if (Interaction_BOX.Text == "")
                Interaction_BOX.Text = "Directly Interaction with Covid Patient?";
                Interaction_BOX.ForeColor = Color.Gray;
        }
        private void Drug_BOX_Enter(object sender, EventArgs e)
        {
            if (Drug_BOX.Text == "Drug Allergy?")
                Drug_BOX.Text = "";
                Drug_BOX.ForeColor = Color.Black;
        }
        private void Drug_BOX_Leave(object sender, EventArgs e)
        {
            if (Drug_BOX.Text == "")
                Drug_BOX.Text = "Drug Allergy?";
                Drug_BOX.ForeColor = Color.Gray;
        }
    }
}
