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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();

            // Set default combobox selections
            cbProductType.SelectedIndex = 0;
            cbProductStatus.SelectedIndex = 0;
            cbWeightUnit.SelectedIndex = 1;
            cbSizeTier.SelectedIndex = 0;
            cbDimensionUnit.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //dtpLaunchDate.Format = DateTimePickerFormat.Custom;
            //dtpLaunchDate.CustomFormat = "yyyy-MM-dd";

            // Create new Product instance using entered values
            Product NewProduct = new Product
            {
                ProductType = cbProductType.Text,
                SalesChannel = cbSalesChannel.Text,
                Title = tbProductTitle.Text.ToString(),
                Color = cbColor.Text,
                Weight = Convert.ToDecimal(tbWeight.Text),
                WeightUnit = cbWeightUnit.Text,
                Description = tbDescription.Text.ToString(),
                Asin = tbASIN.Text.ToString(),
                Fnsku = tbFNSKU.Text.ToString(),
                Sku = tbSKU.Text.ToString(),
                SizeTier = cbSizeTier.Text,
                //ParentID = Convert.ToInt32(cbParentItem.Text), // Need to store Id of parent item but show the title
                EbayItemID = tbEbayItemNumber.Text,
                EbayURL = tbEbayURL.Text.ToString(),
                SalePrice = Convert.ToDecimal(tbSalePrice.Text.ToString()),
                Dimensions = tbLength.Text + "," + tbWidth.Text + "," + tbHeight.Text,
                DimensionUnit = cbDimensionUnit.Text,
                Status = cbProductStatus.Text.ToString(),
                LaunchDate = Convert.ToDateTime(dtpLaunchDate.Value)
            };

            // Add the product and display appropriate message
            if (Product.Add(NewProduct))
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occured while adding the product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Enables Sections Based on Selected Value
        **********************************/
        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( (cbProductType.Text == "Child") && (gbAmazon.Enabled == false) )
            {
                gbAmazon.Enabled = true;
            }
            else
            {
                gbAmazon.Enabled = false;
            }
        }


        /* Enables eBay wection when Sales Channel is set to "eBay" or "Both"
        **********************************/
        private void cbSalesChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSalesChannel.Text == "Both")
            {
                gbAmazon.Enabled = true;
                gbEbay.Enabled = true;
            }
            else if (cbSalesChannel.Text == "Amazon")
            {
                gbAmazon.Enabled = true;
                if (gbEbay.Enabled == true)
                {
                    gbEbay.Enabled = false;
                }
            }
            else if (cbSalesChannel.Text == "eBay")
            {
                gbEbay.Enabled = true;
                if (gbAmazon.Enabled == true)
                {
                    gbAmazon.Enabled = false;
                }
            }
        }
    }
}
