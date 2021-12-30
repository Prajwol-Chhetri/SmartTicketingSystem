﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTicketingSystem.Forms;

namespace SmartTicketingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            using (AdminDashboardForm fd = new AdminDashboardForm())
            {
                fd.ShowDialog();
            }
            */


            using (StaffDashboardForm fd = new StaffDashboardForm())
            {
                fd.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (AdminRegisterForm fd = new AdminRegisterForm())
            {
                fd.ShowDialog();
            }
        }
    }
}