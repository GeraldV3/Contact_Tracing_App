using Contact_Tracing_App.Properties;
namespace Contact_Tracing_App
{
    public partial class Resgistration : Form
    {
        public Resgistration()
        {
            InitializeComponent();
        }
        private void Resgister_BTN_Click_1(object sender, EventArgs e)
        {
            Hide();
            Questions Main = new Questions();
            Main.ShowDialog();
        }
    }
}