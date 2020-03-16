using KPRestoration;
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
    public partial class TulleOrder : Form
    {
        int currentLblPointY;
        int currentInputPointY;
        int currentAddBtnY;
        int itemOrderQty;

        public TulleOrder()
        {
            InitializeComponent();
            currentLblPointY = 70;
            currentInputPointY = 66;
            currentAddBtnY = 100;
            itemOrderQty = 1;
            PopulateColors(cbColor0);
            PopulateOrderStatus(cbOrderStatus);
            cbOrderStatus.SelectedIndex = 0;
        }


        private void SetOrderItemQty(ref int itemOrderQty)
        {
            itemOrderQty++;
        }

        /* Add Color Options to ComboBox
         *  Converts to more readable format
        **********************************/
        private void PopulateColors(ComboBox cb)
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


        private void PopulateOrderStatus (ComboBox cb)
        {
            foreach (var item in Enum.GetValues(typeof(Globals.OrderStatus)))
            {
                cb.Items.Add(item);
            }
        }

        /* Used to calulate the coordinates for next item input fields
        **********************************/
        private void CalculateNewCoordinates(ref int currentLblPointY, ref int currentInputPointY, ref int currentAddBtnY)
        {
            currentInputPointY += 34;
            currentLblPointY += 34;
            currentAddBtnY += 34;
        }


        /* Add new item input fields
        **********************************/
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            CalculateNewCoordinates(ref currentLblPointY, ref currentInputPointY, ref currentAddBtnY);

            try
            {
                // Location of original order item fields
                int qtyLblPointX = 548;
                int qtyPointX = 603;

                int colorLblPointX = 341;
                int colorPointX = 392;

                string cbColorInputName = "cbColor" + itemOrderQty;
                string tbQty = "tbQty" + itemOrderQty;
                SetOrderItemQty(ref itemOrderQty);

                this.Controls.Remove(btnAddItem);
                // New "Color:" Label
                Label color = new Label()
                {
                    Text = "Color:",
                    Location = new Point(colorLblPointX, currentLblPointY)
                };
                this.Controls.Add(color);

                // New Color ComboBox
                ComboBox colors = new ComboBox()
                {
                    Name = cbColorInputName,
                    Location = new Point(colorPointX, currentInputPointY)
                };
                PopulateColors(colors);
                colors.Width = 134;
                this.Controls.Add(colors);

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
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

        }


        /* Adds the order to the database
        **********************************/
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order o = new Order()
            {
                OrderID = tbOrderID.Text,
                OrderDate = Convert.ToDateTime(dtpOrderDate.Value),
                OrderStatus = cbOrderStatus.Text,
                DeliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value),
                Total = Convert.ToDecimal(tbTotal.Text),
                ItemCount = itemOrderQty
            };

            // Store item information in array
            string[,] itemData = new string[itemOrderQty,2];
            for (int i = 0; i < itemOrderQty; i++)
            {
                itemData[i,0] = ((ComboBox)this.Controls["cbColor" + i]).Text;         // Get color 
                itemData[i,1] = ((TextBox)this.Controls["tbQty" + i]).Text;            // Get Quantity
            }

            // Add the order information to database and close add order form if order successfully added
            if (o.Add(itemData))
            {
                this.Close();
            }
        }
    }
}
