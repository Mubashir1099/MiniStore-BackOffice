using App.WinForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
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
            this.pnlcontent.Controls.Add(new ProductView());
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            
        }
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {

            var key = typeof(T);

            if (!_views.TryGetValue(key,out var view))
            {
                 view = factory();
                 view.Dock = DockStyle.Fill;
                _views[key] = view;
            }
            if(!pnlcontent.Controls.Contains(view))
            {
                pnlcontent.Controls.Clear();
                pnlcontent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
