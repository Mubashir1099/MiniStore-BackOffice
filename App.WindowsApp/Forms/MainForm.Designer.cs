namespace App.WindowsApp.Forms
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
            Pnlheader = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flpPictureBoxRight = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpPictureBoxLeft = new PictureBox();
            Pnlsidebar = new Panel();
            flpnavbar = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProduct = new Button();
            btnorder = new Button();
            btnreport = new Button();
            btnsync = new Button();
            btnlogs = new Button();
            btnsetting = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlcontent = new Panel();
            Pnlheader.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flpPictureBoxRight).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flpPictureBoxLeft).BeginInit();
            Pnlsidebar.SuspendLayout();
            flpnavbar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnlheader
            // 
            Pnlheader.Controls.Add(flowLayoutPanel2);
            Pnlheader.Controls.Add(flowLayoutPanel1);
            Pnlheader.Dock = DockStyle.Top;
            Pnlheader.Location = new Point(0, 0);
            Pnlheader.Margin = new Padding(3, 4, 3, 4);
            Pnlheader.Name = "Pnlheader";
            Pnlheader.Size = new Size(1374, 82);
            Pnlheader.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(flpPictureBoxRight);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(1216, 0);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(158, 82);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flpPictureBoxRight
            // 
            flpPictureBoxRight.Image = (Image)resources.GetObject("flpPictureBoxRight.Image");
            flpPictureBoxRight.Location = new Point(3, 4);
            flpPictureBoxRight.Margin = new Padding(3, 4, 3, 4);
            flpPictureBoxRight.Name = "flpPictureBoxRight";
            flpPictureBoxRight.Size = new Size(47, 61);
            flpPictureBoxRight.TabIndex = 0;
            flpPictureBoxRight.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flpPictureBoxLeft);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(184, 82);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flpPictureBoxLeft
            // 
            flpPictureBoxLeft.Image = (Image)resources.GetObject("flpPictureBoxLeft.Image");
            flpPictureBoxLeft.Location = new Point(3, 4);
            flpPictureBoxLeft.Margin = new Padding(3, 4, 3, 4);
            flpPictureBoxLeft.Name = "flpPictureBoxLeft";
            flpPictureBoxLeft.Size = new Size(67, 64);
            flpPictureBoxLeft.TabIndex = 0;
            flpPictureBoxLeft.TabStop = false;
            flpPictureBoxLeft.Click += pictureBox1_Click;
            // 
            // Pnlsidebar
            // 
            Pnlsidebar.Controls.Add(flpnavbar);
            Pnlsidebar.Location = new Point(1, 90);
            Pnlsidebar.Margin = new Padding(3, 4, 3, 4);
            Pnlsidebar.Name = "Pnlsidebar";
            Pnlsidebar.Size = new Size(222, 685);
            Pnlsidebar.TabIndex = 1;
            // 
            // flpnavbar
            // 
            flpnavbar.Controls.Add(btnDashboard);
            flpnavbar.Controls.Add(btnProduct);
            flpnavbar.Controls.Add(btnorder);
            flpnavbar.Controls.Add(btnreport);
            flpnavbar.Controls.Add(btnsync);
            flpnavbar.Controls.Add(btnlogs);
            flpnavbar.Controls.Add(btnsetting);
            flpnavbar.Dock = DockStyle.Fill;
            flpnavbar.FlowDirection = FlowDirection.TopDown;
            flpnavbar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpnavbar.Location = new Point(0, 0);
            flpnavbar.Margin = new Padding(3, 4, 3, 4);
            flpnavbar.Name = "flpnavbar";
            flpnavbar.Size = new Size(222, 685);
            flpnavbar.TabIndex = 0;
            flpnavbar.Paint += flpnavbar_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 4);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(216, 81);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseCompatibleTextRendering = true;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProduct
            // 
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 93);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(216, 81);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnorder
            // 
            btnorder.FlatAppearance.BorderSize = 0;
            btnorder.FlatStyle = FlatStyle.Flat;
            btnorder.Image = (Image)resources.GetObject("btnorder.Image");
            btnorder.ImageAlign = ContentAlignment.MiddleLeft;
            btnorder.Location = new Point(3, 182);
            btnorder.Margin = new Padding(3, 4, 3, 4);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(216, 81);
            btnorder.TabIndex = 2;
            btnorder.Text = "Orders";
            btnorder.TextAlign = ContentAlignment.MiddleLeft;
            btnorder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // btnreport
            // 
            btnreport.FlatAppearance.BorderSize = 0;
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Image = (Image)resources.GetObject("btnreport.Image");
            btnreport.ImageAlign = ContentAlignment.MiddleLeft;
            btnreport.Location = new Point(3, 271);
            btnreport.Margin = new Padding(3, 4, 3, 4);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(216, 81);
            btnreport.TabIndex = 3;
            btnreport.Text = "Report";
            btnreport.TextAlign = ContentAlignment.MiddleLeft;
            btnreport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreport.UseVisualStyleBackColor = true;
            // 
            // btnsync
            // 
            btnsync.FlatAppearance.BorderSize = 0;
            btnsync.FlatStyle = FlatStyle.Flat;
            btnsync.Image = (Image)resources.GetObject("btnsync.Image");
            btnsync.ImageAlign = ContentAlignment.MiddleLeft;
            btnsync.Location = new Point(3, 360);
            btnsync.Margin = new Padding(3, 4, 3, 4);
            btnsync.Name = "btnsync";
            btnsync.Size = new Size(216, 81);
            btnsync.TabIndex = 4;
            btnsync.Text = "Sync";
            btnsync.TextAlign = ContentAlignment.MiddleLeft;
            btnsync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsync.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            btnlogs.FlatAppearance.BorderSize = 0;
            btnlogs.FlatStyle = FlatStyle.Flat;
            btnlogs.Image = (Image)resources.GetObject("btnlogs.Image");
            btnlogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnlogs.Location = new Point(3, 449);
            btnlogs.Margin = new Padding(3, 4, 3, 4);
            btnlogs.Name = "btnlogs";
            btnlogs.Size = new Size(216, 81);
            btnlogs.TabIndex = 5;
            btnlogs.Text = "Logs";
            btnlogs.TextAlign = ContentAlignment.MiddleLeft;
            btnlogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlogs.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            btnsetting.FlatAppearance.BorderSize = 0;
            btnsetting.FlatStyle = FlatStyle.Flat;
            btnsetting.Image = (Image)resources.GetObject("btnsetting.Image");
            btnsetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnsetting.Location = new Point(3, 538);
            btnsetting.Margin = new Padding(3, 4, 3, 4);
            btnsetting.Name = "btnsetting";
            btnsetting.Size = new Size(216, 81);
            btnsetting.TabIndex = 6;
            btnsetting.Text = "Settings";
            btnsetting.TextAlign = ContentAlignment.MiddleLeft;
            btnsetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsetting.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 787);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1374, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.Text = "Ready";
            // 
            // pnlcontent
            // 
            pnlcontent.Location = new Point(220, 90);
            pnlcontent.Margin = new Padding(3, 4, 3, 4);
            pnlcontent.Name = "pnlcontent";
            pnlcontent.Size = new Size(1154, 685);
            pnlcontent.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 819);
            Controls.Add(pnlcontent);
            Controls.Add(statusStrip1);
            Controls.Add(Pnlsidebar);
            Controls.Add(Pnlheader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            Pnlheader.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flpPictureBoxRight).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flpPictureBoxLeft).EndInit();
            Pnlsidebar.ResumeLayout(false);
            flpnavbar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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