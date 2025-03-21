using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itec.Encryption;
using Itec.DL;
using Itec.BL;
using Itec.DB;
namespace Itec
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }


        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {

            string username = Usernametxt.Text;
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;
            string confirmPassword = ConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (UserDL.UserExists(username, email))
            {
                MessageBox.Show("Username or email already exists!");
                return;
            }

            try
            {
                string hashedPassword = PasswordHelper.HashPassword(password);
                var newUser = new User
                {
                    Username = username,
                    Email = email,
                    PasswordHash = hashedPassword,
                    RoleId = null // role_id = NULL for new users
                };

                UserDL.Signup(newUser);
                MessageBox.Show("Signup successful! Please wait for admin approval.");
                LoginPage loginForm = new LoginPage();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during signup: {ex.Message}");
            }
        }
    }
}
