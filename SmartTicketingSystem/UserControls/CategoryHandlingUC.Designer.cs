
namespace SmartTicketingSystem.UserControls
{
    partial class CategoryHandlingUC
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnUpdateCategory);
            this.panelControls.Controls.Add(this.btnDeleteCategory);
            this.panelControls.Controls.Add(this.btnCreateCategory);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(984, 580);
            this.panelControls.TabIndex = 2;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(275, 268);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(434, 44);
            this.btnUpdateCategory.TabIndex = 47;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(275, 345);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(434, 44);
            this.btnDeleteCategory.TabIndex = 46;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCreateCategory.FlatAppearance.BorderSize = 0;
            this.btnCreateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.White;
            this.btnCreateCategory.Location = new System.Drawing.Point(275, 192);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(434, 44);
            this.btnCreateCategory.TabIndex = 45;
            this.btnCreateCategory.Text = "Create Category";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // CategoryHandlingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControls);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CategoryHandlingUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnCreateCategory;
    }
}
