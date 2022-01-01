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
    public partial class CreateTimingUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Timing> timings;

        public CreateTimingUC()
        {
            InitializeComponent();
            timings = new List<Timing>();
            xmlSerializer = new XmlSerializer(typeof(List<Timing>));
        }

        private void btnCreateTiming_Click(object sender, EventArgs e)
        {
            // path of timings xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Timings.xml";

            // if file exists loading timings from xml file
            if (File.Exists(path))
            {
                FileStream existingTimingsFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                timings = (List<Timing>)xmlSerializer.Deserialize(existingTimingsFS);
                existingTimingsFS.Close();
            }

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new category object of Category class
            Timing timing = new Timing();

            timing.id = Guid.NewGuid();
            timing.noOfHours = Convert.ToInt32(txtNoOfHours.Text);
            timing.timingName = txtTimingName.Text;
            timings.Add(timing);

            // serializing categories object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, timings);
            fileStream.Close();

            MessageBox.Show("ADDED TIMING SUCCESSFULLY");
        }
    }
}