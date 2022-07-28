using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            InventoryModel inventory = new InventoryModel();
           
            //these will check if the textboxes are empty or not
            if (string.IsNullOrEmpty(txtBox_number.Text))
            {
                MessageBox.Show("Number field is required", "Error");

            }
            else if (string.IsNullOrEmpty(txtBox_inventoryNumber.Text))
            {
                MessageBox.Show("Inventory Number field is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtBox_objectName.Text))
            {
                MessageBox.Show("Object Name is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtBox_count.Text))
            {
                MessageBox.Show("Count field is required", "Error");
            }
            else if (string.IsNullOrEmpty(txtBox_price.Text))
            {
                MessageBox.Show("Price field is required", "Error");
            }
            //this else statement will check for invalid content from the textboxes 
            else
            {
                Regex[] reg = new Regex[3];
                reg[0] = new Regex(@"^[0-9]+$");
                reg[1] = new Regex(@"^[A-Z]{1}[a-z]+$");
                reg[2] = new Regex(@"[0-9]+[.][0-9]+$");

                if (!(reg[0].IsMatch(txtBox_number.Text))){
                    errorProvider1.SetError(txtBox_number, "Anything other than numbers are not allowed in this field");
                }

                else if (!(reg[0].IsMatch(txtBox_inventoryNumber.Text))){
                    errorProvider1.SetError(txtBox_inventoryNumber, "Anything other than numbers are not allowed in this field");
                }
                //for object name field
                else if (!(reg[1].IsMatch(txtBox_objectName.Text)))
                {
                    errorProvider1.SetError(txtBox_objectName, "Incorrect format");
                }
                //for count field 
                else if (!(reg[0].IsMatch(txtBox_count.Text))){
                    errorProvider1.SetError(txtBox_count, "Anything other than numbers are not allowed in this field");
                }
                //for price field
                else if ((!(reg[0].IsMatch(txtBox_price.Text)))&&(!(reg[2].IsMatch(txtBox_price.Text)))){
                    errorProvider1.SetError(txtBox_price, "Anything other than a price value are not allowed in this field");
                }
               
                else
                {
                    errorProvider1.Clear();

                    inventory.objectName = txtBox_objectName.Text;
                    inventory.number = int.Parse(txtBox_number.Text);
                    inventory.date = dateTimePicker1.Value;
                    inventory.inventoryNumber = int.Parse(txtBox_inventoryNumber.Text);
                    inventory.count = int.Parse(txtBox_count.Text);
                    inventory.price = double.Parse(txtBox_price.Text);

                    inventory.save();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = InventoryModel.GetAllProduct();

                    MessageBox.Show($"Product \"{txtBox_objectName.Text}\" has been added succesfully", "Success");
                }


            }




        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
