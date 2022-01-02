using System;
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
    public partial class UpdateCategoryUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Category> categories;

        public UpdateCategoryUC()
        {
            InitializeComponent();
            categories = new List<Category>();
            xmlSerializer = new XmlSerializer(typeof(List<Category>));

            // path of categories xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";

            // if file exists loading categories from xml file
            if (File.Exists(path))
            {
                FileStream existingCategoriesFS = new FileStream(path, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlSerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();

                // loading data into category combobox by binding category list as datasource
                comboCategoryName.DataSource = categories;
                comboCategoryName.DisplayMember = "CategoryName";
            }
            else
            {
                MessageBox.Show("NO CATEGORIES PLEASE CREATE A CATEGORY FIRST");
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (categories.Count > 0)
            {
                String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // getting details of currently selected category
                var selectedCategory = (Category)comboCategoryName.SelectedItem;

                // finding category in categories list
                var categoryToUpdate = categories.Find(x => x.ID == selectedCategory.ID);


                // updating category from new data
                categoryToUpdate.CategoryName = txtCategoryName.Text;
                categoryToUpdate.NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);

                // serializing category object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, categories);
                fileStream.Close();

                MessageBox.Show("UPDATED CATEGORY SUCCESSFULLY");
            }
        }

        private void comboCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting details of currently selected category
            var selectedCategory = (Category)comboCategoryName.SelectedItem;

            // setting the details of currently selected category in the update fields
            txtCategoryName.Text = selectedCategory.CategoryName;
            txtNoOfPeople.Text = Convert.ToString(selectedCategory.NoOfPeople);
        }
    }
}
