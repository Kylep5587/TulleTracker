using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using MySql.Data.MySqlClient;
using System.Globalization;
using KPRestoration;
using TulleTracker.Classes;

namespace TulleTracker.Pages
{
    public partial class ProductsForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public ProductsForm()
        {
            InitializeComponent();
            Product np = new Product();
            np.PopulateDGV(dgvProducts);
        }



        /* Add Product Button Click
        **********************************/
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
        }

        private void cbSalesChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /* Populates Product Info when DGV Row clicked
        **********************************/
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string table = "products";
            int index = e.RowIndex;

            

            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[index];
                int entryIndex = Convert.ToInt32(selectedRow.Cells[8].Value);

                Product np = new Product();
                np = (Product)db.GetMySQLRow(entryIndex, table);

                productType.Text = np.ProductType;
                salesChannel.Text = np.SalesChannel;
            }
        }
    }
}
