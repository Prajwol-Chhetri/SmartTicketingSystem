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
    public partial class ReportHandlingUC : UserControl
    {
        public ReportHandlingUC()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnDailyReport_Click_1(object sender, EventArgs e)
        {
            DailyReport dailyReportUC = new DailyReport();
            AddControlsToPanel(dailyReportUC);
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {

        }
    }
}
