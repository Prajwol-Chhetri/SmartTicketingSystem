using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTicketingSystem.Forms
{
    public partial class StaffDashboardForm : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public StaffDashboardForm()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
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

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStaffDashboard);
        }

        private void btnAdminTickets_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStaffTickets);
        }

        private void btnAdminReport_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStaffReport);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }
    }
}
