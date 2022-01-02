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
    public partial class CreateTimingUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Timing> timings;

        public CreateTimingUC()
        {
            InitializeComponent();
            timings = new List<Timing>();
            xmlSerializer = new XmlSerializer(typeof(List<Timing>));

            // path of timings xml file
            String path = Path.Combine(Directory.GetCurrentDirectory(), "Timings.xml");

            // if file exists loading timings from xml file
            if (File.Exists(path))
            {
                FileStream existingTimingsFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();
            }

            LoadData(timings);
        }

        public void LoadData(List<Timing> x)
        {
            timingDataView.DataSource = null;
            timingDataView.DataSource = x;
        }

        private void btnCreateTiming_Click(object sender, EventArgs e)
        {
            // path of timings xml file
            String path = Path.Combine(Directory.GetCurrentDirectory(), "Timings.xml");

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new category object of Category class
            Timing timing = new Timing();

            timing.ID = Guid.NewGuid();
            timing.NoOfHours = Convert.ToInt32(txtNoOfHours.Text);
            timing.TimingName = txtTimingName.Text;
            timings.Add(timing);

            // serializing categories object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, timings);
            fileStream.Close();

            MessageBox.Show("ADDED TIMING SUCCESSFULLY");

            LoadData(timings);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // show open file dialoag and get the path of the csv file
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            // read contents of csv as individual lines
            string[] csvLines = File.ReadAllLines(fileName);

            // Create timings with CSV data
            var csvTimings = new List<Timing>();

            // split each row into column data
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowdata = csvLines[i].Split(',');

                var timing = new Timing();
                timing.ID = Guid.NewGuid();
                timing.NoOfHours = Convert.ToInt32(rowdata[0]);
                timing.TimingName = rowdata[1];

                csvTimings.Add(timing);
            }

            // adding timings from csv to existing timings
            timings.AddRange(csvTimings);

            // loading updated data
            LoadData(timings);
        }
    }
}
