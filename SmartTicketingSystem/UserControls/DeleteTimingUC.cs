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
    public partial class DeleteTimingUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Timing> timings;

        public DeleteTimingUC()
        {
            InitializeComponent();
            timings = new List<Timing>();
            xmlSerializer = new XmlSerializer(typeof(List<Timing>));

            // loading data from timings xml file to display in combobox
            string timingXMLPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Timings.xml";
            if (File.Exists(timingXMLPath))
            {
                FileStream existingTimingsFS = new FileStream(timingXMLPath, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();

                // loading data into timing combobox by binding timings list as datasource
                comboTimingName.DataSource = timings;
                comboTimingName.DisplayMember = "TimingName";

                // loading data into data grid view
                LoadData(timings);
            }
            else
            {
                MessageBox.Show("NO TIMINGS PLEASE CREATE A TIMING FIRST");
            }
        }

        public void LoadData(List<Timing> x)
        {
            timingDataView.DataSource = null;
            timingDataView.DataSource = x;
        }

        private void btnDeleteTiming_Click(object sender, EventArgs e)
        {
            if (timings.Count > 0)
            {
                string path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Timings.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // getting details of currently selected ticket
                var selectedTiming = (Timing)comboTimingName.SelectedItem;

                // fetching timing from list of timings
                var timing = timings.SingleOrDefault(x => x.ID == selectedTiming.ID);
                if (timing != null)
                {
                    // removing timing if timing is found
                    timings.Remove(timing);
                    MessageBox.Show("REMOVED TIMING SUCCESSFULLY");
                }

                // serializing Timings object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, timings);
                fileStream.Close();

                // loading updated data into data grid view
                LoadData(timings);
            }
        }
    }
}
