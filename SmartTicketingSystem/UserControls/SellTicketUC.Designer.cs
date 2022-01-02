
namespace SmartTicketingSystem.UserControls
{
    partial class SellTicketUC
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboTicket = new System.Windows.Forms.ComboBox();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sellDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSaleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtEntryTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSaleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(35, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ticket:";
            // 
            // comboTicket
            // 
            this.comboTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicket.FormattingEnabled = true;
            this.comboTicket.Location = new System.Drawing.Point(39, 385);
            this.comboTicket.Name = "comboTicket";
            this.comboTicket.Size = new System.Drawing.Size(434, 31);
            this.comboTicket.TabIndex = 51;
            this.comboTicket.SelectedIndexChanged += new System.EventHandler(this.comboTicket_SelectedIndexChanged);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSellTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSellTicket.FlatAppearance.BorderSize = 0;
            this.btnSellTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.ForeColor = System.Drawing.Color.White;
            this.btnSellTicket.Location = new System.Drawing.Point(279, 521);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(434, 44);
            this.btnSellTicket.TabIndex = 50;
            this.btnSellTicket.Text = "Sell Ticket";
            this.btnSellTicket.UseVisualStyleBackColor = false;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(424, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sell Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellDataView
            // 
            this.sellDataView.AllowUserToAddRows = false;
            this.sellDataView.AllowUserToDeleteRows = false;
            this.sellDataView.AllowUserToResizeRows = false;
            this.sellDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellDataView.AutoGenerateColumns = false;
            this.sellDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TicketDate,
            this.CustomerName,
            this.CustomerContact,
            this.TicketName,
            this.TicketPrice,
            this.NoOfPeople,
            this.entryTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn});
            this.sellDataView.DataSource = this.ticketSaleBindingSource2;
            this.sellDataView.Location = new System.Drawing.Point(0, 0);
            this.sellDataView.Name = "sellDataView";
            this.sellDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sellDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sellDataView.RowHeadersWidth = 51;
            this.sellDataView.RowTemplate.Height = 24;
            this.sellDataView.Size = new System.Drawing.Size(984, 208);
            this.sellDataView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // TicketPrice
            // 
            this.TicketPrice.DataPropertyName = "TicketPrice";
            this.TicketPrice.HeaderText = "TicketPrice";
            this.TicketPrice.MinimumWidth = 6;
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            // 
            // NoOfPeople
            // 
            this.NoOfPeople.DataPropertyName = "NoOfPeople";
            this.NoOfPeople.HeaderText = "NoOfPeople";
            this.NoOfPeople.MinimumWidth = 6;
            this.NoOfPeople.Name = "NoOfPeople";
            this.NoOfPeople.ReadOnly = true;
            // 
            // entryTimeDataGridViewTextBoxColumn
            // 
            this.entryTimeDataGridViewTextBoxColumn.DataPropertyName = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.HeaderText = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entryTimeDataGridViewTextBoxColumn.Name = "entryTimeDataGridViewTextBoxColumn";
            // 
            // exitTimeDataGridViewTextBoxColumn
            // 
            this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.HeaderText = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
            // 
            // ticketSaleBindingSource2
            // 
            this.ticketSaleBindingSource2.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
            // 
            // txtEntryTime
            // 
            this.txtEntryTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntryTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryTime.Location = new System.Drawing.Point(513, 380);
            this.txtEntryTime.Name = "txtEntryTime";
            this.txtEntryTime.Size = new System.Drawing.Size(434, 36);
            this.txtEntryTime.TabIndex = 55;
            this.txtEntryTime.Text = "HH:MM:SS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(509, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Entry Time:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(39, 294);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(434, 36);
            this.txtCustomerName.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(35, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Customer Name:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(513, 294);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(434, 36);
            this.txtCustomerPhone.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(509, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(35, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "Ticket Price:";
            // 
            // ticketDatePicker
            // 
            this.ticketDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketDatePicker.Location = new System.Drawing.Point(513, 464);
            this.ticketDatePicker.Name = "ticketDatePicker";
            this.ticketDatePicker.Size = new System.Drawing.Size(434, 32);
            this.ticketDatePicker.TabIndex = 62;
            this.ticketDatePicker.ValueChanged += new System.EventHandler(this.ticketDatePicker_ValueChanged);
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketPrice.Enabled = false;
            this.txtTicketPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketPrice.Location = new System.Drawing.Point(39, 469);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(434, 36);
            this.txtTicketPrice.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(509, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Ticket For:";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Ticket);
            // 
            // ticketSaleBindingSource
            // 
            this.ticketSaleBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
            // 
            // ticketSaleBindingSource1
            // 
            this.ticketSaleBindingSource1.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
            // 
            // SellTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.ticketDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEntryTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellDataView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTicket);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SellTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTicket;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.BindingSource ticketSaleBindingSource;
        private System.Windows.Forms.DataGridView sellDataView;
        private System.Windows.Forms.BindingSource ticketSaleBindingSource1;
        private System.Windows.Forms.BindingSource ticketSaleBindingSource2;
        private System.Windows.Forms.TextBox txtEntryTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ticketDatePicker;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
    }
}
