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
using System.Media;

namespace Contact_Tracing_App.Properties
{
    public partial class Questions : Form
    {
        SoundPlayer Click = new SoundPlayer(@"C:\Users\pc\Desktop\OOP\Contact Tracing App\Picture and Sounds\NEW Sound.wav");
        SoundPlayer Click1 = new SoundPlayer(@"C:\Users\pc\Desktop\OOP\Contact Tracing App\Picture and Sounds\Click.wav");
        public Questions()
        {
            InitializeComponent();
            LastName_LBL.Visible = true;
            FirstName_LBL.Visible = true;
            MiddleName_LBL.Visible = true;
            ExtName_LBL.Visible = true;
            HomeNumber_LBL.Visible = true;
            StreetName_LBL.Visible = true;
            Barangay_LBL.Visible = true;
            Municipality_LBL.Visible = true;
            ProvinceCity_LBL.Visible = true;
            Contact_LBL.Visible = true;
            Gender_LBL.Visible = true;
            CivilStatus_LBL.Visible = true;
            Diagnosed_LBL.Visible = true;
            DATE_LBL.Visible = true;

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
            Click.Play();
            if (LastName_BOX.Text == "" || FirstName_BOX.Text == "" || MiddleName_BOX.Text == "" || ExtName_BOX.Text == "" || HomeNumber_BOX.Text == "" || StreetName_BOX.Text == "" || Municipality_BOX.Text == "" || Contact_BOX.Text == "" || Gender_BOX.Text == ""
                || CivilStatus_BOX.Text == "" || Diagnosed_BOX.Text == "" || Class_BOX.Text == "" || DATE_BOX.Text == "")
            {
                MessageBox.Show("Please Complete the Form", "Error", MessageBoxButtons.OK);
            }    
            else
            {
                StreamWriter File = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\Information.txt", true);
                File.WriteLine(LastName_BOX.Text + ", " + FirstName_BOX.Text + ", " + MiddleName_BOX.Text + ", " +"Ext. Name " + ExtName_BOX.Text + " , "
                + HomeNumber_BOX.Text + ", "+ StreetName_BOX.Text + ", " + Barangay_BOX.Text + ", "  + Municipality_BOX.Text + ", "  +
                ProvinceCity_BOX.Text+ ", " + Contact_BOX.Text+  ", " + Gender_BOX.Text + ", " + CivilStatus_BOX.Text + ", " + "Patient Diagnosed with Covid-19? " + Diagnosed_BOX.Text
                + ", " + "Classfinication ? " + Class_BOX.Text + ", " + DATE_BOX.Text);
                File.Close();
                MessageBox.Show("Thank You for your Particitipation!", "GodBless!", MessageBoxButtons.OK);
                MessageBox.Show("Please Take a Screen Shot of your generated QR CODE", "Take Note!");
                QR_Generator QR = new QR_Generator();
                QR.ShowDialog();
            }
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
        private void StreetName_BOX_Enter(object sender, EventArgs e)
        {
            if (StreetName_BOX.Text == "Street Name")
                StreetName_BOX.Text = "";
                StreetName_BOX.ForeColor = Color.Black;
        }
        private void StreetName_BOX_Leave(object sender, EventArgs e)
        {
            if (StreetName_BOX.Text == "")
                StreetName_BOX.Text = "Street Name";
                StreetName_BOX.ForeColor = Color.Gray;
        }
        private void Barangay_BOX_Enter(object sender, EventArgs e)
        {
            if (Barangay_BOX.Text == "Barangay")
                Barangay_BOX.Text = "";
                Barangay_BOX.ForeColor = Color.Black;
        }
        private void Barangay_BOX_Leave(object sender, EventArgs e)
        {
            if (Barangay_BOX.Text == "")
                Barangay_BOX.Text = "Barangay";
                Barangay_BOX.ForeColor = Color.Gray;
        }
        private void Municipality_BOX_Enter(object sender, EventArgs e)
        {
            if (Municipality_BOX.Text == "Municipality")
                Municipality_BOX.Text = "";
                Municipality_BOX.ForeColor = Color.Black;
        }
        private void Municipality_BOX_Leave(object sender, EventArgs e)
        {
            if (Municipality_BOX.Text == "")
                Municipality_BOX.Text = "Municipality";
                Municipality_BOX.ForeColor = Color.Gray;
        }
        private void ProvinceCity_BOX_Enter(object sender, EventArgs e)
        {
            if (ProvinceCity_BOX.Text == "Province/City")
                ProvinceCity_BOX.Text = "";
                ProvinceCity_BOX.ForeColor = Color.Black;
        }
        private void ProvinceCity_BOX_Leave(object sender, EventArgs e)
        {
            if (ProvinceCity_BOX.Text == "")
                ProvinceCity_BOX.Text = "Province/City";
                ProvinceCity_BOX.ForeColor = Color.Gray;
        }
        private void Contact_BOX_Enter(object sender, EventArgs e)
        {
            if (Contact_BOX.Text == "0945 167 5095")
                Contact_BOX.Text = "";
                Contact_BOX.ForeColor = Color.Black;
        }
        private void Contact_BOX_Leave(object sender, EventArgs e)
        {
            if (Contact_BOX.Text == "")
                Contact_BOX.Text = "0945 167 5095";
                Contact_BOX.ForeColor = Color.Gray;
        }
        private void Gender_BOX_Enter(object sender, EventArgs e)
        {
            if (Gender_BOX.Text == "Gender")
                Gender_BOX.Text = "";
                Gender_BOX.ForeColor = Color.Black;
        }
        private void Gender_BOX_Leave(object sender, EventArgs e)
        {
            if (Gender_BOX.Text == "")
                Gender_BOX.Text = "Gender";
                Gender_BOX.ForeColor = Color.Gray;
        }
        private void CivilStatus_BOX_Enter(object sender, EventArgs e)
        {
            if (CivilStatus_BOX.Text == "Civil Status")
                CivilStatus_BOX.Text = "";
                CivilStatus_BOX.ForeColor = Color.Black;
        }
        private void CivilStatus_BOX_Leave(object sender, EventArgs e)
        {
            if (CivilStatus_BOX.Text == "")
                CivilStatus_BOX.Text = "Civil Status";
                CivilStatus_BOX.ForeColor = Color.Gray;
        }
        private void LastName_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            LastName_LBL.Visible = false;
        }
        private void FirstName_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            FirstName_LBL.Visible = false;
        }
        private void ExtName_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            ExtName_LBL.Visible = false;
        }
        private void HomeNumber_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            HomeNumber_LBL.Visible = false;
        }
        private void StreetName_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            StreetName_LBL.Visible=false;
        }
        private void Barangay_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Barangay_LBL.Visible=false;
        }
        private void Municipality_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Municipality_LBL.Visible=false; 
        }
        private void ProvinceCity_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            ProvinceCity_LBL.Visible=false; 
        }
        private void Contact_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Contact_LBL.Visible=false;  
        }
        private void Gender_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Gender_LBL.Visible=false;
        }
        private void Birthday_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Birthday_LBL.Visible=false;
        }
        private void CivilStatus_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            CivilStatus_LBL.Visible=false;
        }
        private void Diagnosed_BOX_Enter(object sender, EventArgs e)
        {
            if (Diagnosed_BOX.Text == "Positive/Negative")
                Diagnosed_BOX.Text = "";
                Diagnosed_BOX.ForeColor = Color.Black;
        }
        private void Diagnosed_BOX_Leave(object sender, EventArgs e)
        {
            if (Diagnosed_BOX.Text == "")
                Diagnosed_BOX.Text = "Positive/Negative";
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
        private void DATE_BOX_Enter(object sender, EventArgs e)
        {
            if (DATE_BOX.Text == "mm/dd/yy")
                DATE_BOX.Text = "";
                DATE_BOX.ForeColor = Color.Black;
        }
        private void DATE_BOX_Leave(object sender, EventArgs e)
        {
            if (DATE_BOX.Text == "")
                DATE_BOX.Text = "mm/dd/yy";
                DATE_BOX.ForeColor = Color.Gray;
        }
        private void Diagnosed_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            Diagnosed_LBL.Visible = false;
        }
        private void DATE_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            DATE_LBL.Visible = false;
        }
        private void MiddleName_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
            MiddleName_LBL.Visible = false;
        }
        private void Enter_BTN_Click(object sender, EventArgs e)
        {
            Hide();
            Click.Play();
            Scanner_Form QRScan = new Scanner_Form();
            QRScan.ShowDialog();
        }
        private void Generate_BTN_Click(object sender, EventArgs e)
        {
            if (LastName_BOX.Text == "" || FirstName_BOX.Text == "" || MiddleName_BOX.Text == "" || ExtName_BOX.Text == "" || HomeNumber_BOX.Text == "" || StreetName_BOX.Text == "" || Municipality_BOX.Text == "" || Contact_BOX.Text == "" || Gender_BOX.Text == ""
                || CivilStatus_BOX.Text == "" || Diagnosed_BOX.Text == "" || Class_BOX.Text == "" || DATE_BOX.Text == "")
            {
                MessageBox.Show("Please Complete the Form", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Click.Play();
                StreamWriter QRCODE = new StreamWriter(@"C:\Users\pc\Desktop\OOP\Contract Tracing File\QRCODE.txt", true);
                QRCODE.WriteLine(LastName_BOX.Text + ", " + FirstName_BOX.Text + ", " + MiddleName_BOX.Text + ", " + "Ext. Name " + ExtName_BOX.Text + " , "
                + HomeNumber_BOX.Text + ", " + StreetName_BOX.Text + ", " + Barangay_BOX.Text + ", " + Municipality_BOX.Text + ", " +
                ProvinceCity_BOX.Text + ", " + Contact_BOX.Text + ", " + Gender_BOX.Text + ", " + CivilStatus_BOX.Text + ", " + "Patient Diagnosed with Covid-19? " + Diagnosed_BOX.Text
                + ", " + "Classfinication ? " + Class_BOX.Text + ", " + DATE_BOX.Text);
                QRCODE.Close();
                MessageBox.Show("You can now submit your Form!", "Generated!");
            }
        }
        private void Class_BOX_Click(object sender, EventArgs e)
        {
            Click1.Play();
        }
    }
}

