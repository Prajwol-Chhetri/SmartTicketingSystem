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
    public partial class UpdateTimingUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Timing> timings;

        public UpdateTimingUC()
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
            }
            else
            {
                MessageBox.Show("NO TIMINGS PLEASE CREATE A TIMING FIRST");
            }
        }

        private void btnUpdateTiming_Click(object sender, EventArgs e)
        {
            if (timings.Count > 0)
            {
                string path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Timings.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // getting details of currently selected ticket
                var selectedTiming= (Timing)comboTimingName.SelectedItem;

                // finding timing in timings list
                var timingToUpdate = timings.Find(x => x.ID == selectedTiming.ID);


                // updating timing from new data
                timingToUpdate.TimingName = txtTimingName.Text;
                timingToUpdate.NoOfHours = Convert.ToInt32(txtNoOfHours.Text);

                // serializing timings object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, timings);
                fileStream.Close();

                MessageBox.Show("UPDATED TIMING SUCCESSFULLY");
            }
        }

        private void comboTimingName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting details of currently selected timing
            var selectedTiming = (Timing)comboTimingName.SelectedItem;

            // setting the details of currently selected ticket in the update fields
            txtTimingName.Text = selectedTiming.TimingName;
            txtNoOfHours.Text = Convert.ToString(selectedTiming.NoOfHours);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTimingName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoOfHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
