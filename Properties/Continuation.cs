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
            Interaction_LBL.Visible = true;
            Drug_LBL.Visible = true;    
            Insect_LBL.Visible = true;  
            Hypertension_LBL.Visible = true;
            Kidney_LBL.Visible = true;
            Asthma_LBL.Visible = true;  
            Cancer_LBL.Visible = true;  
            Food_LBL.Visible= true;
            Pet_LBL.Visible = true; 
            Diabetes_LBL.Visible = true;    
            Diagnosed_LBL.Visible = true;
            DATE_LBL.Visible = true;
        }
        private void Submet_BTN_Click(object sender, EventArgs e)
        {
          if (Interaction_BOX.Text == "" || Drug_BOX.Text == "" || Insect_BOX.Text == "" || Hypertension_BOX.Text == "" || Kidney_BOX.Text == "" || Asthma_BOX.Text == ""
                || Cancer_BOX.Text == "" || Food_BOX.Text == "" || Pet_BOX.Text == "" || Diabetes_BOX.Text == "" || Diagnosed_BOX.Text == "")
            {
                MessageBox.Show("Please Complete the Form", "Error", MessageBoxButtons.OK);
            }
          else
            {
                StreamWriter File1 = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Info.txt", true);
                File1.WriteLine("Directly Interaction with Covid patient? " + Interaction_BOX.Text);
                File1.WriteLine("Drug Allergy? " + Drug_BOX.Text);
                File1.WriteLine("Insect Allergy? " + Insect_BOX.Text);
                File1.WriteLine("Hypertension? " + Hypertension_BOX.Text);
                File1.WriteLine("Kidney Disease? " + Kidney_BOX.Text);
                File1.WriteLine("Asthma? " + Asthma_BOX.Text);
                File1.WriteLine("Cancer? " + Cancer_BOX.Text);
                File1.WriteLine("Food Allergy? " + Food_BOX.Text);
                File1.WriteLine("Pet Allergy? " + Pet_BOX.Text);
                File1.WriteLine("Diabetes? " + Diabetes_BOX.Text);
                File1.WriteLine("Patient Diagnosed with Covid-19? " + Diagnosed_BOX.Text);
                File1.WriteLine("DATE: " + DATE_BOX.Text);
                File1.Close();
                MessageBox.Show("Thank You for your Particitipation!", "GodBless", MessageBoxButtons.OK);
                Application.Exit();
            }
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
        private void Kidney_BOX_Enter(object sender, EventArgs e)
        {
            if (Kidney_BOX.Text == "Kidney Disease?")
                Kidney_BOX.Text = "";
                Kidney_BOX.ForeColor = Color.Black;
        }
        private void Kidney_BOX_Leave(object sender, EventArgs e)
        {
            if (Kidney_BOX.Text == "")
                Kidney_BOX.Text = "Kidney Disease?";
                Kidney_BOX.ForeColor = Color.Gray;
        }
        private void Asthma_BOX_Enter(object sender, EventArgs e)
        {
            if (Asthma_BOX.Text == "Asthma?")
                Asthma_BOX.Text = "";
                Asthma_BOX.ForeColor = Color.Black;
        }
        private void Asthma_BOX_Leave(object sender, EventArgs e)
        {
            if (Asthma_BOX.Text == "")
                Asthma_BOX.Text = "Asthma?";
                Asthma_BOX.ForeColor = Color.Gray;
        }
        private void Cancer_BOX_Enter(object sender, EventArgs e)
        {
            if (Cancer_BOX.Text == "Cancer?")
                Cancer_BOX.Text = "";
                Cancer_BOX.ForeColor = Color.Black;
        }
        private void Cancer_BOX_Leave(object sender, EventArgs e)
        {
            if (Cancer_BOX.Text == "")
                Cancer_BOX.Text = "Cancer?";
                Cancer_BOX.ForeColor = Color.Gray;
        }
        private void Food_BOX_Enter(object sender, EventArgs e)
        {
            if (Food_BOX.Text == "Food Allergy?")
                Food_BOX.Text = "";
                Food_BOX.ForeColor = Color.Black;
        }
        private void Food_BOX_Leave(object sender, EventArgs e)
        {
            if (Food_BOX.Text == "")
                Food_BOX.Text = "Food Allergy?";
                Food_BOX.ForeColor = Color.Gray;
        }
        private void Pet_BOX_Enter(object sender, EventArgs e)
        {
            if (Pet_BOX.Text == "Pet Allergy?")
                Pet_BOX.Text = "";
                Pet_BOX.ForeColor = Color.Black;
        }
        private void Pet_BOX_Leave(object sender, EventArgs e)
        {
            if (Pet_BOX.Text == "")
                Pet_BOX.Text = "Pet Allergy?";
                Pet_BOX.ForeColor = Color.Gray;
        }
        private void Diabetes_BOX_Enter(object sender, EventArgs e)
        {
            if (Diabetes_BOX.Text == "Diabetes?")
                Diabetes_BOX.Text = "";
                Diabetes_BOX.ForeColor = Color.Black;
        }
        private void Diabetes_BOX_Leave(object sender, EventArgs e)
        {
            if (Diabetes_BOX.Text == "")
                Diabetes_BOX.Text = "Diabetes?";
                Diabetes_BOX.ForeColor = Color.Gray;
        }
        private void Diagnosed_BOX_Enter(object sender, EventArgs e)
        {
            if (Diagnosed_BOX.Text == "Yes/No")
                Diagnosed_BOX.Text = "";
                Diagnosed_BOX.ForeColor = Color.Black;
        }
        private void Diagnosed_BOX_Leave(object sender, EventArgs e)
        {
            if (Diagnosed_BOX.Text == "")
                Diagnosed_BOX.Text = "Yes/No";
                Diagnosed_BOX.ForeColor = Color.Gray;
        }
        private void Class_BOX_Enter(object sender, EventArgs e)
        {
            if (Class_BOX.Text == "Asymptomatic, Mild, Moderate, Severe, Critical, None")
                Class_BOX.Text = "";
                Class_BOX.ForeColor = Color.Black;
        }
        private void Class_BOX_Leave(object sender, EventArgs e)
        {
            if (Class_BOX.Text == "")
                Class_BOX.Text = "Asymptomatic, Mild, Moderate, Severe, Critical, None";
                Class_BOX.ForeColor = Color.Gray;
        }
        private void Interaction_BOX_Click(object sender, EventArgs e)
        {
            Interaction_LBL.Visible = false;
        }
        private void Drug_BOX_Click(object sender, EventArgs e)
        {
            Drug_LBL.Visible = false;
        }
        private void Insect_BOX_Click(object sender, EventArgs e)
        {
            Insect_LBL.Visible = false;
        }
        private void Hypertension_BOX_Click(object sender, EventArgs e)
        {
            Hypertension_LBL.Visible = false;
        }
        private void Kidney_BOX_Click(object sender, EventArgs e)
        {
            Kidney_LBL.Visible = false;
        }
        private void Asthma_BOX_Click(object sender, EventArgs e)
        {
            Asthma_LBL.Visible = false;
        }
        private void Cancer_BOX_Click(object sender, EventArgs e)
        {
            Cancer_LBL.Visible = false;
        }
        private void Food_BOX_Click(object sender, EventArgs e)
        {
            Food_LBL.Visible = false;   
        }
        private void Pet_BOX_Click(object sender, EventArgs e)
        {
            Pet_LBL.Visible = false;
        }
        private void Diabetes_BOX_Click(object sender, EventArgs e)
        {
            Diabetes_LBL.Visible = false;
        }
        private void Diagnosed_BOX_Click(object sender, EventArgs e)
        {
            Diagnosed_LBL.Visible = false;
        }
        private void DATE_BOX_Enter(object sender, EventArgs e)
        {
         if(DATE_BOX.Text == "dd/mm/yy")
            DATE_BOX.Text = "";
            DATE_BOX.ForeColor = Color.Black;
        }
        private void DATE_BOX_Leave(object sender, EventArgs e)
        {
          if(DATE_BOX.Text == "")
            DATE_BOX.Text = "dd/mm/yy";
            DATE_BOX.ForeColor = Color.Gray;
        }
        private void DATE_BOX_Click(object sender, EventArgs e)
        {
            DATE_LBL.Visible = false;
        }
    }
}
