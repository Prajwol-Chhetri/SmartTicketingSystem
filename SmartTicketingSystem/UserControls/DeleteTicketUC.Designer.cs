
namespace SmartTicketingSystem.UserControls
{
    partial class DeleteTicketUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboTicketName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(334, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select Ticket to Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboTicketName
            // 
            this.comboTicketName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketName.FormattingEnabled = true;
            this.comboTicketName.Location = new System.Drawing.Point(274, 382);
            this.comboTicketName.Name = "comboTicketName";
            this.comboTicketName.Size = new System.Drawing.Size(434, 31);
            this.comboTicketName.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(270, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ticket Name:";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteTicket.FlatAppearance.BorderSize = 0;
            this.btnDeleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTicket.Location = new System.Drawing.Point(274, 469);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(434, 44);
            this.btnDeleteTicket.TabIndex = 37;
            this.btnDeleteTicket.Text = "Delete Ticket";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Ticket);
            // 
            // ticketDataView
            // 
            this.ticketDataView.AllowUserToAddRows = false;
            this.ticketDataView.AllowUserToDeleteRows = false;
            this.ticketDataView.AllowUserToResizeRows = false;
            this.ticketDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketDataView.AutoGenerateColumns = false;
            this.ticketDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ticketDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Duration,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ticketDataView.DataSource = this.ticketBindingSource;
            this.ticketDataView.Location = new System.Drawing.Point(0, 0);
            this.ticketDataView.Name = "ticketDataView";
            this.ticketDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ticketDataView.RowHeadersWidth = 51;
            this.ticketDataView.RowTemplate.Height = 24;
            this.ticketDataView.Size = new System.Drawing.Size(984, 208);
            this.ticketDataView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TicketRate";
            this.dataGridViewTextBoxColumn2.HeaderText = "TicketRate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TicketName";
            this.dataGridViewTextBoxColumn4.HeaderText = "TicketName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DeleteTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ticketDataView);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTicketName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTicketName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.DataGridView ticketDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
