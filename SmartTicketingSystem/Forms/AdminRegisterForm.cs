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
    public partial class AdminRegisterForm : Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            using (LoginForm fd = new LoginForm())
            {
                fd.ShowDialog();
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
