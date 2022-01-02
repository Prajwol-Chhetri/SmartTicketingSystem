using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTicketingSystem.UserControls;

namespace SmartTicketingSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public AdminDashboardForm(string value)
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            DashboardUC dbuc = new DashboardUC();
            AddControlsToPanel(dbuc);
            lblName.Text = value;
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10; 
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    pictureBox3.Show();
                    label1.Show();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 57)
                {
                    timer1.Stop();
                    pictureBox3.Hide();
                    label1.Hide();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAdminDashboard);
            DashboardUC dbuc = new DashboardUC();
            AddControlsToPanel(dbuc);
        }

        private void btnAdminTickets_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAdminTickets);
            TicketHandlingUC ticketHandlingUC = new TicketHandlingUC();
            AddControlsToPanel(ticketHandlingUC);
        }

        private void btnAdminStaffs_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAdminStaffs);
            StaffHandlingUC staffHandlingUC = new StaffHandlingUC();
            AddControlsToPanel(staffHandlingUC);
        }

        private void btnAdminReport_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAdminReport);
            ReportHandlingUC reportUC = new ReportHandlingUC();
            AddControlsToPanel(reportUC);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }

        private void btnVisitorCategories_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVisitorCategories);
            CategoryHandlingUC categoryUC = new CategoryHandlingUC();
            AddControlsToPanel(categoryUC);
        }

        private void btnVisitorTimings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVisitorTimings);
            TimingHandlingUC timingUC = new TimingHandlingUC();
            AddControlsToPanel(timingUC);
        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSellTicket);
            SellTicketUC sellTicketUC = new SellTicketUC();
            AddControlsToPanel(sellTicketUC);
        }

        private void btnGetTicket_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnGetTicket);
            GetTicketUC getTicketUC = new GetTicketUC();
            AddControlsToPanel(getTicketUC);
        }
    }
}
