using KPRestoration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TulleTracker.Classes;

namespace TulleTracker.Pages
{
    public partial class EditOrder : Form
    {
        Tulle owner;
        DatabaseHelper db = new DatabaseHelper();
        int currentLblPointY;
        int currentInputPointY;
        int currentAddBtnY;
        int item;
        int originalItemCount;

        // Location of original order item fields
        int qtyLblPointX = 556;
        int qtyPointX = 611;

        int colorLblPointX = 349;
        int colorPointX = 400;

        /* Used to calulate the coordinates for next item input fields
        **********************************/
        private void CalculateNewCoordinates(ref int currentLblPointY, ref int currentInputPointY, ref int currentAddBtnY)
        {
            currentInputPointY += 34;
            currentLblPointY += 34;
            currentAddBtnY += 34;
        }


        /* Updates the quantity of items in the order
        **********************************/
        private void IncreaseItemCount(ref int item)
        {
            item++;
        }


        /* Sets the original number of items in the order
        **********************************/
        private void SetOriginalItemCount(ref int originalItemCount, int itemCount)
        {
            originalItemCount = itemCount;
        }


        /* Default constructor
        **********************************/
        public EditOrder()
        {
            InitializeComponent();
        }


        /* Constructor with orderID
        **********************************/
        public EditOrder(string orderID, Tulle formOwner)
        {
            InitializeComponent();
            owner = formOwner;
            Order o = new Order();
            o.PopulateOrderStatus(cbOrderStatus);
            string query = "SELECT * FROM TULLE_ORDERS WHERE orderID = @orderID LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);

            // Set location of color fields
            currentLblPointY = 72;
            currentInputPointY = 68;
            currentAddBtnY = 102;

            int item = 0;
            int originalItemCount = 1;



            if (db.ExecuteCommand(cmd))
            {
                db.OpenConnection();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) // Set Values
                {
                    dtpOrderDate.Value = Convert.ToDateTime(dr["orderDate"]);
                    dtpDeliveryDate.Value = Convert.ToDateTime(dr["deliveryDate"]);
                    cbOrderStatus.SelectedIndex = cbOrderStatus.FindString(dr["orderStatus"].ToString());
                    tbOrderID.Text = dr["orderID"].ToString();
                    tbTotal.Text = dr["total"].ToString();
                }
                db.CloseConnection();

                // Get color data
                MySqlCommand colors = new MySqlCommand("SELECT * FROM ORDER_ITEMS WHERE orderID = @orderID", db.conn);
                colors.Parameters.AddWithValue("@orderID", orderID);
                if (db.ExecuteCommand(colors))
                {
                    
                    db.OpenConnection();
                    MySqlDataReader c = colors.ExecuteReader();
                    while (c.Read())
                    {
                        try
                        {
                            string cbColorInputName = "cbColor" + item;
                            string tbQty = "tbQty" + item;

                            if (item != 0)
                            {
                                CalculateNewCoordinates(ref currentLblPointY, ref currentInputPointY, ref currentAddBtnY);

                                this.Controls.Remove(btnAddItem);
                                // New "Color:" Label
                                Label color = new Label()
                                {
                                    Text = "Color:",
                                    Location = new Point(colorLblPointX, currentLblPointY)
                                };
                                this.Controls.Add(color);

                                // New Color ComboBox
                                ComboBox colorList = new ComboBox()
                                {
                                    Name = cbColorInputName,
                                    Location = new Point(colorPointX, currentInputPointY)
                                };
                                o.PopulateColors(colorList);
                                colorList.Width = 134;
                                colorList.SelectedValue = colorList.FindString(c["color"].ToString());
                                this.Controls.Add(colorList);

                                // New Quantity Label
                                Label lblQty = new Label()
                                {
                                    Text = "Quantity:",
                                    Location = new Point(qtyLblPointX, currentLblPointY)
                                };
                                this.Controls.Add(lblQty);

                                // New Quantity TextBox
                                TextBox qty = new TextBox()
                                {
                                    Name = tbQty,
                                    Location = new Point(qtyPointX, currentInputPointY),
                                    Text = c["itemQty"].ToString()
                                };
                                qty.Width = 51;
                                this.Controls.Add(qty);

                                // Move "New Item" Button
                                btnAddItem.Location = new Point(579, currentAddBtnY);
                                this.Controls.Add(btnAddItem);
                            }
                            else
                            {
                                o.PopulateColors(cbColor0);
                                cbColor0.SelectedIndex = cbColor0.FindString(c["color"].ToString());
                                tbQty0.Text = c["itemQty"].ToString();
                            }

                            IncreaseItemCount(ref item); // Increment item count
                            SetOriginalItemCount(ref originalItemCount, item);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                    db.CloseConnection();
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string cbColorInputName = "cbColor" + item;
            string tbQty = "tbQty" + item;
            Order o = new Order();

            CalculateNewCoordinates(ref currentLblPointY, ref currentInputPointY, ref currentAddBtnY);

            this.Controls.Remove(btnAddItem);
            // New "Color:" Label
            Label color = new Label()
            {
                Text = "Color:",
                Location = new Point(colorLblPointX, currentLblPointY)
            };
            this.Controls.Add(color);

            // New Color ComboBox
            ComboBox colorList = new ComboBox()
            {
                Name = cbColorInputName,
                Location = new Point(colorPointX, currentInputPointY)
            };
            o.PopulateColors(colorList);
            colorList.Width = 134;
            this.Controls.Add(colorList);

            // New Quantity Label
            Label lblQty = new Label()
            {
                Text = "Quantity:",
                Location = new Point(qtyLblPointX, currentLblPointY)
            };
            this.Controls.Add(lblQty);

            // New Quantity TextBox
            TextBox qty = new TextBox()
            {
                Name = tbQty,
                Location = new Point(qtyPointX, currentInputPointY)
            };
            qty.Width = 51;
            this.Controls.Add(qty);

            // Move "New Item" Button
            btnAddItem.Location = new Point(579, currentAddBtnY);
            this.Controls.Add(btnAddItem);

            IncreaseItemCount(ref item);
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            Order o = new Order()
            {
                OrderID = tbOrderID.Text,
                OrderDate = Convert.ToDateTime(dtpOrderDate.Value),
                OrderStatus = cbOrderStatus.Text,
                DeliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value),
                Total = Convert.ToDecimal(tbTotal.Text),
                ItemCount = item
            };

            // Store item information in array
            string[,] itemData = new string[item, 2];
            for (int i = 0; i < item; i++)
            {
                itemData[i, 0] = ((ComboBox)this.Controls["cbColor" + i]).Text;         // Get color 
                itemData[i, 1] = ((TextBox)this.Controls["tbQty" + i]).Text;            // Get Quantity
            }

            // Add the order information to database and close add order form if order successfully added
            if (o.Update(itemData, originalItemCount))
            {
                this.Close();
            }
        }

        /* Refreshes the DGV as form closes
        **********************************/
        private void EditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.RefreshOrderDGV();
        }
    }
}
