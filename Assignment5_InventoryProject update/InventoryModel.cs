using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

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
 
        public void save()
        {
            inv.Add(this);
        }
        public static List<InventoryModel> GetAllProduct()
        {
            return inv;
        }
    }
}
//InventoryModel inv=new InventoryModel{};
