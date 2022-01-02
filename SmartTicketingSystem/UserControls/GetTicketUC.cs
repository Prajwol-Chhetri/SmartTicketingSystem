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
    public partial class GetTicketUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<TicketSale> ticketSales;

        public GetTicketUC()
        {
            InitializeComponent();
            ticketSales = new List<TicketSale>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketSale>));
        }

        private void btnGetTicket_Click(object sender, EventArgs e)
        {
            // loading data from sales xml
            string salesXMLPath = Path.Combine(Directory.GetCurrentDirectory(), "Sales.xml");

            if (File.Exists(salesXMLPath))
            {
                FileStream existingTicketSalesFS = new FileStream(salesXMLPath, FileMode.Open, FileAccess.Read);
                ticketSales = (List<TicketSale>)xmlSerializer.Deserialize(existingTicketSalesFS);
                existingTicketSalesFS.Close();

                // finding sold ticket in tickets list
                var soldTicket = ticketSales.Find(x => Convert.ToString(x.ID) == txtID.Text);

                if (soldTicket != null)
                {
                    ticketSales = new List<TicketSale>();
                    // creating an empty list and adding only found ticket
                    ticketSales.Add(soldTicket);
                    sellDataView.DataSource = ticketSales;
                }
                else
                {
                    MessageBox.Show("TICKET NOT FOUND");
                }
            }
            else
            {
                MessageBox.Show("NO SOLD TICKETS PLEASE SELL A TICKET FIRST");
            }
        }
    }
}
