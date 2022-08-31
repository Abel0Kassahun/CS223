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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text))
            {
                MessageBox.Show("Username field is required", "Error");
            }
            else if (string.IsNullOrEmpty(textBox_password.Text))
            {
                MessageBox.Show("Password field is required", "Error");
            }
            else
            {
                Regex reg = new Regex(@"^[A-Z]{1}[a-z]+");
                if (!(reg.IsMatch(textBox_username.Text)))
                {
                    errorProvider1.SetError(textBox_username, "Incorrect username format");
                }
                else
                {
                    if (textBox_password.Text == "admin")
                    {
                        InventoryModel.GetAllProduct();
                        MainContaianer mc = new MainContaianer(textBox_username.Text);
                        this.Hide();
                        mc.Show();
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBox_password, "Incorrect password");
                    }
                }
            }

           
            
        }
    }
}
