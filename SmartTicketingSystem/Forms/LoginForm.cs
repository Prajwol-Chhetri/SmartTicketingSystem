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
        List<User> users;

        public LoginForm()
        {
            InitializeComponent();
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // path to xml file for user authentication
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";


            // checking if xml file exists for authentication
            if (File.Exists(path))
            {
                // deserializing xml file and fetching all user details for authentication
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                users = (List<User>)xmlSerializer.Deserialize(fileStream);

                // setting authenticated to false by default
                bool authenticated = false;

                // checking if the entered email and password is saved and matches for the user
                foreach (var user in users)
                {
                    if (user.Email == txtUsername.Text && user.Password == txtPassword.Text)
                    {
                        // displaying dashboard based on role if user is authorized
                        if (user.Role == RoleType.Admin)
                        {
                            // closing xml file and setting authenticated as true
                            fileStream.Close();
                            authenticated = true;

                            // displaying admin dashboard and exiting loop
                            var adminDashboard = new AdminDashboardForm(user.FirstName + " " + user.LastName);
                            adminDashboard.ShowDialog();
                            break;
                        }
                        else
                        {
                            // closing xml file and setting authenticated as true
                            fileStream.Close();
                            authenticated = true;

                            // displaying staff dashboard and exiting loop
                            var staffDashboard = new StaffDashboardForm(user.FirstName + " " + user.LastName);
                            staffDashboard.ShowDialog();
                            break;
                        }
                    }
                }

                // displaying error if credentials is not correct
                if (authenticated ==  false)
                {
                    MessageBox.Show("INVALID CREDENTIALS");
                    fileStream.Close();
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
