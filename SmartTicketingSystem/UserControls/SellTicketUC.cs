﻿using System;
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
                FileStream existingTimingsFS = new FileStream(timingXMLPath, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlTimingSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();


                // loading data from categories xml file to display in combobox
                string categoryXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";
                FileStream existingCategoriesFS = new FileStream(categoryXMLPath, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlCategorySerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();
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

            // fetching time from selected ticket
            var selectedTicketTiming = timings.SingleOrDefault(x => x.id == selectedTicket.timing);

            // fetching category from selected ticket
            var selectedTicketCategory = categories.SingleOrDefault(y => y.id == selectedTicket.category);


            // assigning check in and check out time
            DateTime currentTime = DateTime.Now;
            DateTime checkOut = currentTime.AddHours(selectedTicketTiming.noOfHours);

            // start and end time of recreation center
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);

            if (checkOut.TimeOfDay > start && checkOut.TimeOfDay < end)
            {
                // creating new ticketSale object of Ticket Sale class
                TicketSale ticketSale = new TicketSale();
                ticketSale.id = Guid.NewGuid();
                ticketSale.ticket = selectedTicket.id;
                ticketSale.checkInTime = currentTime.ToString("h:mm:ss tt");
                ticketSale.checkOutTime = checkOut.ToString("h:mm:ss tt");
                ticketSale.soldDate = DateTime.Today;

                // adding ticket Sale obj to list of ticket sale object
                ticketSales.Add(ticketSale);
                MessageBox.Show("SOLD TICKET SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("CANNOT SELL THIS TICKET");
            }

            // serializing Ticket Sales object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, ticketSales);
            fileStream.Close();

            LoadData(ticketSales);
        }
    }
}