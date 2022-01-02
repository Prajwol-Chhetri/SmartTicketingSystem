﻿
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
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellDataView = new System.Windows.Forms.DataGridView();
            this.ticketSaleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSaleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(272, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ticket:";
            // 
            // comboTicket
            // 
            this.comboTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicket.FormattingEnabled = true;
            this.comboTicket.Location = new System.Drawing.Point(276, 387);
            this.comboTicket.Name = "comboTicket";
            this.comboTicket.Size = new System.Drawing.Size(434, 31);
            this.comboTicket.TabIndex = 51;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSellTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSellTicket.FlatAppearance.BorderSize = 0;
            this.btnSellTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.ForeColor = System.Drawing.Color.White;
            this.btnSellTicket.Location = new System.Drawing.Point(276, 446);
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
            this.label1.Location = new System.Drawing.Point(415, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sell Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Ticket);
            // 
            // ticketSaleBindingSource
            // 
            this.ticketSaleBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
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
            this.ticketDataGridViewTextBoxColumn,
            this.entryTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn,
            this.soldDateDataGridViewTextBoxColumn});
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
            // ticketSaleBindingSource2
            // 
            this.ticketSaleBindingSource2.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
            // 
            // ticketSaleBindingSource1
            // 
            this.ticketSaleBindingSource1.DataSource = typeof(SmartTicketingSystem.Classes.TicketSale);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ticketDataGridViewTextBoxColumn
            // 
            this.ticketDataGridViewTextBoxColumn.DataPropertyName = "Ticket";
            this.ticketDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.ticketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketDataGridViewTextBoxColumn.Name = "ticketDataGridViewTextBoxColumn";
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
            // soldDateDataGridViewTextBoxColumn
            // 
            this.soldDateDataGridViewTextBoxColumn.DataPropertyName = "SoldDate";
            this.soldDateDataGridViewTextBoxColumn.HeaderText = "SoldDate";
            this.soldDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soldDateDataGridViewTextBoxColumn.Name = "soldDateDataGridViewTextBoxColumn";
            // 
            // SellTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.sellDataView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTicket);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SellTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSaleBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldDateDataGridViewTextBoxColumn;
    }
}
