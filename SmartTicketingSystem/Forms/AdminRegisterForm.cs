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

            // creating object of User class
            FileStream fileStream = new FileStream("D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml", FileMode.Create, FileAccess.Write);
            Users user = new Users();

            if (rg.IsMatch(txtAdminEmail.Text))
            {
                // if email is valid
                user.FirstName = txtAdminFirstName.Text;
                user.LastName = txtAdminLastName.Text;
                user.Email = txtAdminEmail.Text;
                user.Role = RoleType.Admin;
                user.Password = txtAdminPassword.Text;

                // saving User
                users.Add(user);

                // serializing register Users object to XMl file
                xmlSerializer.Serialize(fileStream, users);

                fileStream.Close();

                MessageBox.Show("REGISTERED ADMIN USER SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("INVALID EMAIL");
                fileStream.Close();
            }

        }
    }
}
