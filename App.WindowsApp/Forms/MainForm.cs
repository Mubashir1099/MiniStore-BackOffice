using App.WindowsApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Services;
namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        //private ICustomerService _service;
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();
        private readonly IProductService _productService = new InMemoryProductService();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(ICustomerService service)
        {
            InitializeComponent();
            service = service;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flpnavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlcontent.Controls.Clear();
            this.pnlcontent.Controls.Add(new DashboardView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.pnlcontent.Controls.Clear();
            this.pnlcontent.Controls.Add(new ProductView(new InMemoryProductService()));
            pnlcontent.Controls.Add(new ProductView(_productService));
        }

        private void btnorder_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {

            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }
            if (!pnlcontent.Controls.Contains(view))
            {
                pnlcontent.Controls.Clear();
                pnlcontent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
