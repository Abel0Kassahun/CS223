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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Application.Run(new Form1());
            InventoryModel inventory = new InventoryModel { 
                number=int.Parse(txtBox_number.Text),
                date=dateTimePicker1.Value,
                inventoryNumber=int.Parse(txtBox_inventoryNumber.Text),
                objectName=txtBox_objectName.Text,
                count=int.Parse(txtBox_count.Text),
                price=double.Parse(txtBox_price.Text)
            };
            inventory.save();
            MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully","Success");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
