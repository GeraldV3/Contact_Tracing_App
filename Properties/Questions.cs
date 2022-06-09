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
            File.WriteLine("Street Name : " + StreetName_BOX.Text);
            File.WriteLine("Municipality : " + Municipality_BOX.Text);
            File.WriteLine("Contact : " + Contact_BOX.Text);
            File.WriteLine("Gender : " + Gender_BOX.Text);
            File.WriteLine("Birthday : " + Birthday_BOX.Text);
            File.Close();

            Hide();
            Continuation Next = new Continuation();
            Next.ShowDialog();
            Show();
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
        private void Birthday_BOX_Enter(object sender, EventArgs e)
        {
            if (Birthday_BOX.Text == "mm/dd/yyyy")
                Birthday_BOX.Text = "";
                Birthday_BOX.ForeColor = Color.Black;
        }
        private void Birthday_BOX_Leave(object sender, EventArgs e)
        {
            if (Birthday_BOX.Text == "")
                Birthday_BOX.Text = "mm/dd/yyyy";
                Birthday_BOX.ForeColor = Color.Gray;
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
    }
}

