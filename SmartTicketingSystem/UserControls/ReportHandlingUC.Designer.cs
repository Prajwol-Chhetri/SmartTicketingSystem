
namespace SmartTicketingSystem.UserControls
{
    partial class ReportHandlingUC
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
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnWeeklyReport);
            this.panelControls.Controls.Add(this.btnDailyReport);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(984, 580);
            this.panelControls.TabIndex = 0;
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeeklyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnWeeklyReport.FlatAppearance.BorderSize = 0;
            this.btnWeeklyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.ForeColor = System.Drawing.Color.White;
            this.btnWeeklyReport.Location = new System.Drawing.Point(275, 306);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(434, 44);
            this.btnWeeklyReport.TabIndex = 51;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDailyReport.FlatAppearance.BorderSize = 0;
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.ForeColor = System.Drawing.Color.White;
            this.btnDailyReport.Location = new System.Drawing.Point(275, 230);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(434, 44);
            this.btnDailyReport.TabIndex = 50;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click_1);
            // 
            // ReportHandlingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControls);
            this.Name = "ReportHandlingUC";
            this.Size = new System.Drawing.Size(984, 580);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnDailyReport;
    }
}
