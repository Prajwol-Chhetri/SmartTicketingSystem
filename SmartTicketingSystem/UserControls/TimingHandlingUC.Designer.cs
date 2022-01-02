
namespace SmartTicketingSystem.UserControls
{
    partial class TimingHandlingUC
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
            this.btnUpdateTiming = new System.Windows.Forms.Button();
            this.btnDeleteTiming = new System.Windows.Forms.Button();
            this.btnCreateTiming = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnUpdateTiming);
            this.panelControls.Controls.Add(this.btnDeleteTiming);
            this.panelControls.Controls.Add(this.btnCreateTiming);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(984, 580);
            this.panelControls.TabIndex = 1;
            // 
            // btnUpdateTiming
            // 
            this.btnUpdateTiming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnUpdateTiming.FlatAppearance.BorderSize = 0;
            this.btnUpdateTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTiming.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTiming.Location = new System.Drawing.Point(275, 268);
            this.btnUpdateTiming.Name = "btnUpdateTiming";
            this.btnUpdateTiming.Size = new System.Drawing.Size(434, 44);
            this.btnUpdateTiming.TabIndex = 47;
            this.btnUpdateTiming.Text = "Update Timing";
            this.btnUpdateTiming.UseVisualStyleBackColor = false;
            this.btnUpdateTiming.Click += new System.EventHandler(this.btnUpdateTiming_Click);
            // 
            // btnDeleteTiming
            // 
            this.btnDeleteTiming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteTiming.FlatAppearance.BorderSize = 0;
            this.btnDeleteTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTiming.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTiming.Location = new System.Drawing.Point(275, 345);
            this.btnDeleteTiming.Name = "btnDeleteTiming";
            this.btnDeleteTiming.Size = new System.Drawing.Size(434, 44);
            this.btnDeleteTiming.TabIndex = 46;
            this.btnDeleteTiming.Text = "Delete Timing";
            this.btnDeleteTiming.UseVisualStyleBackColor = false;
            this.btnDeleteTiming.Click += new System.EventHandler(this.btnDeleteTiming_Click);
            // 
            // btnCreateTiming
            // 
            this.btnCreateTiming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCreateTiming.FlatAppearance.BorderSize = 0;
            this.btnCreateTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTiming.ForeColor = System.Drawing.Color.White;
            this.btnCreateTiming.Location = new System.Drawing.Point(275, 192);
            this.btnCreateTiming.Name = "btnCreateTiming";
            this.btnCreateTiming.Size = new System.Drawing.Size(434, 44);
            this.btnCreateTiming.TabIndex = 45;
            this.btnCreateTiming.Text = "Create Timing";
            this.btnCreateTiming.UseVisualStyleBackColor = false;
            this.btnCreateTiming.Click += new System.EventHandler(this.btnCreateTiming_Click);
            // 
            // TimingHandlingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControls);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimingHandlingUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnUpdateTiming;
        private System.Windows.Forms.Button btnDeleteTiming;
        private System.Windows.Forms.Button btnCreateTiming;
    }
}
