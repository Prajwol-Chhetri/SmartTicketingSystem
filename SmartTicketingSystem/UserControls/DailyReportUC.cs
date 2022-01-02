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
    public partial class DailyReportUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<TicketSale> ticketSales;

        public DailyReportUC()
        {
            InitializeComponent();
            ticketSales = new List<TicketSale>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketSale>));

            // loading data from ticket sales xml file
            string salesXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Sales.xml"); ;
            if (File.Exists(salesXMLPath))
            {
                FileStream existingTicketSalesFS = new FileStream(salesXMLPath, FileMode.Open, FileAccess.Read);
                ticketSales = (List<TicketSale>)xmlSerializer.Deserialize(existingTicketSalesFS);
                existingTicketSalesFS.Close();
            }

            // loading data into chart
            LoadReport(ticketSales);

        }

        public void LoadReport(List<TicketSale> x)
        {
            // function to show report by loading data

            // creating a new datatable object to link to dataGrid
            DataTable dt = new DataTable();

            // creating a dictionary to store name of group of total no of visitor in it
            Dictionary<string, int> groupSalesData = new Dictionary<string, int>();

            // creating total customers and total earning as 0 in beginning
            int totalCustomer = 0;
            decimal totalEarning = 0;

            // looping through list of sales
            foreach (TicketSale ticketSale in x)
            {
                // if each sold ticket matches the user input date adding it to dictionary
                if (ticketSale.TicketDate.Date == dateTimePicker.Value.Date)
                {
                    // adding no of people to total customer
                    totalCustomer += ticketSale.NoOfPeople;
                    // adding total of sales to total earning
                    totalEarning += ticketSale.Total;
                    // if group exists in dictionary adding no of people to the group else adding group to dictionary
                    if (groupSalesData.ContainsKey(ticketSale.Ticket.Category))
                    {
                        groupSalesData[ticketSale.Ticket.Category] += ticketSale.NoOfPeople;
                    }
                    else
                    {
                        groupSalesData.Add(ticketSale.Ticket.Category, ticketSale.NoOfPeople);
                    }
                }
            }

            // setting column headers
            dt.Columns.Add("Group");
            dt.Columns.Add("Total No Of Visitors");

            // setting row headers from key value pairs of dictionary
            foreach (KeyValuePair<string, int> entry in groupSalesData)
            {
                dt.Rows.Add(entry.Key, entry.Value);
            }

            // setting the value of textboxes containing total earning and total number of customer
            txtTotalCustomer.Text = Convert.ToString(totalCustomer);
            txtTotalEarning.Text = "Rs. " + Convert.ToString(totalEarning);

            // adding datatble as datasource to the datagrid in the form
            dailyReportDataGrid.DataSource = dt;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // updaing chart if user selects different date
            LoadReport(ticketSales);
        }
    }
}
