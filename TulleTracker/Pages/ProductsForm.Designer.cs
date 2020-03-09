namespace TulleTracker.Pages
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scProducts = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblLaunchDate = new System.Windows.Forms.Label();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblSalesChannel = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.Label();
            this.salePrice = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.Label();
            this.productTitle = new System.Windows.Forms.Label();
            this.salesChannel = new System.Windows.Forms.Label();
            this.productStatus = new System.Windows.Forms.Label();
            this.dimensions = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.launchDate = new System.Windows.Forms.Label();
            this.fnsku = new System.Windows.Forms.Label();
            this.pkgQuantity = new System.Windows.Forms.Label();
            this.sizeTier = new System.Windows.Forms.Label();
            this.asin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFNSKU = new System.Windows.Forms.Label();
            this.lblASIN = new System.Windows.Forms.Label();
            this.lblSizeTier = new System.Windows.Forms.Label();
            this.lblPkgQty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scProducts)).BeginInit();
            this.scProducts.Panel1.SuspendLayout();
            this.scProducts.Panel2.SuspendLayout();
            this.scProducts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // scProducts
            // 
            this.scProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scProducts.Location = new System.Drawing.Point(0, 0);
            this.scProducts.Name = "scProducts";
            this.scProducts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scProducts.Panel1
            // 
            this.scProducts.Panel1.Controls.Add(this.menuStrip1);
            // 
            // scProducts.Panel2
            // 
            this.scProducts.Panel2.Controls.Add(this.btnEdit);
            this.scProducts.Panel2.Controls.Add(this.fnsku);
            this.scProducts.Panel2.Controls.Add(this.pkgQuantity);
            this.scProducts.Panel2.Controls.Add(this.sizeTier);
            this.scProducts.Panel2.Controls.Add(this.asin);
            this.scProducts.Panel2.Controls.Add(this.label5);
            this.scProducts.Panel2.Controls.Add(this.lblFNSKU);
            this.scProducts.Panel2.Controls.Add(this.lblASIN);
            this.scProducts.Panel2.Controls.Add(this.lblSizeTier);
            this.scProducts.Panel2.Controls.Add(this.lblPkgQty);
            this.scProducts.Panel2.Controls.Add(this.label10);
            this.scProducts.Panel2.Controls.Add(this.launchDate);
            this.scProducts.Panel2.Controls.Add(this.weight);
            this.scProducts.Panel2.Controls.Add(this.dimensions);
            this.scProducts.Panel2.Controls.Add(this.productStatus);
            this.scProducts.Panel2.Controls.Add(this.salesChannel);
            this.scProducts.Panel2.Controls.Add(this.productTitle);
            this.scProducts.Panel2.Controls.Add(this.sku);
            this.scProducts.Panel2.Controls.Add(this.color);
            this.scProducts.Panel2.Controls.Add(this.salePrice);
            this.scProducts.Panel2.Controls.Add(this.productType);
            this.scProducts.Panel2.Controls.Add(this.lblSKU);
            this.scProducts.Panel2.Controls.Add(this.lblLaunchDate);
            this.scProducts.Panel2.Controls.Add(this.lblProductStatus);
            this.scProducts.Panel2.Controls.Add(this.lblDimensions);
            this.scProducts.Panel2.Controls.Add(this.lblWeight);
            this.scProducts.Panel2.Controls.Add(this.lblSalePrice);
            this.scProducts.Panel2.Controls.Add(this.lblSalesChannel);
            this.scProducts.Panel2.Controls.Add(this.lblProductTitle);
            this.scProducts.Panel2.Controls.Add(this.lblColor);
            this.scProducts.Panel2.Controls.Add(this.lblProductType);
            this.scProducts.Panel2.Controls.Add(this.btnSearch);
            this.scProducts.Panel2.Controls.Add(this.lblSearch);
            this.scProducts.Panel2.Controls.Add(this.tbSearch);
            this.scProducts.Panel2.Controls.Add(this.lblProductInfo);
            this.scProducts.Panel2.Controls.Add(this.dgvProducts);
            this.scProducts.Size = new System.Drawing.Size(1307, 744);
            this.scProducts.SplitterDistance = 30;
            this.scProducts.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(756, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(404, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Products:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(510, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(229, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInfo.Location = new System.Drawing.Point(97, 13);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(191, 24);
            this.lblProductInfo.TabIndex = 1;
            this.lblProductInfo.Text = "Product Information";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(407, 47);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(874, 591);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(8, 166);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(32, 13);
            this.lblSKU.TabIndex = 71;
            this.lblSKU.Text = "SKU:";
            // 
            // lblLaunchDate
            // 
            this.lblLaunchDate.AutoSize = true;
            this.lblLaunchDate.Location = new System.Drawing.Point(9, 391);
            this.lblLaunchDate.Name = "lblLaunchDate";
            this.lblLaunchDate.Size = new System.Drawing.Size(72, 13);
            this.lblLaunchDate.TabIndex = 69;
            this.lblLaunchDate.Text = "Launch Date:";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Location = new System.Drawing.Point(8, 355);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(40, 13);
            this.lblProductStatus.TabIndex = 67;
            this.lblProductStatus.Text = "Status:";
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(8, 318);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(64, 13);
            this.lblDimensions.TabIndex = 60;
            this.lblDimensions.Text = "Dimensions:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(8, 280);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 57;
            this.lblWeight.Text = "Weight:";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(8, 242);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(58, 13);
            this.lblSalePrice.TabIndex = 55;
            this.lblSalePrice.Text = "Sale Price:";
            // 
            // lblSalesChannel
            // 
            this.lblSalesChannel.AutoSize = true;
            this.lblSalesChannel.Location = new System.Drawing.Point(8, 90);
            this.lblSalesChannel.Name = "lblSalesChannel";
            this.lblSalesChannel.Size = new System.Drawing.Size(78, 13);
            this.lblSalesChannel.TabIndex = 52;
            this.lblSalesChannel.Text = "Sales Channel:";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(8, 129);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(30, 13);
            this.lblProductTitle.TabIndex = 50;
            this.lblProductTitle.Text = "Title:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(9, 203);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 48;
            this.lblColor.Text = "Color:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(8, 51);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 47;
            this.lblProductType.Text = "Product Type:";
            // 
            // productType
            // 
            this.productType.AutoSize = true;
            this.productType.Location = new System.Drawing.Point(113, 51);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(35, 13);
            this.productType.TabIndex = 72;
            this.productType.Text = "label1";
            // 
            // salePrice
            // 
            this.salePrice.AutoSize = true;
            this.salePrice.Location = new System.Drawing.Point(113, 242);
            this.salePrice.Name = "salePrice";
            this.salePrice.Size = new System.Drawing.Size(35, 13);
            this.salePrice.TabIndex = 73;
            this.salePrice.Text = "label2";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(113, 203);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(35, 13);
            this.color.TabIndex = 74;
            this.color.Text = "label3";
            // 
            // sku
            // 
            this.sku.AutoSize = true;
            this.sku.Location = new System.Drawing.Point(113, 166);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(35, 13);
            this.sku.TabIndex = 75;
            this.sku.Text = "label4";
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Location = new System.Drawing.Point(113, 129);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(35, 13);
            this.productTitle.TabIndex = 76;
            this.productTitle.Text = "label5";
            // 
            // salesChannel
            // 
            this.salesChannel.AutoSize = true;
            this.salesChannel.Location = new System.Drawing.Point(113, 90);
            this.salesChannel.Name = "salesChannel";
            this.salesChannel.Size = new System.Drawing.Size(35, 13);
            this.salesChannel.TabIndex = 77;
            this.salesChannel.Text = "label6";
            // 
            // productStatus
            // 
            this.productStatus.AutoSize = true;
            this.productStatus.Location = new System.Drawing.Point(113, 355);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(35, 13);
            this.productStatus.TabIndex = 78;
            this.productStatus.Text = "label7";
            // 
            // dimensions
            // 
            this.dimensions.AutoSize = true;
            this.dimensions.Location = new System.Drawing.Point(113, 318);
            this.dimensions.Name = "dimensions";
            this.dimensions.Size = new System.Drawing.Size(35, 13);
            this.dimensions.TabIndex = 79;
            this.dimensions.Text = "label8";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(113, 280);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(35, 13);
            this.weight.TabIndex = 80;
            this.weight.Text = "label9";
            // 
            // launchDate
            // 
            this.launchDate.AutoSize = true;
            this.launchDate.Location = new System.Drawing.Point(113, 391);
            this.launchDate.Name = "launchDate";
            this.launchDate.Size = new System.Drawing.Size(41, 13);
            this.launchDate.TabIndex = 81;
            this.launchDate.Text = "label10";
            // 
            // fnsku
            // 
            this.fnsku.AutoSize = true;
            this.fnsku.Location = new System.Drawing.Point(114, 572);
            this.fnsku.Name = "fnsku";
            this.fnsku.Size = new System.Drawing.Size(41, 13);
            this.fnsku.TabIndex = 91;
            this.fnsku.Text = "label10";
            // 
            // pkgQuantity
            // 
            this.pkgQuantity.AutoSize = true;
            this.pkgQuantity.Location = new System.Drawing.Point(114, 461);
            this.pkgQuantity.Name = "pkgQuantity";
            this.pkgQuantity.Size = new System.Drawing.Size(35, 13);
            this.pkgQuantity.TabIndex = 90;
            this.pkgQuantity.Text = "label9";
            // 
            // sizeTier
            // 
            this.sizeTier.AutoSize = true;
            this.sizeTier.Location = new System.Drawing.Point(114, 499);
            this.sizeTier.Name = "sizeTier";
            this.sizeTier.Size = new System.Drawing.Size(35, 13);
            this.sizeTier.TabIndex = 89;
            this.sizeTier.Text = "label8";
            // 
            // asin
            // 
            this.asin.AutoSize = true;
            this.asin.Location = new System.Drawing.Point(114, 536);
            this.asin.Name = "asin";
            this.asin.Size = new System.Drawing.Size(35, 13);
            this.asin.TabIndex = 88;
            this.asin.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "label2";
            // 
            // lblFNSKU
            // 
            this.lblFNSKU.AutoSize = true;
            this.lblFNSKU.Location = new System.Drawing.Point(10, 572);
            this.lblFNSKU.Name = "lblFNSKU";
            this.lblFNSKU.Size = new System.Drawing.Size(46, 13);
            this.lblFNSKU.TabIndex = 86;
            this.lblFNSKU.Text = "FNSKU:";
            // 
            // lblASIN
            // 
            this.lblASIN.AutoSize = true;
            this.lblASIN.Location = new System.Drawing.Point(9, 536);
            this.lblASIN.Name = "lblASIN";
            this.lblASIN.Size = new System.Drawing.Size(35, 13);
            this.lblASIN.TabIndex = 85;
            this.lblASIN.Text = "ASIN:";
            // 
            // lblSizeTier
            // 
            this.lblSizeTier.AutoSize = true;
            this.lblSizeTier.Location = new System.Drawing.Point(9, 499);
            this.lblSizeTier.Name = "lblSizeTier";
            this.lblSizeTier.Size = new System.Drawing.Size(74, 13);
            this.lblSizeTier.TabIndex = 84;
            this.lblSizeTier.Text = "FBA Size Tier:";
            // 
            // lblPkgQty
            // 
            this.lblPkgQty.AutoSize = true;
            this.lblPkgQty.Location = new System.Drawing.Point(9, 461);
            this.lblPkgQty.Name = "lblPkgQty";
            this.lblPkgQty.Size = new System.Drawing.Size(95, 13);
            this.lblPkgQty.TabIndex = 83;
            this.lblPkgQty.Text = "Package Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Sale Price:";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(289, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 92;
            this.btnEdit.Text = "Edit Product";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 744);
            this.Controls.Add(this.scProducts);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.scProducts.Panel1.ResumeLayout(false);
            this.scProducts.Panel1.PerformLayout();
            this.scProducts.Panel2.ResumeLayout(false);
            this.scProducts.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProducts)).EndInit();
            this.scProducts.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblLaunchDate;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblSalesChannel;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label launchDate;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label dimensions;
        private System.Windows.Forms.Label productStatus;
        private System.Windows.Forms.Label salesChannel;
        private System.Windows.Forms.Label productTitle;
        private System.Windows.Forms.Label sku;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label salePrice;
        private System.Windows.Forms.Label productType;
        private System.Windows.Forms.Label fnsku;
        private System.Windows.Forms.Label pkgQuantity;
        private System.Windows.Forms.Label sizeTier;
        private System.Windows.Forms.Label asin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFNSKU;
        private System.Windows.Forms.Label lblASIN;
        private System.Windows.Forms.Label lblSizeTier;
        private System.Windows.Forms.Label lblPkgQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEdit;
    }
}