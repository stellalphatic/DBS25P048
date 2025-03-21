using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Itec.DL;
using Itec.BL;
namespace Itec
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text;
            string password = Passwordtxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required!");
                return;
            }

            try
            {
                User user = UserDL.Login(username, password);
                if (user != null)
                {
                    MessageBox.Show("Login successful!");

                    Dashboard adminForm = new Dashboard();
                    adminForm.Show();


                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or account not approved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error login: {ex.Message}");
            }
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            var c = Passwordtxt.UseSystemPasswordChar;
            if (c == true)
                Passwordtxt.UseSystemPasswordChar = false;
            else
                Passwordtxt.UseSystemPasswordChar = true;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();

            signupPage.Show();
            this.Hide();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

      
    }
}
