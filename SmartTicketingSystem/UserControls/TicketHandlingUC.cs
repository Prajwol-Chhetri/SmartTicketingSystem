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
    public partial class TicketHandlingUC : UserControl
    {
        public TicketHandlingUC()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketUC createUC = new CreateTicketUC();
            AddControlsToPanel(createUC);
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
