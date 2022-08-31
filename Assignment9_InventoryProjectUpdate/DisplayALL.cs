using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_InventoryProject
{
    public partial class DisplayALL : Form
    {
        public DisplayALL()
        {
            InitializeComponent();
        }

        private void DisplayALL_Load(object sender, EventArgs e)
        {
            foreach (var item in InventoryModel.GetAllProduct())
            {
                //flowLayoutPanel1.Controls.Clear();
                product_card p = new product_card();
                p.Product = item.objectName;
                p.Count = item.count.ToString();
                p.Price = item.price.ToString();
                p.Click += productCard_click;
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void productCard_click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Card Clicked");
        }
    }
}
