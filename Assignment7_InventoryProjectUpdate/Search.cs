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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (string.IsNullOrEmpty(textBox_search.Text))
            {
                MessageBox.Show("Search field can't be empty", "Error");
            }
            else
            {
                if (!(reg.IsMatch(textBox_search.Text)))
                {
                    errorProvider1.SetError(textBox_search, "Incorrect format (No Symbols or numbers " +
                        "and First letter must be capital)");
                }
                else
                {
                    var item = InventoryModel.findOne(textBox_search.Text);
                    if (item.Count==0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Searched product has not been found");
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = InventoryModel.findOne(textBox_search.Text);
                        //dataGridView1.DataSource=item;
                    }
                }
            }
        }
    }
}
