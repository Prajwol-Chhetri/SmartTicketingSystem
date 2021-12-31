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
    public partial class DeRegistration : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Users> users;

        public DeRegistration()
        {
            InitializeComponent();
            users = new List<Users>();
            xmlSerializer = new XmlSerializer(typeof(List<Users>));
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            // path of users xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Users.xml";

            // loading users from xml file
            FileStream existingUsersFS = new FileStream(path, FileMode.Open, FileAccess.Read);
            users = (List<Users>)xmlSerializer.Deserialize(existingUsersFS);
            existingUsersFS.Close();

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // fetching staff from list of users
            var staff = users.SingleOrDefault(x => x.Email == txtStaffEmail.Text);
            if (staff != null)
            {
                // removing staff if staff is found
                users.Remove(staff);
                MessageBox.Show("REMOVED STAFF SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("STAFF WITH EMAIL DOES NOT EXIST");
            }

            // serializing Users object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, users);
            fileStream.Close();

        }
    }
}
