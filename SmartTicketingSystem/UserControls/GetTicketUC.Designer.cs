
namespace SmartTicketingSystem.UserControls
{
    partial class GetTicketUC
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.sellDataView = new System.Windows.Forms.DataGridView();
            this.TicketDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(260, 151);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(434, 36);
            this.txtID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(256, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(339, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter Sold Ticket ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnGetTicket.FlatAppearance.BorderSize = 0;
            this.btnGetTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTicket.ForeColor = System.Drawing.Color.White;
            this.btnGetTicket.Location = new System.Drawing.Point(260, 232);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(434, 44);
            this.btnGetTicket.TabIndex = 35;
            this.btnGetTicket.Text = "Get Detail";
            this.btnGetTicket.UseVisualStyleBackColor = false;
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
            // 
            // sellDataView
            // 
            this.sellDataView.AllowUserToAddRows = false;
            this.sellDataView.AllowUserToDeleteRows = false;
            this.sellDataView.AllowUserToResizeRows = false;
            this.sellDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketDate,
            this.CustomerName,
            this.CustomerContact,
            this.TicketName,
            this.NoOfPeople,
            this.Total});
            this.sellDataView.Location = new System.Drawing.Point(0, 372);
            this.sellDataView.Name = "sellDataView";
            this.sellDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sellDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sellDataView.RowHeadersWidth = 51;
            this.sellDataView.RowTemplate.Height = 24;
            this.sellDataView.Size = new System.Drawing.Size(984, 208);
            this.sellDataView.TabIndex = 54;
            // 
            // TicketDate
            // 
            this.TicketDate.DataPropertyName = "TicketDate";
            this.TicketDate.HeaderText = "TicketDate";
            this.TicketDate.MinimumWidth = 6;
            this.TicketDate.Name = "TicketDate";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerContact
            // 
            this.CustomerContact.DataPropertyName = "CustomerContact";
            this.CustomerContact.HeaderText = "CustomerContact";
            this.CustomerContact.MinimumWidth = 6;
            this.CustomerContact.Name = "CustomerContact";
            // 
            // TicketName
            // 
            this.TicketName.DataPropertyName = "TicketName";
            this.TicketName.HeaderText = "TicketName";
            this.TicketName.MinimumWidth = 6;
            this.TicketName.Name = "TicketName";
            this.TicketName.ReadOnly = true;
            // 
            // NoOfPeople
            // 
            this.NoOfPeople.DataPropertyName = "NoOfPeople";
            this.NoOfPeople.HeaderText = "NoOfPeople";
            this.NoOfPeople.MinimumWidth = 6;
            this.NoOfPeople.Name = "NoOfPeople";
            this.NoOfPeople.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // GetTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.sellDataView);
            this.Controls.Add(this.btnGetTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GetTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.DataGridView sellDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
