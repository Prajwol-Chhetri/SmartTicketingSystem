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
using System.Globalization;


namespace SmartTicketingSystem.UserControls
{
    public partial class SellTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        XmlSerializer xmlTicketSerializer;
        XmlSerializer xmlTimingSerializer;
        XmlSerializer xmlCategorySerializer;
        List<TicketSale> ticketSales;
        List<Ticket> tickets;
        List<Timing> timings;
        List<Category> categories;

        public SellTicketUC()
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
            string ticketsXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Tickets.xml");
            if (File.Exists(ticketsXMLPath))
            {
                FileStream existingTicketsFS = new FileStream(ticketsXMLPath, FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)xmlTicketSerializer.Deserialize(existingTicketsFS);
                existingTicketsFS.Close();

                // loading data into timing combobox by binding tickets list as datasource
                comboTicket.DataSource = tickets;
                comboTicket.DisplayMember = "ticketName";

                // loading data from timings xml file to display in combobox
                string timingXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Timings.xml");
                FileStream existingTimingsFS = new FileStream(timingXMLPath, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlTimingSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();


                // loading data from categories xml file to display in combobox
                string categoryXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Categories.xml");
                FileStream existingCategoriesFS = new FileStream(categoryXMLPath, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlCategorySerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();
            }
            else
            {
                MessageBox.Show("NO TICKETS PLEASE CREATE A TICKET FIRST");
            }

            string salesXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Sales.xml");

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
            string salesXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Sales.xml");

            // overwriting existing xml file
            FileStream fileStream = new FileStream(salesXMLPath, FileMode.Create, FileAccess.Write);

            // typecasting selected item to Ticket to fetch selected ticket
            var selectedTicket = (Ticket)comboTicket.SelectedItem;

            // fetching time from selected ticket
            var selectedTicketTiming = timings.SingleOrDefault(x => x.ID == selectedTicket.TicketTiming.ID);

            // fetching category from selected ticket
            var selectedTicketCategory = categories.SingleOrDefault(y => y.ID == selectedTicket.TicketCategory.ID);


            try
            {
                // assigning check in and check out time
                DateTime currentTime = DateTime.Now;
                DateTime checkInTime = DateTime.ParseExact(txtEntryTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime checkOutTime = checkInTime.AddHours(selectedTicketTiming.NoOfHours);

                // start and end time of recreation center
                TimeSpan start = new TimeSpan(10, 0, 0);
                TimeSpan end = new TimeSpan(18, 0, 0);

                if (checkInTime.TimeOfDay >= start && checkOutTime.TimeOfDay <= end)
                {
                    // creating new ticketSale object of Ticket Sale class
                    TicketSale ticketSale = new TicketSale();
                    ticketSale.ID = Guid.NewGuid();
                    ticketSale.CustomerName = txtCustomerName.Text;
                    ticketSale.CustomerContact = txtCustomerPhone.Text;
                    ticketSale.Ticket = selectedTicket;
                    ticketSale.EntryTime = checkInTime.ToString("h:mm:ss tt");
                    ticketSale.ExitTime = checkOutTime.ToString("h:mm:ss tt");
                    ticketSale.TicketDate = ticketDatePicker.Value.Date;
                    ticketSale.Total = Convert.ToDecimal(txtTicketPrice.Text);

                    // adding ticket Sale obj to list of ticket sale object
                    ticketSales.Add(ticketSale);
                    MessageBox.Show("SOLD TICKET SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT A VALID TICKET THAT SATISFIES THE ENTRY AND EXIT TIME");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE ENTER VALID TIME");
            }

            // serializing Ticket Sales object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, ticketSales);
            fileStream.Close();

            LoadData(ticketSales);
        }

        // creating a function to update ticket price
        public void UpdatePrice(ComboBox x, TextBox y, DateTimePicker z)
        {
            // getting details of currently selected ticket
            var selectedTicket = (Ticket)x.SelectedItem;

            // increasing price of ticket in weeknds
            if (z.Value.DayOfWeek == DayOfWeek.Saturday || z.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                y.Text = Convert.ToString(selectedTicket.TicketRate + 50);
            }
            else
            {
                y.Text = Convert.ToString(selectedTicket.TicketRate);
            }
        }

        private void comboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice(comboTicket, txtTicketPrice, ticketDatePicker);
        }

        private void ticketDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice(comboTicket, txtTicketPrice, ticketDatePicker);
        }
    }
}
