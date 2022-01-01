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
    public partial class SellTicket : UserControl
    {
        XmlSerializer xmlSerializer;
        XmlSerializer xmlTicketSerializer;
        XmlSerializer xmlTimingSerializer;
        XmlSerializer xmlCategorySerializer;
        List<TicketSale> ticketSales;
        List<Ticket> tickets;
        List<Timing> timings;
        List<Category> categories;

        public SellTicket()
        {
            InitializeComponent();
            ticketSales = new List<TicketSale>();
            tickets = new List<Ticket>();
            timings = new List<Timing>();
            categories = new List<Category>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketSale>));
            xmlTicketSerializer = new XmlSerializer(typeof(List<Ticket>));
            xmlTimingSerializer = new XmlSerializer(typeof(List<Timing>));
            xmlCategorySerializer = new XmlSerializer(typeof(List<Category>));

            // loading data from tickets xml file to display in combobox
            string ticketsXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Tickets.xml";
            if (File.Exists(ticketsXMLPath))
            {
                FileStream existingTicketsFS = new FileStream(ticketsXMLPath, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlTicketSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();

                // loading data into timing combobox by binding tickets list as datasource
                comboTicket.DataSource = tickets;
                comboTicket.DisplayMember = "ticketName";

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
            }
            else
            {
                MessageBox.Show("NO TICKETS PLEASE CREATE A TICKET FIRST");
            }

            string salesXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Sales.xml";

            if (File.Exists(salesXMLPath))
            {
                FileStream existingTicketSalesFS = new FileStream(salesXMLPath, FileMode.Open, FileAccess.Read);
                ticketSales = (List<TicketSale>)xmlSerializer.Deserialize(existingTicketSalesFS);
                existingTicketSalesFS.Close();
            }

            LoadData(ticketSales);
        }

        public void LoadData(List<TicketSale> x)
        {
            sellDataView.DataSource = null;
            sellDataView.DataSource = x;
        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            string salesXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Sales.xml";

            // overwriting existing xml file
            FileStream fileStream = new FileStream(salesXMLPath, FileMode.Create, FileAccess.Write);

            // typecasting selected item to Ticket to fetch selected ticket
            var selectedTicket = (Ticket)comboTicket.SelectedItem;

            // fetching selected time from ticket
            var selectedTicketTiming = timings.SingleOrDefault(x => x.id == selectedTicket.timing);

            // fetching selected category from ticket
            var selectedTicketCategory = categories.SingleOrDefault(y => y.id == selectedTicket.category);

            // creating new ticketSale object of Ticket Sale class
            TicketSale ticketSale = new TicketSale();
            ticketSale.id = Guid.NewGuid();
            ticketSale.ticket = selectedTicket.id;

            // assigning check in and check out time
            DateTime currentTime = DateTime.Now;
            DateTime checkOut = currentTime.AddHours(selectedTicketTiming.noOfHours);
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);

            ticketSale.checkInTime = currentTime.ToString("h:mm:ss tt");
            ticketSale.checkOutTime = checkOut.ToString("h:mm:ss tt");
            ticketSale.soldDate = DateTime.Today;


            if (checkOut.TimeOfDay >  start && checkOut.TimeOfDay < end)
            {
                // adding ticket Sale obj to list of ticket sale object
                ticketSales.Add(ticketSale);
                MessageBox.Show("SOLD TICKET SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("PARK CLOSED");
            }


            // serializing Ticket Sales object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, ticketSales);
            fileStream.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckInTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCheckOutTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
