
namespace SmartTicketingSystem.Forms
{
    partial class StaffDashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboardForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnStaffReport = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnStaffDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.btnGetTicket);
            this.panelLeft.Controls.Add(this.btnSellTicket);
            this.panelLeft.Controls.Add(this.btnStaffReport);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnStaffDashboard);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.FlatAppearance.BorderSize = 0;
            this.btnGetTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTicket.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTicket.ForeColor = System.Drawing.Color.White;
            this.btnGetTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnGetTicket.Image")));
            this.btnGetTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetTicket.Location = new System.Drawing.Point(12, 340);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(194, 60);
            this.btnGetTicket.TabIndex = 12;
            this.btnGetTicket.Text = "  Get Ticket";
            this.btnGetTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetTicket.UseVisualStyleBackColor = true;
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.FlatAppearance.BorderSize = 0;
            this.btnSellTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellTicket.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.ForeColor = System.Drawing.Color.White;
            this.btnSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnSellTicket.Image")));
            this.btnSellTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellTicket.Location = new System.Drawing.Point(12, 208);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(194, 60);
            this.btnSellTicket.TabIndex = 11;
            this.btnSellTicket.Text = "  Sell Ticket";
            this.btnSellTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // btnStaffReport
            // 
            this.btnStaffReport.FlatAppearance.BorderSize = 0;
            this.btnStaffReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffReport.ForeColor = System.Drawing.Color.White;
            this.btnStaffReport.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffReport.Image")));
            this.btnStaffReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffReport.Location = new System.Drawing.Point(12, 274);
            this.btnStaffReport.Name = "btnStaffReport";
            this.btnStaffReport.Size = new System.Drawing.Size(194, 60);
            this.btnStaffReport.TabIndex = 7;
            this.btnStaffReport.Text = "  Report";
            this.btnStaffReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffReport.UseVisualStyleBackColor = true;
            this.btnStaffReport.Click += new System.EventHandler(this.btnAdminReport_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 4;
            // 
            // btnStaffDashboard
            // 
            this.btnStaffDashboard.FlatAppearance.BorderSize = 0;
            this.btnStaffDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDashboard.ForeColor = System.Drawing.Color.White;
            this.btnStaffDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffDashboard.Image")));
            this.btnStaffDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDashboard.Location = new System.Drawing.Point(12, 142);
            this.btnStaffDashboard.Name = "btnStaffDashboard";
            this.btnStaffDashboard.Size = new System.Drawing.Size(194, 60);
            this.btnStaffDashboard.TabIndex = 4;
            this.btnStaffDashboard.Text = "   Dashboard";
            this.btnStaffDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffDashboard.UseVisualStyleBackColor = true;
            this.btnStaffDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 140);
            this.panel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(174, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 45);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(72, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "N. R. C.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnShutDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(216, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 56);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "National Recreation Center, Kathmandu Nepal";
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.BackColor = System.Drawing.Color.White;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Location = new System.Drawing.Point(932, 0);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(52, 53);
            this.btnShutDown.TabIndex = 11;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.shutDownButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(216, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 84);
            this.panel4.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(874, 33);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(110, 23);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "HH: MM: SS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Staff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(131, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Role:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(192, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(148, 23);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Prajwol Chhetri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(216, 140);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(984, 580);
            this.panelControls.TabIndex = 4;
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDashboardForm";
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStaffDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStaffReport;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnGetTicket;
    }
}