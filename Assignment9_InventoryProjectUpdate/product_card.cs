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
    public partial class product_card : UserControl
    {
        public product_card()
        {
            InitializeComponent();
        }
        private string _productName;

        public string Product
        {
            get { return _productName; }
            set { _productName = value; label1.Text = value; }
        }
        private string _count;

        public string Count
        {
            get { return _count; }
            set { _count = value; label2.Text = value; }
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; label3.Text = value; }
        }

        private Color _backColor;

        public Color ProductCardBackColor
        {
            get { return _backColor; }
            set { _backColor = value; this.BackColor = value; }
        }

        

    }
}
