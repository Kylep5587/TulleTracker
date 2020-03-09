using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KPRestoration;
using MySql.Data.MySqlClient;

namespace TulleTracker.Classes
{
    class Product
    {
        static DatabaseHelper db = new DatabaseHelper();
        private string defaultDGVQuery = "SELECT sku, salePrice, title, color, salesChannel, productType, launchDate, productStatus, id FROM Products ORDER BY launchDate";

        // Members
        private int id;
        private string title;
        private string productType;
        private int parentID;
        private string salesChannel;
        private string description;
        private string color;
        private decimal weight;
        private string weightUnit;
        private int packageQuantity;
        private string imageURL;
        private string asin;
        private string fnsku;
        private string sku;
        private string sizeTier;
        private string salesCategory;
        private string ebayItemID;
        private string ebayURL;
        private decimal salePrice;
        private string dimensions;
        private string dimensionUnit;
        private string status;
        private DateTime launchDate;
        private DateTime discontinueDate;

        // Getters and Setters 
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string ProductType { get => productType; set => productType = value; }
        public int ParentID { get => parentID; set => parentID = value; }
        public string SalesChannel { get => salesChannel; set => salesChannel = value; }
        public string Description { get => description; set => description = value; }
        public string Color { get => color; set => color = value; }
        public int PackageQuantity { get => packageQuantity; set => packageQuantity = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string Asin { get => asin; set => asin = value; }
        public string Fnsku { get => fnsku; set => fnsku = value; }
        public string Sku { get => sku; set => sku = value; }
        public string SizeTier { get => sizeTier; set => sizeTier = value; }
        public string SalesCategory { get => salesCategory; set => salesCategory = value; }
        public string EbayItemID { get => ebayItemID; set => ebayItemID = value; }
        public string EbayURL { get => ebayURL; set => ebayURL = value; }
        public decimal SalePrice { get => salePrice; set => salePrice = value; }
        public string Dimensions { get => dimensions; set => dimensions = value; }
        public string Status { get => status; set => status = value; }
        public DateTime LaunchDate { get => launchDate; set => launchDate = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public string DimensionUnit { get => dimensionUnit; set => dimensionUnit = value; }
        public string WeightUnit { get => weightUnit; set => weightUnit = value; }
        public DateTime DiscontinueDate { get => discontinueDate; set => discontinueDate = value; }



        /* Adds a new product entry
        **********************************/
        public static bool Add(Product np)
        {
            // Convert Date
            string mySQLDate = Globals.DateToMySQLString(np.LaunchDate);

            // SQL Parameters for query
            var productParams = new Dictionary<string, string> {
                { "@title", np.Title },
                { "@productType", np.ProductType },
                { "@parentID", np.ParentID.ToString() },
                { "@salesChannel", np.SalesChannel },
                { "@description", np.description },
                { "@color", np.Color },
                { "@weight", np.Weight.ToString() },
                { "@weightUnit", np.weightUnit },
                { "@packageQuantity", np.PackageQuantity.ToString() },
                { "@imageURL", np.ImageURL },
                { "@asin", np.Asin },
                { "@fnsku", np.Fnsku },
                { "@sku", np.Sku },
                { "@sizeTier", np.SizeTier },
                { "@salesCategory", np.SalesCategory },
                { "@ebayItemID", np.EbayItemID },
                { "@ebayURL", np.EbayURL },
                { "@salePrice", np.SalePrice.ToString() },
                { "@dimensions", np.Dimensions },
                { "@dimensionUnit", np.DimensionUnit},
                { "@productStatus", np.Status },
                { "@launchDate", mySQLDate }
            };

            string query = "INSERT INTO Products (title, productType, parentID, salesChannel, productDescription, color, weight, weightUnit, packageQuantity, imageURL, asin, fnsku, sku, sizeTier, salesCategory, ebayItemID, ebayURL, salePrice, dimensions, dimensionUnit, productStatus, launchDate) VALUES " +
                            "(@title, @productType, @parentID, @salesChannel, @description, @color, @weight, @weightUnit, @packageQuantity, @imageURL, @asin, @fnsku, @sku, @sizeTier, @salesCategory, @ebayItemID, @ebayURL, @salePrice, @dimensions, @dimensionUnit, @productStatus, @launchDate)";
            
            // Create SQL command for insert query
            MySqlCommand cmd = new MySqlCommand(query, db.conn);
            foreach (KeyValuePair<string, string> p in productParams)
                cmd.Parameters.AddWithValue(p.Key, p.Value);

            return db.ExecuteCommand(cmd); // Execute query

        }


        /* Populate Product DGV headers and rows
        **********************************/
        public void PopulateDGV(DataGridView dgv)
        {
            if (db.PopulateDGV(dgv, defaultDGVQuery))
            {
                dgv.Columns[0].HeaderText = "SKU";
                dgv.Columns[1].HeaderText = "Title";
                dgv.Columns[2].HeaderText = "Price";
                dgv.Columns[3].HeaderText = "Color";
                dgv.Columns[4].HeaderText = "Sales Channel";
                dgv.Columns[5].HeaderText = "Type";
                dgv.Columns[6].HeaderText = "Lauch Date";
                dgv.Columns[7].HeaderText = "Status";
                dgv.Columns[8].HeaderText = "ID";
            }
            else
            {
                MessageBox.Show("An error occured while populating the DGV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Selects all data for specific product
        **********************************/
        public Product GetProduct(int productID)
        {
            string query = "SELECT * FROM Products WHERE id = @id LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.conn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = productID;

            
            try
            {
                db.OpenConnection();
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    { //TODO: fix cannot convert from object to DBNull exception being triggered here
                        Product pI = new Product()
                        {
                            Id = Convert.ToInt32(r["id"]),
                            Title = r["title"].ToString(),
                            ProductType = r["productType"].ToString(),
                            ParentID = Convert.ToInt32(r["parentID"]),
                            SalesChannel = r["salesChannel"].ToString(),
                            Description = r["productDescription"].ToString(),
                            Color = r["color"].ToString(),
                            Weight = Convert.ToDecimal(r["weight"]),
                            WeightUnit = r["weightUnit"].ToString(),
                            PackageQuantity = Convert.ToInt32(r["packageQuantity"]),
                            ImageURL = r["imageURL"].ToString(),
                            Asin = r["asin"].ToString(),
                            Fnsku = r["fnsku"].ToString(),
                            Sku = r["sku"].ToString(),
                            SizeTier = r["sizeTier"].ToString(),
                            SalesCategory = r["salesCategory"].ToString(),
                            EbayItemID = r["ebayItemID"].ToString(),
                            EbayURL = r["ebayURL"].ToString(),
                            SalePrice = Convert.ToDecimal(r["salePrice"]),
                            Dimensions = r["dimensions"].ToString(),
                            DimensionUnit = r["dimensionUnit"].ToString(),
                            Status = r["productType"].ToString(),
                            LaunchDate = Convert.ToDateTime(r["launchDate"]),
                            DiscontinueDate = Convert.ToDateTime(r["discontinueDate"])
                        };
                        db.CloseConnection();
                        return pI;
                    }
                    else
                    {
                        db.CloseConnection();
                        MessageBox.Show("Error retrieving data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                db.CloseConnection();
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.CloseConnection();
            Product productInfo = new Product();
            return productInfo;

        }
        
    }
}
