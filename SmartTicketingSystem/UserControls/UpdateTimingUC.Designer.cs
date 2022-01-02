
namespace SmartTicketingSystem.UserControls
{
    partial class UpdateTimingUC
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
            this.txtTimingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateTiming = new System.Windows.Forms.Button();
            this.txtNoOfHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTimingName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtTimingName
            // 
            this.txtTimingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimingName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimingName.Location = new System.Drawing.Point(515, 397);
            this.txtTimingName.Name = "txtTimingName";
            this.txtTimingName.Size = new System.Drawing.Size(434, 36);
            this.txtTimingName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(511, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Timing Name:";
            // 
            // btnUpdateTiming
            // 
            this.btnUpdateTiming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnUpdateTiming.FlatAppearance.BorderSize = 0;
            this.btnUpdateTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTiming.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTiming.Location = new System.Drawing.Point(277, 475);
            this.btnUpdateTiming.Name = "btnUpdateTiming";
            this.btnUpdateTiming.Size = new System.Drawing.Size(434, 44);
            this.btnUpdateTiming.TabIndex = 54;
            this.btnUpdateTiming.Text = "Update Timing";
            this.btnUpdateTiming.UseVisualStyleBackColor = false;
            this.btnUpdateTiming.Click += new System.EventHandler(this.btnUpdateTiming_Click);
            // 
            // txtNoOfHours
            // 
            this.txtNoOfHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoOfHours.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfHours.Location = new System.Drawing.Point(36, 397);
            this.txtNoOfHours.Name = "txtNoOfHours";
            this.txtNoOfHours.Size = new System.Drawing.Size(434, 36);
            this.txtNoOfHours.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(32, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "No of Hours:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(352, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "Enter Timing Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(273, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Timing Name:";
            // 
            // comboTimingName
            // 
            this.comboTimingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTimingName.FormattingEnabled = true;
            this.comboTimingName.Location = new System.Drawing.Point(277, 121);
            this.comboTimingName.Name = "comboTimingName";
            this.comboTimingName.Size = new System.Drawing.Size(434, 31);
            this.comboTimingName.TabIndex = 58;
            this.comboTimingName.SelectedIndexChanged += new System.EventHandler(this.comboTimingName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(338, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 34);
            this.label4.TabIndex = 57;
            this.label4.Text = "Select Timing to Update";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 5);
            this.panel1.TabIndex = 60;
            // 
            // UpdateTimingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTimingName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimingName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateTiming);
            this.Controls.Add(this.txtNoOfHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateTimingUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimingName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateTiming;
        private System.Windows.Forms.TextBox txtNoOfHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTimingName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
