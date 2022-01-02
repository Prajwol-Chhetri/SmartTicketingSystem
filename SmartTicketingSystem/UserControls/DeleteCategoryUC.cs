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
    public partial class DeleteCategoryUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Category> categories;

        public DeleteCategoryUC()
        {
            InitializeComponent();
            categories = new List<Category>();
            xmlSerializer = new XmlSerializer(typeof(List<Category>));

            // loading data from categories xml file to display in combobox
            String categoriesPath = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";
            if (File.Exists(categoriesPath))
            {
                FileStream existingCategoriesFS = new FileStream(categoriesPath, FileMode.Open, FileAccess.Read);
                categories = (List<Category>)xmlSerializer.Deserialize(existingCategoriesFS);
                existingCategoriesFS.Close();

                // loading data into categories combobox by binding categories list as datasource
                comboCategoryName.DataSource = categories;
                comboCategoryName.DisplayMember = "CategoryName";

                // loading data into data grid view
                LoadData(categories);
            }
            else
            {
                MessageBox.Show("NO CATEGORIES PLEASE CREATE A CATEGORY FIRST");
            }
        }

        public void LoadData(List<Category> x)
        {
            categoryDataView.DataSource = null;
            categoryDataView.DataSource = x;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (categories.Count > 0)
            {
                string path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";

                // overwriting existing xml file
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                // getting details of currently selected category
                var selectedCategory = (Category)comboCategoryName.SelectedItem;

                // fetching category from list of category
                var category = categories.SingleOrDefault(x => x.ID == selectedCategory.ID);
                if (category != null)
                {
                    // removing timing if category is found
                    categories.Remove(category);
                    MessageBox.Show("REMOVED CATEGORY SUCCESSFULLY");
                }

                // serializing categories object to XMl file and closing it
                xmlSerializer.Serialize(fileStream, categories);
                fileStream.Close();

                // loading updated data into data grid view
                LoadData(categories);
            }
        }
    }
}
