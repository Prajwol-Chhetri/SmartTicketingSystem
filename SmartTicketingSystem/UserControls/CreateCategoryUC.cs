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
    public partial class CreateCategoryUC : UserControl
    {
        XmlSerializer xmlSerializer;
        List<Category> categories;

        public CreateCategoryUC()
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
            }

            LoadData(categories);
        }

        public void LoadData(List<Category> x)
        {
            categoryDataView.DataSource = null;
            categoryDataView.DataSource = x;
        }


        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            // path of categories xml file
            String path = "D:/work/year 3/Coursework/Application Dev/SmartTicketingSystem/Categories.xml";

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new category object of Category class
            Category category = new Category();

            category.id = Guid.NewGuid();
            category.noOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
            category.categoryName = txtCategoryName.Text;
            categories.Add(category);

            // serializing categories object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, categories);
            fileStream.Close();

            MessageBox.Show("ADDED CATEGORY SUCCESSFULLY");

            //updating data grid view
            LoadData(categories);
            categoryDataView.Update();
            categoryDataView.Refresh();
        }
    }
}
