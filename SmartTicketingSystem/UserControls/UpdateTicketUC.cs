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
    public partial class UpdateTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        XmlSerializer xmlTimingSerializer;
        XmlSerializer xmlCategorySerializer;
        List<Ticket> tickets;
        List<Timing> timings;
        List<Category> categories;

        public UpdateTicketUC()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            timings = new List<Timing>();
            categories = new List<Category>();
            xmlSerializer = new XmlSerializer(typeof(List<Ticket>));
            xmlTimingSerializer = new XmlSerializer(typeof(List<Timing>));
            xmlCategorySerializer = new XmlSerializer(typeof(List<Category>));

            // loading data from timings xml file to display in combobox
            string timingXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Timings.xml";
            if (File.Exists(timingXMLPath))
            {
                FileStream existingTimingsFS = new FileStream(timingXMLPath, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlTimingSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();
            }


            // loading data from categories xml file to display in combobox
            string categoryXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";
            if (File.Exists(categoryXMLPath))
            {
                FileStream existingCategoriesFS = new FileStream(categoryXMLPath, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlCategorySerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();
            }

            // loading data from tickets xml file to display in combobox
            string ticketsXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";
            if (File.Exists(ticketsXMLPath))
            {
                FileStream existingTicketsFS = new FileStream(ticketsXMLPath, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();

                // loading data into timing combobox by binding tickets list as datasource
                comboTicketName.DataSource = tickets;
                comboTicketName.DisplayMember = "ticketName";
            }
            else
            {
                MessageBox.Show("NO TICKETS PLEASE CREATE A TICKET FIRST");
            }
        }

        private void comboTicketName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting details of currently selected ticket
            var selectedTicket = (Ticket)comboTicketName.SelectedItem;
            var selectedTicketTiming = timings.SingleOrDefault(x => x.ID == selectedTicket.TicketTiming.ID);
            var selectedTicketCategory = categories.SingleOrDefault(y => y.ID == selectedTicket.TicketCategory.ID);

            // loading data into timing combobox by binding timings list as datasource
            comboTicketTime.DataSource = timings;
            comboTicketTime.DisplayMember = "timingName";

            // loading data into categories comboboxby binding categories list as datasource
            comboTicketCategory.DataSource = categories;
            comboTicketCategory.DisplayMember = "categoryName";

            // setting the details of currently selected ticket in the update fields
            txtTicketName.Text = selectedTicket.TicketName;
            comboTicketTime.SelectedIndex = comboTicketTime.FindStringExact(selectedTicketTiming.TimingName);
            comboTicketCategory.SelectedIndex = comboTicketCategory.FindStringExact(selectedTicketCategory.CategoryName);
            txtRate.Text = Convert.ToString(selectedTicket.TicketRate);
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (tickets.Count > 0)
            {
                string path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // getting details of currently selected ticket
                var selectedTicket = (Ticket)comboTicketName.SelectedItem;
                
                // finding ticket in tickets list
                var ticketToUpdate = tickets.Find(x => x.ID == selectedTicket.ID);


                // updating ticket from new data
                ticketToUpdate.TicketRate = Convert.ToDecimal(txtRate.Text);      
                var selectedTiming = (Timing)comboTicketTime.SelectedItem; // typecasting selected item to Timing to fetch id
                ticketToUpdate.TicketTiming = selectedTiming;
                var selectedCategory = (Category)comboTicketCategory.SelectedItem; // typecasting selected item to Category to fetch id
                ticketToUpdate.TicketCategory = selectedCategory;
                ticketToUpdate.TicketName = txtTicketName.Text;

                // serializing tickets object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, tickets);
                fileStream.Close();

                MessageBox.Show("UPDATED TICKET SUCCESSFULLY");
            }
        }
    }
}
