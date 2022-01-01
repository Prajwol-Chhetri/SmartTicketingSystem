
namespace SmartTicketingSystem.Forms
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnVisitorTimings = new System.Windows.Forms.Button();
            this.btnVisitorCategories = new System.Windows.Forms.Button();
            this.btnAdminReport = new System.Windows.Forms.Button();
            this.btnAdminStaffs = new System.Windows.Forms.Button();
            this.btnAdminTickets = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
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
            this.btnSellTicket = new System.Windows.Forms.Button();
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
            this.panelLeft.Controls.Add(this.btnSellTicket);
            this.panelLeft.Controls.Add(this.btnVisitorTimings);
            this.panelLeft.Controls.Add(this.btnVisitorCategories);
            this.panelLeft.Controls.Add(this.btnAdminReport);
            this.panelLeft.Controls.Add(this.btnAdminStaffs);
            this.panelLeft.Controls.Add(this.btnAdminTickets);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnAdminDashboard);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // btnVisitorTimings
            // 
            this.btnVisitorTimings.FlatAppearance.BorderSize = 0;
            this.btnVisitorTimings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorTimings.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorTimings.ForeColor = System.Drawing.Color.White;
            this.btnVisitorTimings.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitorTimings.Image")));
            this.btnVisitorTimings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitorTimings.Location = new System.Drawing.Point(12, 338);
            this.btnVisitorTimings.Name = "btnVisitorTimings";
            this.btnVisitorTimings.Size = new System.Drawing.Size(194, 60);
            this.btnVisitorTimings.TabIndex = 9;
            this.btnVisitorTimings.Text = "  Timings";
            this.btnVisitorTimings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitorTimings.UseVisualStyleBackColor = true;
            this.btnVisitorTimings.Click += new System.EventHandler(this.btnVisitorTimings_Click);
            // 
            // btnVisitorCategories
            // 
            this.btnVisitorCategories.FlatAppearance.BorderSize = 0;
            this.btnVisitorCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorCategories.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorCategories.ForeColor = System.Drawing.Color.White;
            this.btnVisitorCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitorCategories.Image")));
            this.btnVisitorCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitorCategories.Location = new System.Drawing.Point(12, 274);
            this.btnVisitorCategories.Name = "btnVisitorCategories";
            this.btnVisitorCategories.Size = new System.Drawing.Size(194, 60);
            this.btnVisitorCategories.TabIndex = 8;
            this.btnVisitorCategories.Text = "  Categories";
            this.btnVisitorCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitorCategories.UseVisualStyleBackColor = true;
            this.btnVisitorCategories.Click += new System.EventHandler(this.btnVisitorCategories_Click);
            // 
            // btnAdminReport
            // 
            this.btnAdminReport.FlatAppearance.BorderSize = 0;
            this.btnAdminReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReport.ForeColor = System.Drawing.Color.White;
            this.btnAdminReport.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminReport.Image")));
            this.btnAdminReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReport.Location = new System.Drawing.Point(12, 460);
            this.btnAdminReport.Name = "btnAdminReport";
            this.btnAdminReport.Size = new System.Drawing.Size(194, 60);
            this.btnAdminReport.TabIndex = 7;
            this.btnAdminReport.Text = "  Report";
            this.btnAdminReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminReport.UseVisualStyleBackColor = true;
            this.btnAdminReport.Click += new System.EventHandler(this.btnAdminReport_Click);
            // 
            // btnAdminStaffs
            // 
            this.btnAdminStaffs.FlatAppearance.BorderSize = 0;
            this.btnAdminStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminStaffs.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminStaffs.ForeColor = System.Drawing.Color.White;
            this.btnAdminStaffs.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminStaffs.Image")));
            this.btnAdminStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminStaffs.Location = new System.Drawing.Point(12, 404);
            this.btnAdminStaffs.Name = "btnAdminStaffs";
            this.btnAdminStaffs.Size = new System.Drawing.Size(194, 60);
            this.btnAdminStaffs.TabIndex = 6;
            this.btnAdminStaffs.Text = "  Staffs";
            this.btnAdminStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminStaffs.UseVisualStyleBackColor = true;
            this.btnAdminStaffs.Click += new System.EventHandler(this.btnAdminStaffs_Click);
            // 
            // btnAdminTickets
            // 
            this.btnAdminTickets.FlatAppearance.BorderSize = 0;
            this.btnAdminTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTickets.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminTickets.ForeColor = System.Drawing.Color.White;
            this.btnAdminTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminTickets.Image")));
            this.btnAdminTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminTickets.Location = new System.Drawing.Point(12, 208);
            this.btnAdminTickets.Name = "btnAdminTickets";
            this.btnAdminTickets.Size = new System.Drawing.Size(194, 60);
            this.btnAdminTickets.TabIndex = 5;
            this.btnAdminTickets.Text = "  Tickets";
            this.btnAdminTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminTickets.UseVisualStyleBackColor = true;
            this.btnAdminTickets.Click += new System.EventHandler(this.btnAdminTickets_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 4;
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.FlatAppearance.BorderSize = 0;
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.btnAdminDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminDashboard.Image")));
            this.btnAdminDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDashboard.Location = new System.Drawing.Point(12, 142);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(194, 60);
            this.btnAdminDashboard.TabIndex = 4;
            this.btnAdminDashboard.Text = "   Dashboard";
            this.btnAdminDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
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
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Admin";
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
            // btnSellTicket
            // 
            this.btnSellTicket.FlatAppearance.BorderSize = 0;
            this.btnSellTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellTicket.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.ForeColor = System.Drawing.Color.White;
            this.btnSellTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnSellTicket.Image")));
            this.btnSellTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellTicket.Location = new System.Drawing.Point(12, 526);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(194, 60);
            this.btnSellTicket.TabIndex = 10;
            this.btnSellTicket.Text = "  Sell Ticket";
            this.btnSellTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // AdminDashboardForm
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
            this.Name = "AdminDashboardForm";
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
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAdminReport;
        private System.Windows.Forms.Button btnAdminStaffs;
        private System.Windows.Forms.Button btnAdminTickets;
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
        private System.Windows.Forms.Button btnVisitorTimings;
        private System.Windows.Forms.Button btnVisitorCategories;
        private System.Windows.Forms.Button btnSellTicket;
    }
}