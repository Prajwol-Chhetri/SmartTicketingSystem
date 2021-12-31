
namespace SmartTicketingSystem.UserControls
{
    partial class DeRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(260, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Email of Staff to Remove";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffEmail.Location = new System.Drawing.Point(314, 268);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(325, 36);
            this.txtStaffEmail.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(313, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email:";
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnRemoveStaff.FlatAppearance.BorderSize = 0;
            this.btnRemoveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStaff.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStaff.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStaff.Location = new System.Drawing.Point(252, 377);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(434, 44);
            this.btnRemoveStaff.TabIndex = 31;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = false;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // DeRegistration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.txtStaffEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeRegistration";
            this.Size = new System.Drawing.Size(984, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveStaff;
    }
}
