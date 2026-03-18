namespace App.WinForms.Views
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
            this.tblproducts = new System.Windows.Forms.TableLayoutPanel();
            this.pnltoolbar = new System.Windows.Forms.Panel();
            this.pnltoolstrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.pnlfilters = new System.Windows.Forms.Panel();
            this.tblFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.comboBoxfilter2 = new System.Windows.Forms.ComboBox();
            this.textBoxfilter = new System.Windows.Forms.TextBox();
            this.comboBoxfilter1 = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproducts.SuspendLayout();
            this.pnltoolbar.SuspendLayout();
            this.pnltoolstrip.SuspendLayout();
            this.pnlfilters.SuspendLayout();
            this.tblFilters.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblproducts
            // 
            this.tblproducts.ColumnCount = 1;
            this.tblproducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblproducts.Controls.Add(this.pnltoolbar, 0, 0);
            this.tblproducts.Controls.Add(this.pnlfilters, 0, 1);
            this.tblproducts.Controls.Add(this.pnlGrid, 0, 2);
            this.tblproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblproducts.Location = new System.Drawing.Point(0, 0);
            this.tblproducts.Name = "tblproducts";
            this.tblproducts.Padding = new System.Windows.Forms.Padding(16);
            this.tblproducts.RowCount = 3;
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.Size = new System.Drawing.Size(790, 539);
            this.tblproducts.TabIndex = 0;
            // 
            // pnltoolbar
            // 
            this.pnltoolbar.BackColor = System.Drawing.Color.White;
            this.pnltoolbar.Controls.Add(this.pnltoolstrip);
            this.pnltoolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltoolbar.Location = new System.Drawing.Point(19, 19);
            this.pnltoolbar.Name = "pnltoolbar";
            this.pnltoolbar.Size = new System.Drawing.Size(752, 50);
            this.pnltoolbar.TabIndex = 0;
            // 
            // pnltoolstrip
            // 
            this.pnltoolstrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltoolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pnltoolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbView,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.Refresh});
            this.pnltoolstrip.Location = new System.Drawing.Point(0, 0);
            this.pnltoolstrip.Name = "pnltoolstrip";
            this.pnltoolstrip.Size = new System.Drawing.Size(752, 50);
            this.pnltoolstrip.TabIndex = 0;
            this.pnltoolstrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(74, 45);
            this.tsbAdd.Text = "Add";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(70, 45);
            this.tsbEdit.Text = "Edit";
            // 
            // tsbView
            // 
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(77, 45);
            this.tsbView.Text = "View";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(90, 45);
            this.tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // Refresh
            // 
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(98, 45);
            this.Refresh.Text = "Refresh";
            // 
            // pnlfilters
            // 
            this.pnlfilters.BackColor = System.Drawing.Color.White;
            this.pnlfilters.Controls.Add(this.tblFilters);
            this.pnlfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfilters.Location = new System.Drawing.Point(19, 75);
            this.pnlfilters.Name = "pnlfilters";
            this.pnlfilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlfilters.Size = new System.Drawing.Size(752, 78);
            this.pnlfilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            this.tblFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilters.BackColor = System.Drawing.Color.White;
            this.tblFilters.ColumnCount = 3;
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.Controls.Add(this.lblSearch, 0, 0);
            this.tblFilters.Controls.Add(this.lblCategory, 1, 0);
            this.tblFilters.Controls.Add(this.lblStockStatus, 2, 0);
            this.tblFilters.Controls.Add(this.comboBoxfilter2, 2, 1);
            this.tblFilters.Controls.Add(this.textBoxfilter, 0, 1);
            this.tblFilters.Controls.Add(this.comboBoxfilter1, 1, 1);
            this.tblFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilters.Location = new System.Drawing.Point(12, 10);
            this.tblFilters.Name = "tblFilters";
            this.tblFilters.RowCount = 2;
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.Size = new System.Drawing.Size(728, 58);
            this.tblFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(285, 29);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(294, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(212, 29);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.Location = new System.Drawing.Point(512, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(213, 29);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // comboBoxfilter2
            // 
            this.comboBoxfilter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxfilter2.FormattingEnabled = true;
            this.comboBoxfilter2.Location = new System.Drawing.Point(512, 32);
            this.comboBoxfilter2.Name = "comboBoxfilter2";
            this.comboBoxfilter2.Size = new System.Drawing.Size(213, 28);
            this.comboBoxfilter2.TabIndex = 5;
            // 
            // textBoxfilter
            // 
            this.textBoxfilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxfilter.Location = new System.Drawing.Point(3, 32);
            this.textBoxfilter.Name = "textBoxfilter";
            this.textBoxfilter.Size = new System.Drawing.Size(285, 26);
            this.textBoxfilter.TabIndex = 6;
            // 
            // comboBoxfilter1
            // 
            this.comboBoxfilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxfilter1.FormattingEnabled = true;
            this.comboBoxfilter1.Location = new System.Drawing.Point(294, 32);
            this.comboBoxfilter1.Name = "comboBoxfilter1";
            this.comboBoxfilter1.Size = new System.Drawing.Size(212, 28);
            this.comboBoxfilter1.TabIndex = 4;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(19, 159);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(752, 361);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColCategory,
            this.ColPrice,
            this.ColStock,
            this.ColStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(728, 337);
            this.dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 8;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColCategory
            // 
            this.ColCategory.HeaderText = "Category";
            this.ColCategory.MinimumWidth = 8;
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 8;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 8;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 8;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblproducts);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(790, 539);
            this.tblproducts.ResumeLayout(false);
            this.pnltoolbar.ResumeLayout(false);
            this.pnltoolbar.PerformLayout();
            this.pnltoolstrip.ResumeLayout(false);
            this.pnltoolstrip.PerformLayout();
            this.pnlfilters.ResumeLayout(false);
            this.tblFilters.ResumeLayout(false);
            this.tblFilters.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBoxfilter1;
        private System.Windows.Forms.ComboBox comboBoxfilter2;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.TextBox textBoxfilter;
    }
}
