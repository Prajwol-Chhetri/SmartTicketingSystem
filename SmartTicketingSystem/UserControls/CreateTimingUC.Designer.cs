
namespace SmartTicketingSystem.UserControls
{
    partial class CreateTimingUC
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
            this.txtTimingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateTiming = new System.Windows.Forms.Button();
            this.txtNoOfHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timingDataView = new System.Windows.Forms.DataGridView();
            this.timingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.timingDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimingName
            // 
            this.txtTimingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimingName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimingName.Location = new System.Drawing.Point(515, 391);
            this.txtTimingName.Name = "txtTimingName";
            this.txtTimingName.Size = new System.Drawing.Size(434, 36);
            this.txtTimingName.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(511, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Timing Name:";
            // 
            // btnCreateTiming
            // 
            this.btnCreateTiming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCreateTiming.FlatAppearance.BorderSize = 0;
            this.btnCreateTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTiming.ForeColor = System.Drawing.Color.White;
            this.btnCreateTiming.Location = new System.Drawing.Point(277, 469);
            this.btnCreateTiming.Name = "btnCreateTiming";
            this.btnCreateTiming.Size = new System.Drawing.Size(434, 44);
            this.btnCreateTiming.TabIndex = 48;
            this.btnCreateTiming.Text = "Create Timing";
            this.btnCreateTiming.UseVisualStyleBackColor = false;
            this.btnCreateTiming.Click += new System.EventHandler(this.btnCreateTiming_Click);
            // 
            // txtNoOfHours
            // 
            this.txtNoOfHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoOfHours.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfHours.Location = new System.Drawing.Point(36, 391);
            this.txtNoOfHours.Name = "txtNoOfHours";
            this.txtNoOfHours.Size = new System.Drawing.Size(434, 36);
            this.txtNoOfHours.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(32, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "No of Hours:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(352, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter Timing Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timingDataView
            // 
            this.timingDataView.AllowUserToAddRows = false;
            this.timingDataView.AllowUserToDeleteRows = false;
            this.timingDataView.AllowUserToResizeRows = false;
            this.timingDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timingDataView.AutoGenerateColumns = false;
            this.timingDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timingDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timingDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.noOfHoursDataGridViewTextBoxColumn,
            this.timingNameDataGridViewTextBoxColumn});
            this.timingDataView.DataSource = this.timingBindingSource;
            this.timingDataView.Location = new System.Drawing.Point(0, 0);
            this.timingDataView.Name = "timingDataView";
            this.timingDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timingDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.timingDataView.RowHeadersWidth = 51;
            this.timingDataView.RowTemplate.Height = 24;
            this.timingDataView.Size = new System.Drawing.Size(984, 208);
            this.timingDataView.TabIndex = 51;
            // 
            // timingBindingSource
            // 
            this.timingBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Timing);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // noOfHoursDataGridViewTextBoxColumn
            // 
            this.noOfHoursDataGridViewTextBoxColumn.DataPropertyName = "NoOfHours";
            this.noOfHoursDataGridViewTextBoxColumn.HeaderText = "NoOfHours";
            this.noOfHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfHoursDataGridViewTextBoxColumn.Name = "noOfHoursDataGridViewTextBoxColumn";
            // 
            // timingNameDataGridViewTextBoxColumn
            // 
            this.timingNameDataGridViewTextBoxColumn.DataPropertyName = "TimingName";
            this.timingNameDataGridViewTextBoxColumn.HeaderText = "TimingName";
            this.timingNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timingNameDataGridViewTextBoxColumn.Name = "timingNameDataGridViewTextBoxColumn";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(861, 229);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 44);
            this.btnImport.TabIndex = 52;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateTimingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.timingDataView);
            this.Controls.Add(this.txtTimingName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTiming);
            this.Controls.Add(this.txtNoOfHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTimingUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.timingDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimingName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateTiming;
        private System.Windows.Forms.TextBox txtNoOfHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView timingDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
