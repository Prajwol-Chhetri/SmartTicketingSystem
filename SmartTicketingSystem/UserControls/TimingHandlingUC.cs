using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTicketingSystem.UserControls
{
    public partial class TimingHandlingUC : UserControl
    {
        public TimingHandlingUC()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }


        private void btnCreateTiming_Click(object sender, EventArgs e)
        {
            CreateTimingUC createUC = new CreateTimingUC();
            AddControlsToPanel(createUC);
        }

        private void btnUpdateTiming_Click(object sender, EventArgs e)
        {
            UpdateTimingUC updateUC = new UpdateTimingUC();
            AddControlsToPanel(updateUC);
        }

        private void btnDeleteTiming_Click(object sender, EventArgs e)
        {

        }
    }
}
