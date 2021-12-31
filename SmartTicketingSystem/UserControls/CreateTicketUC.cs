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
    public partial class CreateTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Ticket> tickets;

        public CreateTicketUC()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            xmlSerializer = new XmlSerializer(typeof(List<Ticket>));
            /*
            comboTicketTime.DataSource = Enum.GetValues(typeof(Timings));
            comboTicketCategory.DataSource = Enum.GetValues(typeof(NumberOfPeople));
            */
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            // path of tickets xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";


            // if file exists loading tickets from xml file
            if (File.Exists(path))
            {
                FileStream existingTicketsFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();
            }

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new user object of User class
            Ticket ticket = new Ticket();

            ticket.id = Guid.NewGuid();
            ticket.ticketRate = Convert.ToInt32(txtRate.Text);
            /*
            ticket.timing = (Timings)Guid.Parse(typeof(Timings), comboTicketTime.Text);
            ticket.category = (NumberOfPeople)Guid.Parse(typeof(NumberOfPeople), comboTicketCategory.Text);
            */
            tickets.Add(ticket);
            MessageBox.Show("ADDED TICKET SUCCESSFULLY");

            // serializing tickets object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, tickets);
            fileStream.Close();
        }
    }
}
