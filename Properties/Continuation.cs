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
            File1.WriteLine("Insect Allergy? " + Insect_BOX.Text);
            File1.WriteLine("Hypertension? " + Hypertension_BOX.Text);
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
        private void Insect_BOX_Enter(object sender, EventArgs e)
        {
            if (Insect_BOX.Text == "Insect Allergy?")
                Insect_BOX.Text = "";
                Insect_BOX.ForeColor = Color.Black;
        }
        private void Insect_BOX_Leave(object sender, EventArgs e)
        {
            if (Insect_BOX.Text == "")
                Insect_BOX.Text = "Insect Allergy?";
                Insect_BOX.ForeColor = Color.Gray;
        }
        private void Hypertension_BOX_Enter(object sender, EventArgs e)
        {
            if (Hypertension_BOX.Text == "Hypertension?")
                Hypertension_BOX.Text = "";
                Hypertension_BOX.ForeColor = Color.Black;
        }
        private void Hypertension_BOX_Leave(object sender, EventArgs e)
        {
            if (Hypertension_BOX.Text == "")
                Hypertension_BOX.Text = "Hypertension?";
                Hypertension_BOX.ForeColor = Color.Gray;
        }
    }
}
