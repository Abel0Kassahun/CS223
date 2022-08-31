using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            string path = "server=localhost;database=practice_database;uid=root;pwd=1125126624mysql;";//localhost or Local instance
            string query = $"insert into InventoryTable values (@number,@date,@inventoryNumber,@objectName,@count,@price,@paymentMethod,@preferredLanguages)";
            using (MySqlConnection con = new MySqlConnection(path))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@inventoryNumber", inventoryNumber);
                    cmd.Parameters.AddWithValue("@objectName", objectName);
                    cmd.Parameters.AddWithValue("@count", count);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@preferredLanguages", preferredLanguages);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Connected and Saved", "Success");
                        MessageBox.Show($"Product \"{objectName}\" has been added succesfully", "Success");
                    }
                }
                catch
                {
                    MessageBox.Show("Request Error");
                }

            }
        }


        public static List<InventoryModel> GetAllProduct()
        {
            string path = "server=localhost;database=practice_database;uid=root;pwd=1125126624mysql;";//localhost or Local instance
            string query = "select * from `InventoryTable`";
            using (MySqlConnection con = new MySqlConnection(path))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    var result = cmd.ExecuteReader();
                 
                    while (result.Read())
                    {
                        InventoryModel model = new InventoryModel();
                        model.number = result.GetInt32(result.GetOrdinal("number"));
                        model.date = result.GetDateTime(result.GetOrdinal("date"));
                        model.inventoryNumber = result.GetInt32(result.GetOrdinal("inventory_number"));
                        model.objectName = result.GetString(result.GetOrdinal("object_name"));
                        model.count = result.GetInt32(result.GetOrdinal("count"));
                        model.price = result.GetInt32(result.GetOrdinal("price"));
                        model.paymentMethod = result.GetString(result.GetOrdinal("paymentMethod"));
                        model.preferredLanguages = result.GetString(result.GetOrdinal("preferredLanguages"));

                        inv.Add(model);
                    }
                    result.Close();
                }
                catch
                {
                    MessageBox.Show("Request Failed", "Error");
                }
            }
            return inv;
        }
        public static List<InventoryModel> findOne(string name)
        {
            return inv.FindAll(p=>p.objectName==name);//returns a list
            //Find(p=>p.objectNAme==name); returns a single value
        }

    }
}

/*
 * 
 * var result =cmd.ExecuteReader();
 * List<InventoryModel>temp =new List<InventoryModel>();
 * while(result.Read()){
 *      InventoryModel inv =new InventoryModel();
 *      inv.objectName=result[name];
 *      temp.add(inv);
 * }
 * getAll= Select *(ExecuteReader()=returns a table set)
 * save=insert into (ExecuteNonQuery())
 * 
 */
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
