
namespace SmartTicketingSystem.UserControls
{
    partial class WeeklyReportUC
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
            this.weeklyReportDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalEarning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(346, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Weekly Sales Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weeklyReportDataGrid
            // 
            this.weeklyReportDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weeklyReportDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weeklyReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportDataGrid.Location = new System.Drawing.Point(237, 135);
            this.weeklyReportDataGrid.Name = "weeklyReportDataGrid";
            this.weeklyReportDataGrid.RowHeadersWidth = 51;
            this.weeklyReportDataGrid.RowTemplate.Height = 24;
            this.weeklyReportDataGrid.Size = new System.Drawing.Size(510, 332);
            this.weeklyReportDataGrid.TabIndex = 48;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(307, 86);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(367, 32);
            this.dateTimePicker.TabIndex = 49;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCustomer.Location = new System.Drawing.Point(756, 527);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.ReadOnly = true;
            this.txtTotalCustomer.Size = new System.Drawing.Size(180, 36);
            this.txtTotalCustomer.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(752, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Total Customer:";
            // 
            // txtTotalEarning
            // 
            this.txtTotalEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalEarning.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEarning.Location = new System.Drawing.Point(47, 527);
            this.txtTotalEarning.Name = "txtTotalEarning";
            this.txtTotalEarning.ReadOnly = true;
            this.txtTotalEarning.Size = new System.Drawing.Size(180, 36);
            this.txtTotalEarning.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(43, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Total Earning:";
            // 
            // WeeklyReportUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtTotalCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalEarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.weeklyReportDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WeeklyReportUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView weeklyReportDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalEarning;
        private System.Windows.Forms.Label label3;
    }
}
