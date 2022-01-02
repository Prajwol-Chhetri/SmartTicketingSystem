
namespace SmartTicketingSystem.UserControls
{
    partial class DailyReportUC
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
            this.dailyReportDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalEarning = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(345, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 34);
            this.label1.TabIndex = 46;
            this.label1.Text = "Daily Sales Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dailyReportDataGrid
            // 
            this.dailyReportDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dailyReportDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dailyReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportDataGrid.Location = new System.Drawing.Point(231, 128);
            this.dailyReportDataGrid.Name = "dailyReportDataGrid";
            this.dailyReportDataGrid.RowHeadersWidth = 51;
            this.dailyReportDataGrid.RowTemplate.Height = 24;
            this.dailyReportDataGrid.Size = new System.Drawing.Size(510, 332);
            this.dailyReportDataGrid.TabIndex = 47;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(302, 78);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(367, 32);
            this.dateTimePicker.TabIndex = 48;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCustomer.Location = new System.Drawing.Point(762, 524);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.ReadOnly = true;
            this.txtTotalCustomer.Size = new System.Drawing.Size(180, 36);
            this.txtTotalCustomer.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(758, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total Customer:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(49, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Total Earning:";
            // 
            // txtTotalEarning
            // 
            this.txtTotalEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalEarning.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEarning.Location = new System.Drawing.Point(53, 524);
            this.txtTotalEarning.Name = "txtTotalEarning";
            this.txtTotalEarning.ReadOnly = true;
            this.txtTotalEarning.Size = new System.Drawing.Size(180, 36);
            this.txtTotalEarning.TabIndex = 59;
            // 
            // DailyReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtTotalCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalEarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dailyReportDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DailyReport";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dailyReportDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalEarning;
    }
}
