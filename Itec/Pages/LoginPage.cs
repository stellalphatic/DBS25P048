namespace Itec
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var c = LoginPassword.UseSystemPasswordChar;
            if (c==true)
                LoginPassword.UseSystemPasswordChar = false;
            else
                LoginPassword.UseSystemPasswordChar = true;
        }
    }
}
