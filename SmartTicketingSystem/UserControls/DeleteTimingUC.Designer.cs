
namespace SmartTicketingSystem.UserControls
{
    partial class DeleteTimingUC
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
            this.timingDataView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteTiming = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTimingName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timingDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.timingDataView.TabIndex = 52;
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
            // timingBindingSource
            // 
            this.timingBindingSource.DataSource = typeof(SmartTicketingSystem.Classes.Timing);
            // 
            // btnDeleteTiming
            // 
            this.btnDeleteTiming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTiming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteTiming.FlatAppearance.BorderSize = 0;
            this.btnDeleteTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTiming.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTiming.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTiming.Location = new System.Drawing.Point(264, 477);
            this.btnDeleteTiming.Name = "btnDeleteTiming";
            this.btnDeleteTiming.Size = new System.Drawing.Size(434, 44);
            this.btnDeleteTiming.TabIndex = 56;
            this.btnDeleteTiming.Text = "Delete Timing";
            this.btnDeleteTiming.UseVisualStyleBackColor = false;
            this.btnDeleteTiming.Click += new System.EventHandler(this.btnDeleteTiming_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(260, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Timing Name:";
            // 
            // comboTimingName
            // 
            this.comboTimingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTimingName.FormattingEnabled = true;
            this.comboTimingName.Location = new System.Drawing.Point(264, 390);
            this.comboTimingName.Name = "comboTimingName";
            this.comboTimingName.Size = new System.Drawing.Size(434, 31);
            this.comboTimingName.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(324, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Select Timing to Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteTimingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDeleteTiming);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTimingName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timingDataView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteTimingUC";
            this.Size = new System.Drawing.Size(984, 580);
            ((System.ComponentModel.ISupportInitialize)(this.timingDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timingDataView;
        private System.Windows.Forms.Button btnDeleteTiming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTimingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timingBindingSource;
    }
}
