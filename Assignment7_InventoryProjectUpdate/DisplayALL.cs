﻿using System;
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = InventoryModel.GetAllProduct();
        }
    }
}
