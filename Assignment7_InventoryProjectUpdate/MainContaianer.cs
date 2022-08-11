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
    public partial class MainContaianer : Form
    {
        String username;        
        public MainContaianer(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            //if(ActiveMdiChild!=null)
            //{
            //    ActiveMdiChild.Close();
            //}
            Form1 form = new Form1(username);
            form.MdiParent=this;
            form.Show();
        }

        private void displayProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            DisplayALL da = new DisplayALL();
            da.MdiParent = this;
            da.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }
    }
}
