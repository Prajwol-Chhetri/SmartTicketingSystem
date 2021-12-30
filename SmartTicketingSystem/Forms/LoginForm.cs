using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTicketingSystem.Forms;
using System.Xml.Serialization;
using System.IO;
using SmartTicketingSystem.Classes;


namespace SmartTicketingSystem
{
    public partial class LoginForm : Form
    {
        XmlSerializer xmlSerializer;
        List<Users> users;

        public LoginForm()
        {
            InitializeComponent();
            users = new List<Users>();
            xmlSerializer = new XmlSerializer(typeof(List<Users>));
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // path to xml file for user authentication
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";

            // creating objects of AdminDashboardForm and StaffDashboard form to display when authorized
            var adminDashboard = new AdminDashboardForm();
            var staffDashboard = new StaffDashboardForm();

            // checking if xml file exists for authentication
            if (File.Exists(path))
            {
                // deserializing xml file and fetching all user details for authentication
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                users = (List<Users>)xmlSerializer.Deserialize(fileStream);

                // checking if the entered email and password is saved and matches for the user
                foreach (var user in users)
                {
                    if (user.Email == txtUsername.Text && user.Password == txtPassword.Text)
                    {
                        // displaying dashboard based on role if user is authorized
                        if (user.Role == RoleType.Admin)
                        {
                            adminDashboard.ShowDialog();
                            break;
                        }
                        else
                        {
                            staffDashboard.ShowDialog();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("INVALID CREDENTIALS");
                    }
                }

            }
            else
            {
                MessageBox.Show("PLEASE REGISTER FIRST");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var adminRegisterForm = new AdminRegisterForm();
            adminRegisterForm.ShowDialog();
        }
    }
}
