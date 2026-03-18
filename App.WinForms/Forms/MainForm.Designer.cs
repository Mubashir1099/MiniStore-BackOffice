namespace App.WinForms.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPictureBoxRight = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.Pnlsidebar = new System.Windows.Forms.Panel();
            this.flpnavbar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnsync = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.Pnlheader.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flpPictureBoxRight)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flpPictureBoxLeft)).BeginInit();
            this.Pnlsidebar.SuspendLayout();
            this.flpnavbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlheader
            // 
            this.Pnlheader.Controls.Add(this.flowLayoutPanel2);
            this.Pnlheader.Controls.Add(this.flowLayoutPanel1);
            this.Pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlheader.Location = new System.Drawing.Point(0, 0);
            this.Pnlheader.Name = "Pnlheader";
            this.Pnlheader.Size = new System.Drawing.Size(1237, 66);
            this.Pnlheader.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flpPictureBoxRight);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1095, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 66);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flpPictureBoxRight
            // 
            this.flpPictureBoxRight.Image = ((System.Drawing.Image)(resources.GetObject("flpPictureBoxRight.Image")));
            this.flpPictureBoxRight.Location = new System.Drawing.Point(3, 3);
            this.flpPictureBoxRight.Name = "flpPictureBoxRight";
            this.flpPictureBoxRight.Size = new System.Drawing.Size(42, 49);
            this.flpPictureBoxRight.TabIndex = 0;
            this.flpPictureBoxRight.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flpPictureBoxLeft);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 66);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flpPictureBoxLeft
            // 
            this.flpPictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("flpPictureBoxLeft.Image")));
            this.flpPictureBoxLeft.Location = new System.Drawing.Point(3, 3);
            this.flpPictureBoxLeft.Name = "flpPictureBoxLeft";
            this.flpPictureBoxLeft.Size = new System.Drawing.Size(60, 51);
            this.flpPictureBoxLeft.TabIndex = 0;
            this.flpPictureBoxLeft.TabStop = false;
            this.flpPictureBoxLeft.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pnlsidebar
            // 
            this.Pnlsidebar.Controls.Add(this.flpnavbar);
            this.Pnlsidebar.Location = new System.Drawing.Point(1, 72);
            this.Pnlsidebar.Name = "Pnlsidebar";
            this.Pnlsidebar.Size = new System.Drawing.Size(200, 548);
            this.Pnlsidebar.TabIndex = 1;
            // 
            // flpnavbar
            // 
            this.flpnavbar.Controls.Add(this.btnDashboard);
            this.flpnavbar.Controls.Add(this.btnProduct);
            this.flpnavbar.Controls.Add(this.btnorder);
            this.flpnavbar.Controls.Add(this.btnreport);
            this.flpnavbar.Controls.Add(this.btnsync);
            this.flpnavbar.Controls.Add(this.btnlogs);
            this.flpnavbar.Controls.Add(this.btnsetting);
            this.flpnavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnavbar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnavbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpnavbar.Location = new System.Drawing.Point(0, 0);
            this.flpnavbar.Name = "flpnavbar";
            this.flpnavbar.Size = new System.Drawing.Size(200, 548);
            this.flpnavbar.TabIndex = 0;
            this.flpnavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnavbar_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 65);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseCompatibleTextRendering = true;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 74);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(194, 65);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnorder
            // 
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(3, 145);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(194, 65);
            this.btnorder.TabIndex = 2;
            this.btnorder.Text = "Orders";
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Image = ((System.Drawing.Image)(resources.GetObject("btnreport.Image")));
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(3, 216);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(194, 65);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "Report";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreport.UseVisualStyleBackColor = true;
            // 
            // btnsync
            // 
            this.btnsync.FlatAppearance.BorderSize = 0;
            this.btnsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsync.Image = ((System.Drawing.Image)(resources.GetObject("btnsync.Image")));
            this.btnsync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsync.Location = new System.Drawing.Point(3, 287);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(194, 65);
            this.btnsync.TabIndex = 4;
            this.btnsync.Text = "Sync";
            this.btnsync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsync.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            this.btnlogs.FlatAppearance.BorderSize = 0;
            this.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogs.Image = ((System.Drawing.Image)(resources.GetObject("btnlogs.Image")));
            this.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogs.Location = new System.Drawing.Point(3, 358);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(194, 65);
            this.btnlogs.TabIndex = 5;
            this.btnlogs.Text = "Logs";
            this.btnlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogs.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(3, 429);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(194, 65);
            this.btnsetting.TabIndex = 6;
            this.btnsetting.Text = "Settings";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.Text = "Ready";
            // 
            // pnlcontent
            // 
            this.pnlcontent.Location = new System.Drawing.Point(198, 72);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1039, 548);
            this.pnlcontent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 655);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Pnlsidebar);
            this.Controls.Add(this.Pnlheader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Pnlheader.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flpPictureBoxRight)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flpPictureBoxLeft)).EndInit();
            this.Pnlsidebar.ResumeLayout(false);
            this.flpnavbar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Panel Pnlsidebar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.FlowLayoutPanel flpnavbar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnsync;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.PictureBox flpPictureBoxLeft;
        private System.Windows.Forms.PictureBox flpPictureBoxRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}