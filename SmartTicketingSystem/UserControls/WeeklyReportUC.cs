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
    public partial class WeeklyReportUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<TicketSale> ticketSales;

        public WeeklyReportUC()
        {
            InitializeComponent();
            ticketSales = new List<TicketSale>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketSale>));

            // loading data from ticket sales xml file
            string salesXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Sales.xml");
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

            // creating total customers and total earning as 0 in beginning
            int totalCustomer = 0;
            decimal totalEarning = 0;

            // creating a new datatable object to link to dataGrid
            DataTable dt = new DataTable();

            // getting start and end date of week based on user's input
            var selectedDate = dateTimePicker.Value;
            var weekStart = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);
            var weekEnd = weekStart.AddDays(7).AddSeconds(-1);

            // setting column headers
            dt.Columns.Add("Day");
            dt.Columns.Add("Total No Of Visitors");
            dt.Columns.Add("Total Earning");

            foreach (DateTime day in EachDay(weekStart, weekEnd))
            {
                // fetching total number of customer for the day
                int customers = totalPeople(day);
                // fetching total earning for the day
                decimal earnings = totalPrice(day);

                // adding row to datatable
                dt.Rows.Add(day.DayOfWeek.ToString(), customers, earnings);

                // adding no of people to total customer
                totalCustomer += customers;
                
                // adding total of sales to total earning
                totalEarning += earnings;
            }

            // adding datatble as datasource to the datagrid in the form
            weeklyReportDataGrid.DataSource = dt;

            // setting the value of textboxes containing total earning and total number of customer
            txtTotalCustomer.Text = Convert.ToString(totalCustomer);
            txtTotalEarning.Text = "Rs. " + Convert.ToString(totalEarning);
        }

        public decimal totalPrice(DateTime x)
        {
            // function to get total earning for particular date

            decimal totalEarning = 0;

            foreach (TicketSale each in ticketSales)
            {
                if (each.TicketDate.Date == x.Date)
                {
                    totalEarning += each.Total;
                }
            }

            return totalEarning;
        }

        public int totalPeople(DateTime x)
        {
            // function to get total people for particular date

            int totalPeople = 0;

            foreach (TicketSale each in ticketSales)
            {
                if (each.TicketDate.Date == x.Date)
                {
                    totalPeople += each.NoOfPeople;
                }
            }

            return totalPeople;
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            // custom method to iterate through days in a range of date
            for (var day = from.Date; day.Date < thru.Date; day = day.AddDays(1))
                yield return day;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // loading data into chart
            LoadReport(ticketSales);
        }
    }
}
