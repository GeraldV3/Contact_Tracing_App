using Contact_Tracing_App.Properties;
using System.Media;
namespace Contact_Tracing_App
{
    public partial class Resgistration : Form
    {
        SoundPlayer Click = new SoundPlayer(@"C:\Users\pc\Desktop\OOP\Contact Tracing App\Picture and Sounds\Click.wav");
        public Resgistration()
        {
            InitializeComponent();
        }
        private void Resgister_BTN_Click_1(object sender, EventArgs e)
        {
            Click.Play();
            Hide();
            Questions Main = new Questions();
            Main.ShowDialog();
        }
        private void Username_TxtBOX_Enter(object sender, EventArgs e)
        {
            if (Username_TxtBOX.Text == "Username")
                Username_TxtBOX.Text = "";
                Username_TxtBOX.ForeColor = Color.Black;

        }
        private void Username_TxtBOX_Leave(object sender, EventArgs e)
        {
            if (Username_TxtBOX.Text == "")
                Username_TxtBOX.Text = "Username";
                Username_TxtBOX.ForeColor = Color.Gray;

        }
        private void Password_TxtBOX_Enter(object sender, EventArgs e)
        {
            if (Password_TxtBOX.Text == "Password")
                Password_TxtBOX.Text = "";
                Password_TxtBOX.ForeColor = Color.Black;
        }
        private void Password_TxtBOX_Leave(object sender, EventArgs e)
        {
            if (Password_TxtBOX.Text == "")
                Password_TxtBOX.Text = "Password";
                Password_TxtBOX.ForeColor = Color.Gray;
        }
        private void AccesstoMain_BTN_Click(object sender, EventArgs e)
        {
            Click.Play();
            string username, password;
            username = Username_TxtBOX.Text;
            password = Password_TxtBOX.Text;
            if (username == "Gerald" && password == "Lopez")
            {
                MessageBox.Show("Succesfully Log in as ADMIN");
                Hide();
                ADMIN ADMIN2 = new ADMIN();
                ADMIN2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try Again!"); 
            }
        }
    }
}