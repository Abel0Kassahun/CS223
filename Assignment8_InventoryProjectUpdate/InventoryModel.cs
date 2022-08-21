using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Assignment4_InventoryProject
{
    class InventoryModel
    {
        static List<InventoryModel> inv = new List<InventoryModel>();

        public int number { get; set; }
        public DateTime date { get; set; }
        public int inventoryNumber { get; set; }
        public String objectName { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public string paymentMethod { get; set; }
        public string preferredLanguages { get; set; }
 
        public void save()
        {
            inv.Add(this);
        }
        public static List<InventoryModel> GetAllProduct()
        {
            return inv;
        }
        public static List<InventoryModel> findOne(string name)
        {
            return inv.FindAll(p=>p.objectName==name);//returns a list
            //Find(p=>p.objectNAme==name); returns a single value
        }
    }
}
//InventoryModel inv=new InventoryModel{};
/*
 * var item=InventoryModel.findOne(txtbox_search.Text);
 * if(item==null){}
*/
/*
 1. create custom component(product card)
    
 2. define property
 3. Dynamically create product card

 */