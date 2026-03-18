namespace App.WindowsApp.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            tblproducts = new TableLayoutPanel();
            pnltoolbar = new Panel();
            pnltoolstrip = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Refresh = new ToolStripButton();
            pnlfilters = new Panel();
            tblFilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            cmbStockStatus = new ComboBox();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            tblproducts.SuspendLayout();
            pnltoolbar.SuspendLayout();
            pnltoolstrip.SuspendLayout();
            pnlfilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblproducts
            // 
            tblproducts.ColumnCount = 1;
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tblproducts.Controls.Add(pnltoolbar, 0, 0);
            tblproducts.Controls.Add(pnlfilters, 0, 1);
            tblproducts.Controls.Add(pnlGrid, 0, 2);
            tblproducts.Dock = DockStyle.Fill;
            tblproducts.Location = new Point(0, 0);
            tblproducts.Margin = new Padding(3, 4, 3, 4);
            tblproducts.Name = "tblproducts";
            tblproducts.Padding = new Padding(18, 20, 18, 20);
            tblproducts.RowCount = 3;
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblproducts.Size = new Size(878, 674);
            tblproducts.TabIndex = 0;
            // 
            // pnltoolbar
            // 
            pnltoolbar.BackColor = Color.White;
            pnltoolbar.Controls.Add(pnltoolstrip);
            pnltoolbar.Dock = DockStyle.Fill;
            pnltoolbar.Location = new Point(21, 24);
            pnltoolbar.Margin = new Padding(3, 4, 3, 4);
            pnltoolbar.Name = "pnltoolbar";
            pnltoolbar.Size = new Size(836, 62);
            pnltoolbar.TabIndex = 0;
            // 
            // pnltoolstrip
            // 
            pnltoolstrip.Dock = DockStyle.Fill;
            pnltoolstrip.ImageScalingSize = new Size(24, 24);
            pnltoolstrip.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, Refresh });
            pnltoolstrip.Location = new Point(0, 0);
            pnltoolstrip.Name = "pnltoolstrip";
            pnltoolstrip.Size = new Size(836, 62);
            pnltoolstrip.TabIndex = 0;
            pnltoolstrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(74, 57);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(70, 57);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.BackColor = Color.White;
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(77, 57);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(90, 57);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // Refresh
            // 
            Refresh.Image = (Image)resources.GetObject("Refresh.Image");
            Refresh.ImageTransparentColor = Color.Magenta;
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(98, 57);
            Refresh.Text = "Refresh";
            // 
            // pnlfilters
            // 
            pnlfilters.BackColor = Color.White;
            pnlfilters.Controls.Add(tblFilters);
            pnlfilters.Dock = DockStyle.Fill;
            pnlfilters.Location = new Point(21, 94);
            pnlfilters.Margin = new Padding(3, 4, 3, 4);
            pnlfilters.Name = "pnlfilters";
            pnlfilters.Padding = new Padding(13, 12, 13, 12);
            pnlfilters.Size = new Size(836, 97);
            pnlfilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.BackColor = Color.White;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Controls.Add(txtSearch, 0, 1);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(13, 12);
            tblFilters.Margin = new Padding(3, 4, 3, 4);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(810, 73);
            tblFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(318, 36);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(327, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(237, 36);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(570, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(237, 36);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(570, 40);
            cmbStockStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(237, 33);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 40);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(318, 31);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(327, 40);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(237, 33);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(21, 199);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(13, 15, 13, 15);
            pnlGrid.Size = new Size(836, 451);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColCategory, ColPrice, ColStock, ColStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(13, 15);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(810, 421);
            dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 8;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 8;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColCategory
            // 
            ColCategory.DataPropertyName = "Category";
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 8;
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 8;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 8;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 8;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblproducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductView";
            Size = new Size(878, 674);
            Load += ProductsView_Load;
            tblproducts.ResumeLayout(false);
            pnltoolbar.ResumeLayout(false);
            pnltoolbar.PerformLayout();
            pnltoolstrip.ResumeLayout(false);
            pnltoolstrip.PerformLayout();
            pnlfilters.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproducts;
        private System.Windows.Forms.Panel pnltoolbar;
        private System.Windows.Forms.ToolStrip pnltoolstrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.Panel pnlfilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
