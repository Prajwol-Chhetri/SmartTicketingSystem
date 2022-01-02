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
    public partial class CategoryHandlingUC : UserControl
    {
        public CategoryHandlingUC()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            CreateCategoryUC createUC = new CreateCategoryUC();
            AddControlsToPanel(createUC);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryUC updateUC = new UpdateCategoryUC();
            AddControlsToPanel(updateUC);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
