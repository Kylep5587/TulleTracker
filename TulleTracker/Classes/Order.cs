using KPRestoration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TulleTracker.Classes
{
    class Order
    {
        DatabaseHelper db = new DatabaseHelper();

        private string orderID;
        private string orderStatus;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private decimal total;
        private int itemCount;

        public string OrderID { get => orderID; set => orderID = value; }
        public string OrderStatus { get => orderStatus; set => orderStatus = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public decimal Total { get => total; set => total = value; }
        public int ItemCount { get => itemCount; set => itemCount = value; }


        /* Checks for existing order ID
        **********************************/
        private bool OrderIdExists(string id)
        {
            string retrievedID = null;
            string query = "SELECT orderID FROM TULLE_ORDERS WHERE orderID = @id LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.conn);
            cmd.Parameters.AddWithValue("@id", id);

            if (db.ExecuteCommand(cmd))
            {
                db.OpenConnection();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    retrievedID = dr["orderID"].ToString();

                db.CloseConnection();
                if (retrievedID == id)
                    return true;
                else
                    return false;
            }
            return false;
        }


        /* Inserts New Order
         *  Displays error/success message but returns bool for
         *   additional error handling at call location
        **********************************/
        public bool Add(string[,] itemData)
        {
            bool insertError = false;
            string orderDateSQL = Globals.DateToMySQLString(OrderDate);
            string deliveryDateSQL = Globals.DateToMySQLString(DeliveryDate);

            // SQL Parameters for query
            var orderParams = new Dictionary<string, string> {
                { "@orderID", OrderID },
                { "@orderDate", orderDateSQL },
                { "@orderStatus", OrderStatus },
                { "@deliveryDate", deliveryDateSQL },
                { "@total", Total.ToString() }
            };

            if (OrderIdExists(OrderID)) // Stop insert attempt if the order ID already exists
            {
                MessageBox.Show("An order with ID " + OrderID + " already exists. Please change the order ID or modify the existing order.", "Order Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Continue with insert
            {
                string query = "INSERT INTO TULLE_ORDERS VALUES (@orderID, @orderDate, @orderStatus, @deliveryDate, @total)";

                // Create SQL command for insert query
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                foreach (KeyValuePair<string, string> p in orderParams)
                    cmd.Parameters.AddWithValue(p.Key, p.Value);

                if (db.ExecuteCommand(cmd))
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        // SQL Parameters for query
                        var itemParams = new Dictionary<string, string> {
                        { "@color", itemData[i,0] },
                        { "@qty", itemData[i,1] },
                        { "@orderID", OrderID }
                    };

                    query = "INSERT INTO ORDER_ITEMS (orderID, itemQty, color) VALUES (@orderID, @qty, @color)";
                    MySqlCommand c = new MySqlCommand(query, db.conn);
                    foreach (KeyValuePair<string, string> p in itemParams)
                        c.Parameters.AddWithValue(p.Key, p.Value);

                        if (!db.ExecuteCommand(c))
                        {
                            insertError = true;
                        }
                    }

                    if (!insertError) // No errors adding items to the order
                    {
                        MessageBox.Show("Order #" + OrderID + " added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else // Error adding items to order but order added
                    {
                        MessageBox.Show("Failed to add items to order #" + OrderID + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else // Error inserting the order
                {
                    MessageBox.Show("Failed to add order #" + OrderID + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;
        }

        
    }
}
