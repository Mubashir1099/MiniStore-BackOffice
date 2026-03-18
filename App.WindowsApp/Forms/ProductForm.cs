using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {

        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
        {
            InitializeComponent();

            numPrice.Maximum = Decimal.MaxValue;
            numStock.Maximum = Int32.MaxValue;

            cmbCategory.Items.Clear();
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbStatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txtID.Text = p.Id;
                txtName.Text = p.Name;
                cmbCategory.SelectedItem = p.category;
                cmbStatus.SelectedItem = p.status;
                numPrice.Value = p.Price;
                numStock.Value = p.Stock;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                newProduct.status = (ProductStatusEnum)cmbStatus.SelectedItem;
                newProduct.Price = numPrice.Value;
                newProduct.Stock = (int)numStock.Value;

                //_product =  _service.Add(newProduct);
                // txtID.Text = _product.Id;

                Product temp = _service.Add(newProduct);
                txtID.Text = temp?.Id ?? "";
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                _product.status = (ProductStatusEnum)cmbStatus.SelectedItem;
                _product.Price = numPrice.Value;
                _product.Stock = (int)numStock.Value;
                bool isUpdated = _service.Update(_product);
            }
            this.Close();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
