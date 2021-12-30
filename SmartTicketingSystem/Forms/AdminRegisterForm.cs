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
        List<Users> users;

        public AdminRegisterForm()
        {
            InitializeComponent();
            users = new List<Users>();
            xmlSerializer = new XmlSerializer(typeof(List<Users>));
        }


        private void label9_Click(object sender, EventArgs e)
        {
            using (LoginForm fd = new LoginForm())
            {
                fd.ShowDialog();
            }
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
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";

            // if file exists loading users from xml file
            if (File.Exists(path))
            {
                FileStream existingUsersFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                users = (List<Users>)xmlSerializer.Deserialize(existingUsersFS);
                existingUsersFS.Close();
            }

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new user object of User class
            Users user = new Users();


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
    }
}
