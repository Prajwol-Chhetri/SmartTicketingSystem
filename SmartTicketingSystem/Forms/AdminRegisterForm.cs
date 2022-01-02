using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using SmartTicketingSystem.Classes;


namespace SmartTicketingSystem.Forms
{
    public partial class AdminRegisterForm : Form
    {
        XmlSerializer xmlSerializer;
        List<User> users;

        public AdminRegisterForm()
        {
            InitializeComponent();
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
        }


        private void label9_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            // regex to check for email valid
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex rg = new Regex(pattern);

            // path of users xml file
            String path = Path.Combine(Directory.GetCurrentDirectory(), "Users.xml");

            // if file exists loading users from xml file
            if (File.Exists(path))
            {
                FileStream existingUsersFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                users = (List<User>)xmlSerializer.Deserialize(existingUsersFS);
                existingUsersFS.Close();
            }

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new user object of User class
            User user = new User();


            if (users.Any(admin => admin.Role == RoleType.Admin))
            {
                // displaying error message if admin user is already registered
                MessageBox.Show("ONLY ONE ADMIN ALLOWED IN THE SYSTEM\nADMIN ALREADY REGISTERED");
            }
            else if (rg.IsMatch(txtAdminEmail.Text) == false)
            {
                // displaying error message if email is invalid
                MessageBox.Show("INVALID EMAIL");
            }
            else
            {
                // Saving admin user if everything is valid
                user.FirstName = txtAdminFirstName.Text;
                user.LastName = txtAdminLastName.Text;
                user.Email = txtAdminEmail.Text;
                user.Role = RoleType.Admin;
                user.Password = txtAdminPassword.Text;
                users.Add(user);
                MessageBox.Show("REGISTERED ADMIN USER SUCCESSFULLY");
            }
            
            // serializing register Users object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, users);
            fileStream.Close();
        }

        private void firstNameValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminFirstName.Text))
            {
                e.Cancel = true;
                txtAdminFirstName.Focus();
                errorProvider1.SetError(txtAdminFirstName, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAdminFirstName, "");
            }
        }

        private void lastNameValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminLastName.Text))
            {
                e.Cancel = true;
                txtAdminLastName.Focus();
                errorProvider1.SetError(txtAdminLastName, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAdminLastName, "");
            }
        }

        private void emailValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminEmail.Text))
            {
                e.Cancel = true;
                txtAdminEmail.Focus();
                errorProvider1.SetError(txtAdminEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAdminEmail, "");
            }
        }

        private void passwordValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                e.Cancel = true;
                txtAdminPassword.Focus();
                errorProvider1.SetError(txtAdminPassword, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAdminPassword, "");
            }
        }
    }
}
