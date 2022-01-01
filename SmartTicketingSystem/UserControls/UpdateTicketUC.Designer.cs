
namespace SmartTicketingSystem.UserControls
{
    partial class UpdateTicketUC
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
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTicketName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicketName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTicketCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTicketTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnUpdateTicket.FlatAppearance.BorderSize = 0;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTicket.Location = new System.Drawing.Point(277, 511);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(434, 44);
            this.btnUpdateTicket.TabIndex = 41;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(273, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ticket Name:";
            // 
            // comboTicketName
            // 
            this.comboTicketName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketName.FormattingEnabled = true;
            this.comboTicketName.Location = new System.Drawing.Point(277, 96);
            this.comboTicketName.Name = "comboTicketName";
            this.comboTicketName.Size = new System.Drawing.Size(434, 31);
            this.comboTicketName.TabIndex = 39;
            this.comboTicketName.SelectedIndexChanged += new System.EventHandler(this.comboTicketName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "Select Ticket to Update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTicketName
            // 
            this.txtTicketName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketName.Location = new System.Drawing.Point(519, 416);
            this.txtTicketName.Name = "txtTicketName";
            this.txtTicketName.Size = new System.Drawing.Size(354, 36);
            this.txtTicketName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(515, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ticket Name:";
            // 
            // comboTicketCategory
            // 
            this.comboTicketCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketCategory.FormattingEnabled = true;
            this.comboTicketCategory.Location = new System.Drawing.Point(55, 420);
            this.comboTicketCategory.Name = "comboTicketCategory";
            this.comboTicketCategory.Size = new System.Drawing.Size(354, 31);
            this.comboTicketCategory.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(51, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Category:";
            // 
            // comboTicketTime
            // 
            this.comboTicketTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketTime.FormattingEnabled = true;
            this.comboTicketTime.Location = new System.Drawing.Point(519, 324);
            this.comboTicketTime.Name = "comboTicketTime";
            this.comboTicketTime.Size = new System.Drawing.Size(354, 31);
            this.comboTicketTime.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(515, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Valid For:";
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(55, 320);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(354, 36);
            this.txtRate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(51, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ticket Rate:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(354, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 34);
            this.label7.TabIndex = 50;
            this.label7.Text = "Enter Ticket Details";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 5);
            this.panel1.TabIndex = 51;
            // 
            // UpdateTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTicketName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTicketCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTicketTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTicketName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTicketName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTicketName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTicketCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTicketTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}
