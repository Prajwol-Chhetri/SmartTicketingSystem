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
            String path = Path.Combine(Directory.GetCurrentDirectory(), "Categories.xml");

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
            String path = Path.Combine(Directory.GetCurrentDirectory(), "Categories.xml");

            // overwriting existing xml file
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            // creating new category object of Category class
            Category category = new Category();

            category.ID = Guid.NewGuid();
            category.NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
            category.CategoryName = txtCategoryName.Text;
            categories.Add(category);

            // serializing categories object to XMl file and closing it
            xmlSerializer.Serialize(fileStream, categories);
            fileStream.Close();

            MessageBox.Show("ADDED CATEGORY SUCCESSFULLY");

            //updating data grid view
            LoadData(categories);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // show open file dialoag and get the path of the csv file
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            // read contents of csv as individual lines
            string[] csvLines = File.ReadAllLines(fileName);

            // Create categories with CSV data
            var csvCategories = new List<Category>();

            // split each row into column data
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowdata = csvLines[i].Split(',');

                var category = new Category();
                category.ID = Guid.NewGuid();
                category.NoOfPeople = Convert.ToInt32(rowdata[0]);
                category.CategoryName = rowdata[1];

                csvCategories.Add(category);
            }

            // adding categories from csv to existing categories
            categories.AddRange(csvCategories);

            // loading updated data
            LoadData(categories);
        }
    }
}
