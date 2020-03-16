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

namespace TulleTracker.Pages
{
    public partial class TulleOrder : Form
    {
        int currentLblPointY;
        int currentInputPointY;
        int currentAddBtnY;
        int i;

        public TulleOrder()
        {
            InitializeComponent();
            currentLblPointY = 70;
            currentInputPointY = 66;
            currentAddBtnY = 100;
            i = 0;
            PopulateColors(cbColor01);
        }


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
                        cb.Items.Add(item);
                        break;
                }
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

                string cbColorInputName = "cbColor" + i;
                string tbQty = "tbQty" + i;
                i++;

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
    }
}
