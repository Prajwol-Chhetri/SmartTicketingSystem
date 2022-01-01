
namespace SmartTicketingSystem.UserControls
{
    partial class StaffHandlingUC
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnDeRegisterStaff = new System.Windows.Forms.Button();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnDeRegisterStaff);
            this.panelControl.Controls.Add(this.btnRegisterStaff);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(984, 580);
            this.panelControl.TabIndex = 0;
            // 
            // btnDeRegisterStaff
            // 
            this.btnDeRegisterStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeRegisterStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeRegisterStaff.FlatAppearance.BorderSize = 0;
            this.btnDeRegisterStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeRegisterStaff.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegisterStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeRegisterStaff.Location = new System.Drawing.Point(275, 345);
            this.btnDeRegisterStaff.Name = "btnDeRegisterStaff";
            this.btnDeRegisterStaff.Size = new System.Drawing.Size(434, 44);
            this.btnDeRegisterStaff.TabIndex = 46;
            this.btnDeRegisterStaff.Text = "De-Register Staff";
            this.btnDeRegisterStaff.UseVisualStyleBackColor = false;
            this.btnDeRegisterStaff.Click += new System.EventHandler(this.btnDeRegisterStaff_Click);
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnRegisterStaff.FlatAppearance.BorderSize = 0;
            this.btnRegisterStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterStaff.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStaff.ForeColor = System.Drawing.Color.White;
            this.btnRegisterStaff.Location = new System.Drawing.Point(275, 192);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(434, 44);
            this.btnRegisterStaff.TabIndex = 45;
            this.btnRegisterStaff.Text = "Register Staff";
            this.btnRegisterStaff.UseVisualStyleBackColor = false;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // StaffHandlingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StaffHandlingUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnDeRegisterStaff;
        private System.Windows.Forms.Button btnRegisterStaff;
    }
}
