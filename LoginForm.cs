using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppV2
{
    public partial class frmLogin : Form
    {
        String accessToken = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        //-------------------------------------
        // User Sign Up
        //-------------------------------------

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get Details
           String access;
            if (rbnAdmin.Checked)
            {
                access = "Admin";
            }
            else
            {
                access = "General";
            }
            //Define the user model
            UserModel user = new UserModel {
                email = txtSignUpEmail.Text,
                password = txtSignupPassword.Text,
                permissions = access,
                favCity = cmbCity.Text
            };
            //Function Which adds the user model to database
            WeatherDbDataAccess.CreateUser(user);

            MessageBox.Show("User Successfully created", "User Created",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        //-------------------------------------
        // User Login
        //-------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtLoginEmail.Text;
            String password = txtLoginPassword.Text;
            UserModel user = new UserModel
            {
                email = txtLoginEmail.Text,
                password = txtLoginPassword.Text
            };

            List<UserModel> AuthorizedUsers = WeatherDbDataAccess.GetUser(user);
            Console.WriteLine("Auth Users: ", AuthorizedUsers.Count);
            if (AuthorizedUsers.Count == 1)
            {
                accessToken = AuthorizedUsers.ElementAt(0).permissions;
                MessageBox.Show("Login Successful");
                this.Hide();
                frmMain main = new frmMain(accessToken);
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        public Boolean userExists(String email, String password)
        {
            String[] users = System.IO.File.ReadAllLines("../data/users.txt");
            foreach (string user in users)
            {
                String[] credentials = user.Split(',');
                if (email == credentials[0] && password == credentials[1])
                {
                    accessToken = credentials[2];
                    return true;
                }
            }

            return false;
        }

        private void txtLoginEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtLoginEmail.Text == null || !txtLoginEmail.Text.Contains('@'))
            {
                EmailError.SetError(txtLoginEmail, "Invalid Email Address");
            }
            else
            {
                EmailError.Clear();
            }
        }
        private void txtSignUpEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtSignUpEmail.Text == null || !txtSignUpEmail.Text.Contains('@'))
            {
                EmailError.SetError(txtSignUpEmail, "Invalid Email Address");
            }
            else
            {
                EmailError.Clear();
            }

        }

        private void txtSignupPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtSignUpEmail.Text == null || txtSignupPassword.Text.Contains(','))
            {
                PasswordError.SetError(txtSignupPassword, "Invalid Password");
            }
            else
            {
                PasswordError.Clear();
            }
        }

        private void txtLoginPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtLoginPassword.Text == null || txtLoginPassword.Text.Contains(','))
            {
                PasswordError.SetError(txtLoginPassword, "Invalid Password");
            }
            else
            {
                PasswordError.Clear();
            }
        }
    }
}
