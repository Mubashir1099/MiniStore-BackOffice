namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            numPrice = new NumericUpDown();
            numStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtID = new TextBox();
            flpBottom = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStock, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 4);
            tableLayoutPanel1.Controls.Add(lblID, 0, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(numPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(numStock, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(txtID, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 315);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(3, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(3, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 25);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(3, 250);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(203, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(594, 31);
            txtName.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(203, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(594, 33);
            cmbCategory.TabIndex = 1;
            // 
            // numPrice
            // 
            numPrice.Dock = DockStyle.Fill;
            numPrice.Location = new Point(203, 103);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(594, 31);
            numPrice.TabIndex = 2;
            // 
            // numStock
            // 
            numStock.Dock = DockStyle.Fill;
            numStock.Location = new Point(203, 153);
            numStock.Name = "numStock";
            numStock.Size = new Size(594, 31);
            numStock.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(203, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(594, 33);
            cmbStatus.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(203, 253);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(594, 31);
            txtID.TabIndex = 5;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(btnSave);
            flpBottom.Controls.Add(btnCancel);
            flpBottom.Dock = DockStyle.Bottom;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(0, 339);
            flpBottom.Name = "flpBottom";
            flpBottom.Size = new Size(800, 111);
            flpBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(685, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 35);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(567, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpBottom);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            FormClosing += ProductForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            flpBottom.ResumeLayout(false);
            flpBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown numPrice;
        private NumericUpDown numStock;
        private ComboBox cmbStatus;
        private TextBox txtID;
        private FlowLayoutPanel flpBottom;
        private Button btnCancel;
        private Button btnSave;
    }
}