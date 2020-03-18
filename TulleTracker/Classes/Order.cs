using KPRestoration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TulleTracker.Pages;

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


        /* Add Color Options to ComboBox
         *  Converts to more readable format
        **********************************/
        public void PopulateColors(ComboBox cb)
        {
            foreach (var item in Enum.GetValues(typeof(Globals.TulleColors)))
            {
                switch (item.ToString())
                {
                    case "LTPink":
                        cb.Items.Add("LT Pink");
                        break;
                    case "LTBlue":
                        cb.Items.Add("LT Blue");
                        break;
                    case "AppleGreen":
                        cb.Items.Add("Apple Green");
                        break;
                    case "NavyBlue":
                        cb.Items.Add("Navy Blue");
                        break;
                    default:
                        cb.Items.Add(item.ToString());
                        break;
                }
            }
        }


        /* Populates given combobox with enum values
        **********************************/
        public void PopulateOrderStatus(ComboBox cb)
        {
            foreach (var item in Enum.GetValues(typeof(Globals.OrderStatus)))
            {
                cb.Items.Add(item);
            }
        }


        /* Performs search of correct table and populates
         *  the correct DGV with results
         * *****************************/
        public void SearchOrders(DataGridView dgv, string searchQuery)
        {
            searchQuery = "%" + searchQuery + "%";                              // Add wildcards to the search query
            MySqlCommand cmd = new MySqlCommand("SEARCH_ORDERS", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;                      
            cmd.Parameters.AddWithValue("@searchQuery", searchQuery.Trim());
            db.ExecuteCommand(cmd);
            db.PopulateDGV(dgv, cmd);
        }


        public string ExecuteColorSearch(string color)
        {
            string colorQty = "0";
            MySqlCommand cmd = new MySqlCommand("GET_COLOR_QUANTITIES", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchColor", color);
            cmd.Parameters.Add("colorTotal", MySqlDbType.Int32).Direction = ParameterDirection.Output;
            db.OpenConnection();
            cmd.ExecuteNonQuery(); // Returning the number of entries and not sum of the item quantity
            if ((cmd.Parameters["colorTotal"].Value.ToString() != ""))
                colorQty = cmd.Parameters["colorTotal"].Value.ToString();
            else
                colorQty = "-";
            db.CloseConnection();
            return colorQty;
        }

        
        /* Determine how many cases of rolls are inbound
        **********************************/
        public string[] CalculateCases(int rolls)
        {
            string[] returnNumbers = new string[2];
            decimal neededRolls = 0;
            decimal caseCount = rolls / Globals.TulleCaseSize; // Want to return something like "0.529" if performing "36 / 68"

            if (rolls % Globals.TulleCaseSize != 0)
            {
                neededRolls = Math.Ceiling(Globals.TulleCaseSize * caseCount);
            }

            returnNumbers[0] = caseCount.ToString();
            returnNumbers[1] = neededRolls.ToString();

            return returnNumbers;
        }

    }
}
