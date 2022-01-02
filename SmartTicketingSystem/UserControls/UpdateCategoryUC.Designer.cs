
namespace SmartTicketingSystem.UserControls
{
    partial class UpdateCategoryUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategoryName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 5);
            this.panel1.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(273, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Category Name:";
            // 
            // comboCategoryName
            // 
            this.comboCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCategoryName.FormattingEnabled = true;
            this.comboCategoryName.Location = new System.Drawing.Point(277, 128);
            this.comboCategoryName.Name = "comboCategoryName";
            this.comboCategoryName.Size = new System.Drawing.Size(434, 31);
            this.comboCategoryName.TabIndex = 68;
            this.comboCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboCategoryName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(305, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 34);
            this.label4.TabIndex = 67;
            this.label4.Text = "Select Category to Update";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoryName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(514, 408);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(434, 36);
            this.txtCategoryName.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(510, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Category Name:";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(288, 489);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(434, 44);
            this.btnUpdateCategory.TabIndex = 48;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoOfPeople.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfPeople.Location = new System.Drawing.Point(40, 408);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.Size = new System.Drawing.Size(434, 36);
            this.txtNoOfPeople.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(36, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "No of People:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(326, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter Category Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateCategoryUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.comboCategoryName);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateCategoryUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtNoOfPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
