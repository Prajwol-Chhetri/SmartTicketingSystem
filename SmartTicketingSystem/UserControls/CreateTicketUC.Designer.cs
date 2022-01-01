
namespace SmartTicketingSystem.UserControls
{
    partial class CreateTicketUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTicketTime = new System.Windows.Forms.ComboBox();
            this.comboTicketCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTicketName = new System.Windows.Forms.TextBox();
            this.ticketDataView = new System.Windows.Forms.DataGridView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(359, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Ticket Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(33, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ticket Rate:";
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(37, 338);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(434, 36);
            this.txtRate.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(514, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Valid For:";
            // 
            // comboTicketTime
            // 
            this.comboTicketTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketTime.FormattingEnabled = true;
            this.comboTicketTime.Location = new System.Drawing.Point(518, 343);
            this.comboTicketTime.Name = "comboTicketTime";
            this.comboTicketTime.Size = new System.Drawing.Size(434, 31);
            this.comboTicketTime.TabIndex = 31;
            // 
            // comboTicketCategory
            // 
            this.comboTicketCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTicketCategory.FormattingEnabled = true;
            this.comboTicketCategory.Location = new System.Drawing.Point(37, 435);
            this.comboTicketCategory.Name = "comboTicketCategory";
            this.comboTicketCategory.Size = new System.Drawing.Size(434, 31);
            this.comboTicketCategory.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(33, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Category:";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCreateTicket.FlatAppearance.BorderSize = 0;
            this.btnCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.ForeColor = System.Drawing.Color.White;
            this.btnCreateTicket.Location = new System.Drawing.Point(251, 518);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(434, 44);
            this.btnCreateTicket.TabIndex = 34;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = false;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(514, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ticket Name:";
            // 
            // txtTicketName
            // 
            this.txtTicketName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketName.Location = new System.Drawing.Point(518, 430);
            this.txtTicketName.Name = "txtTicketName";
            this.txtTicketName.Size = new System.Drawing.Size(434, 36);
            this.txtTicketName.TabIndex = 36;
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
            this.idDataGridViewTextBoxColumn,
            this.ticketRateDataGridViewTextBoxColumn,
            this.timingDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn});
            this.ticketDataView.DataSource = this.ticketBindingSource;
            this.ticketDataView.Location = new System.Drawing.Point(0, 0);
            this.ticketDataView.Name = "ticketDataView";
            this.ticketDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ticketDataView.RowHeadersWidth = 51;
            this.ticketDataView.RowTemplate.Height = 24;
            this.ticketDataView.Size = new System.Drawing.Size(984, 208);
            this.ticketDataView.TabIndex = 46;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Ticket);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ticketRateDataGridViewTextBoxColumn
            // 
            this.ticketRateDataGridViewTextBoxColumn.DataPropertyName = "ticketRate";
            this.ticketRateDataGridViewTextBoxColumn.HeaderText = "ticketRate";
            this.ticketRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketRateDataGridViewTextBoxColumn.Name = "ticketRateDataGridViewTextBoxColumn";
            // 
            // timingDataGridViewTextBoxColumn
            // 
            this.timingDataGridViewTextBoxColumn.DataPropertyName = "timing";
            this.timingDataGridViewTextBoxColumn.HeaderText = "timing";
            this.timingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timingDataGridViewTextBoxColumn.Name = "timingDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "ticketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "ticketName";
            this.ticketNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            // 
            // CreateTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ticketDataView);
            this.Controls.Add(this.txtTicketName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.comboTicketCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTicketTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTicketUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTicketTime;
        private System.Windows.Forms.ComboBox comboTicketCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTicketName;
        private System.Windows.Forms.DataGridView ticketDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource;
    }
}
