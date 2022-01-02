
namespace SmartTicketingSystem.UserControls
{
    partial class DeleteCategoryUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categoryDataView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategoryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataView
            // 
            this.categoryDataView.AllowUserToAddRows = false;
            this.categoryDataView.AllowUserToDeleteRows = false;
            this.categoryDataView.AllowUserToResizeRows = false;
            this.categoryDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryDataView.AutoGenerateColumns = false;
            this.categoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.noOfPeopleDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.categoryDataView.DataSource = this.categoryBindingSource;
            this.categoryDataView.Location = new System.Drawing.Point(0, 0);
            this.categoryDataView.Name = "categoryDataView";
            this.categoryDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.categoryDataView.RowHeadersWidth = 51;
            this.categoryDataView.RowTemplate.Height = 24;
            this.categoryDataView.Size = new System.Drawing.Size(984, 208);
            this.categoryDataView.TabIndex = 46;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Category);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // noOfPeopleDataGridViewTextBoxColumn
            // 
            this.noOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.HeaderText = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfPeopleDataGridViewTextBoxColumn.Name = "noOfPeopleDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(262, 480);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(434, 44);
            this.btnDeleteCategory.TabIndex = 60;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(258, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Category Name:";
            // 
            // comboCategoryName
            // 
            this.comboCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCategoryName.FormattingEnabled = true;
            this.comboCategoryName.Location = new System.Drawing.Point(262, 393);
            this.comboCategoryName.Name = "comboCategoryName";
            this.comboCategoryName.Size = new System.Drawing.Size(434, 31);
            this.comboCategoryName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(284, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 34);
            this.label1.TabIndex = 57;
            this.label1.Text = "Select Category to Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteCategoryUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryDataView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteCategoryUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCategoryName;
        private System.Windows.Forms.Label label1;
    }
}
