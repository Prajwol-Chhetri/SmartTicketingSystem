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
    public partial class CreateTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        XmlSerializer xmlTimingSerializer;
        XmlSerializer xmlCategorySerializer;
        List<Ticket> tickets;
        List<Timing> timings;
        List<Category> categories;

        public CreateTicketUC()
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

                // loading data into timing combobox by binding timings list as datasource
                comboTicketTime.DataSource = timings;
                comboTicketTime.DisplayMember = "timingName";
            }
            else
            {
                MessageBox.Show("NO TIMINGS PLEASE CREATE A TIMINGS FIRST");
            }


            // loading data from categories xml file to display in combobox
            string categoryXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";
            if (File.Exists(categoryXMLPath))
            {
                FileStream existingCategoriesFS = new FileStream(categoryXMLPath, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlCategorySerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();

                // loading data into categories comboboxby binding categories list as datasource
                comboTicketCategory.DataSource = categories;
                comboTicketCategory.DisplayMember = "categoryName";
            }
            else
            {
                MessageBox.Show("NO CATEGORIES PLEASE CREATE A CATEGORY FIRST");
            }

            // path of tickets xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";
            // if file exists loading tickets from xml file
            if (File.Exists(path))
            {
                FileStream existingTicketsFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();
            }

            // loading data into data grid view
            LoadData(tickets);
        }

        public void LoadData(List<Ticket> x)
        {
            ticketDataView.DataSource = null;
            ticketDataView.DataSource = x;
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            // path of tickets xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new user object of User class
            Ticket ticket = new Ticket();

            ticket.ID = Guid.NewGuid();
            ticket.TicketRate = Convert.ToDecimal(txtRate.Text);

            // typecasting selected item to Timing to fetch id
            var selectedTiming = (Timing)comboTicketTime.SelectedItem;
            ticket.TicketTiming = selectedTiming;

            // typecasting selected item to Category to fetch id
            var selectedCategory = (Category)comboTicketCategory.SelectedItem;
            ticket.TicketCategory = selectedCategory;

            ticket.TicketName = txtTicketName.Text;

            tickets.Add(ticket);
            MessageBox.Show("ADDED TICKET SUCCESSFULLY");

            // serializing tickets object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, tickets);
            fileStream.Close();

            // loading data into data grid view
            LoadData(tickets);
        }
    }
}
