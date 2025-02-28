using System.Drawing.Drawing2D;

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
        //private void LoginBtn_Paint(object sender, PaintEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddEllipse(0, 0, btn.Width, btn.Height);
        //    btn.Region = new Region(path);

        //}
        public async void ShowToast(string message)
        {
            lblToast.Text = message;
            lblToast.Visible = true;

            await Task.Delay(3000); // Wait for 3 seconds
            lblToast.Visible = false;
        }

        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            ShowToast("Saved Successfully!");


        }
      

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var c = LoginPassword.UseSystemPasswordChar;
            if (c == true)
                LoginPassword.UseSystemPasswordChar = false;
            else
                LoginPassword.UseSystemPasswordChar = true;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();

            signupPage.Show();
            this.Hide();

        }
    }
}
