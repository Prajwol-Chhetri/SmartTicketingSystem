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
    public partial class StaffHandlingUC : UserControl
    {
        public StaffHandlingUC()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            RegistrationUC addUC = new RegistrationUC();
            AddControlsToPanel(addUC);
        }

        private void btnDeRegisterStaff_Click(object sender, EventArgs e)
        {
            DeRegistrationUC deleteUC = new DeRegistrationUC();
            AddControlsToPanel(deleteUC);
        }
    }
}
