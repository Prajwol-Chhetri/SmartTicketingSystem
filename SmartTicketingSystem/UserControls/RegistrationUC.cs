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


namespace SmartTicketingSystem.UserControls
{
    public partial class RegistrationUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<User> users;

        public RegistrationUC()
        {
            InitializeComponent();
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));

            // path of users xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";

            // loading users from existing XML file
            FileStream existingUsersFS = new FileStream(path, FileMode.Open, FileAccess.Read);
            users = (List<User>)xmlSerializer.Deserialize(existingUsersFS);
            existingUsersFS.Close();

            // loading users into data grid
            LoadData(users);
        }

        public void LoadData(List<User> x)
        {
            categoryDataView.DataSource = null;
            categoryDataView.DataSource = x;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            // regex to check for email valid
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex rg = new Regex(pattern);

            // path of users xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new user object of User class
            User user = new User();


            if (users.Any(staff => staff.Email == txtStaffEmail.Text))
            {
                // displaying error if staff with email is already registered
                MessageBox.Show("STAFF WITH THIS EMAIL ALREADY REGISTERED");
            }
            else if (rg.IsMatch(txtStaffEmail.Text) == false)
            {
                // displaying error message if email is invalid
                MessageBox.Show("INVALID EMAIL");
            }
            else
            {
                // Saving staff user if everything is valid
                user.FirstName = txtStaffFirstName.Text;
                user.LastName = txtStaffLastName.Text;
                user.Email = txtStaffEmail.Text;
                user.Role = RoleType.Staff;
                user.Password = txtStaffPassword.Text;
                users.Add(user);
                MessageBox.Show("REGISTERED STAFF SUCCESSFULLY");
            }

            // serializing register Users object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, users);
            fileStream.Close();

            // loading users into data grid
            LoadData(users);
        }
    }
}
