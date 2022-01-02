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
using SmartTicketingSystem.Classes;

namespace SmartTicketingSystem.UserControls
{
    public partial class DeleteTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Ticket> tickets;

        public DeleteTicketUC()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            xmlSerializer = new XmlSerializer(typeof(List<Ticket>));

            // loading data from tickets xml file to display in combobox
            string ticketsXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";
            if (File.Exists(ticketsXMLPath))
            {
                FileStream existingTicketsFS = new FileStream(ticketsXMLPath, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();

                // loading data into data grid view
                LoadData(tickets);
                
                // loading data into timing combobox by binding tickets list as datasource
                comboTicketName.DataSource = tickets;
                comboTicketName.DisplayMember = "ticketName";
            }
            else
            {
                MessageBox.Show("NO TICKETS PLEASE CREATE A TICKET FIRST");
            }
        }

        public void LoadData(List<Ticket> x)
        {
            ticketDataView.DataSource = null;
            ticketDataView.DataSource = x;
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (tickets.Count() > 0)
            {
                string path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // typecasting selected item to Ticket to fetch id of user selected ticket
                var selectedTicket = (Ticket)comboTicketName.SelectedItem;

                // fetching ticket from list of tickets
                var ticket = tickets.SingleOrDefault(x => x.ID == selectedTicket.ID);
                if (ticket != null)
                {
                    // removing ticket if ticket is found
                    tickets.Remove(ticket);
                    MessageBox.Show("REMOVED TICKET SUCCESSFULLY");
                }

                // serializing Tickets object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, tickets);
                fileStream.Close();

                // loading updated data into data grid view
                LoadData(tickets);
            }
        }
    }
}
