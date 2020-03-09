namespace TulleTracker.Pages
{
    partial class AddProduct
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
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbProductTitle = new System.Windows.Forms.TextBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.cbSalesChannel = new System.Windows.Forms.ComboBox();
            this.lblSalesChannel = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lblSalesCateory = new System.Windows.Forms.Label();
            this.lblFBATier = new System.Windows.Forms.Label();
            this.cbSalesCategory = new System.Windows.Forms.ComboBox();
            this.cbSizeTier = new System.Windows.Forms.ComboBox();
            this.tbFNSKU = new System.Windows.Forms.TextBox();
            this.lblFNSKU = new System.Windows.Forms.Label();
            this.lblASIN = new System.Windows.Forms.Label();
            this.tbASIN = new System.Windows.Forms.TextBox();
            this.lblProductParent = new System.Windows.Forms.Label();
            this.cbParentItem = new System.Windows.Forms.ComboBox();
            this.gbAmazon = new System.Windows.Forms.GroupBox();
            this.gbEbay = new System.Windows.Forms.GroupBox();
            this.tbEbayItemNumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblListingURL = new System.Windows.Forms.Label();
            this.tbEbayURL = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cbWeightUnit = new System.Windows.Forms.ComboBox();
            this.cbDimensionUnit = new System.Windows.Forms.ComboBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductStatus = new System.Windows.Forms.ComboBox();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.lblLaunchDate = new System.Windows.Forms.Label();
            this.dtpLaunchDate = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSKU = new System.Windows.Forms.Label();
            this.tbSKU = new System.Windows.Forms.TextBox();
            this.gbAmazon.SuspendLayout();
            this.gbEbay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(12, 53);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "Product Type:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(13, 205);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Parent",
            "Child"});
            this.cbProductType.Location = new System.Drawing.Point(176, 49);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(220, 21);
            this.cbProductType.TabIndex = 4;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(319, 604);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(326, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 29);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Add Product";
            // 
            // tbProductTitle
            // 
            this.tbProductTitle.Location = new System.Drawing.Point(176, 127);
            this.tbProductTitle.Name = "tbProductTitle";
            this.tbProductTitle.Size = new System.Drawing.Size(220, 20);
            this.tbProductTitle.TabIndex = 20;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(12, 131);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(30, 13);
            this.lblProductTitle.TabIndex = 19;
            this.lblProductTitle.Text = "Title:";
            // 
            // cbSalesChannel
            // 
            this.cbSalesChannel.FormattingEnabled = true;
            this.cbSalesChannel.Items.AddRange(new object[] {
            "Amazon",
            "eBay",
            "Both"});
            this.cbSalesChannel.Location = new System.Drawing.Point(176, 88);
            this.cbSalesChannel.Name = "cbSalesChannel";
            this.cbSalesChannel.Size = new System.Drawing.Size(220, 21);
            this.cbSalesChannel.TabIndex = 22;
            this.cbSalesChannel.SelectedIndexChanged += new System.EventHandler(this.cbSalesChannel_SelectedIndexChanged);
            // 
            // lblSalesChannel
            // 
            this.lblSalesChannel.AutoSize = true;
            this.lblSalesChannel.Location = new System.Drawing.Point(12, 92);
            this.lblSalesChannel.Name = "lblSalesChannel";
            this.lblSalesChannel.Size = new System.Drawing.Size(78, 13);
            this.lblSalesChannel.TabIndex = 21;
            this.lblSalesChannel.Text = "Sales Channel:";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Burgundy",
            "Fuchsia",
            "Gold",
            "Green",
            "Ivory",
            "Lavender",
            "Light Blue",
            "Light Pink",
            "Lime Green",
            "Magenta",
            "Navy Blue",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Silver",
            "Turquoise",
            "White",
            "Yellow"});
            this.cbColor.Location = new System.Drawing.Point(176, 201);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(220, 21);
            this.cbColor.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 424);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 455);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(333, 128);
            this.tbDescription.TabIndex = 26;
            this.tbDescription.Text = "";
            // 
            // lblSalesCateory
            // 
            this.lblSalesCateory.AutoSize = true;
            this.lblSalesCateory.Location = new System.Drawing.Point(10, 124);
            this.lblSalesCateory.Name = "lblSalesCateory";
            this.lblSalesCateory.Size = new System.Drawing.Size(81, 13);
            this.lblSalesCateory.TabIndex = 12;
            this.lblSalesCateory.Text = "Sales Category:";
            // 
            // lblFBATier
            // 
            this.lblFBATier.AutoSize = true;
            this.lblFBATier.Location = new System.Drawing.Point(9, 92);
            this.lblFBATier.Name = "lblFBATier";
            this.lblFBATier.Size = new System.Drawing.Size(74, 13);
            this.lblFBATier.TabIndex = 11;
            this.lblFBATier.Text = "FBA Size Tier:";
            // 
            // cbSalesCategory
            // 
            this.cbSalesCategory.FormattingEnabled = true;
            this.cbSalesCategory.Items.AddRange(new object[] {
            "Baby Products",
            "Camera and Photo",
            "Consumer Electronics",
            "Electronics Accessories",
            "Home & Garden",
            "Kitchen",
            "Office Products",
            "Outdoors",
            "Sports",
            "Tools & Home Improvement",
            "Toys & Games"});
            this.cbSalesCategory.Location = new System.Drawing.Point(173, 120);
            this.cbSalesCategory.Name = "cbSalesCategory";
            this.cbSalesCategory.Size = new System.Drawing.Size(173, 21);
            this.cbSalesCategory.TabIndex = 16;
            // 
            // cbSizeTier
            // 
            this.cbSizeTier.FormattingEnabled = true;
            this.cbSizeTier.Items.AddRange(new object[] {
            "Small standard-size",
            "Large standard-size",
            "Small oversize",
            "Medium oversize",
            "Large oversize"});
            this.cbSizeTier.Location = new System.Drawing.Point(173, 88);
            this.cbSizeTier.Name = "cbSizeTier";
            this.cbSizeTier.Size = new System.Drawing.Size(173, 21);
            this.cbSizeTier.TabIndex = 15;
            // 
            // tbFNSKU
            // 
            this.tbFNSKU.Location = new System.Drawing.Point(173, 56);
            this.tbFNSKU.Name = "tbFNSKU";
            this.tbFNSKU.Size = new System.Drawing.Size(173, 20);
            this.tbFNSKU.TabIndex = 8;
            // 
            // lblFNSKU
            // 
            this.lblFNSKU.AutoSize = true;
            this.lblFNSKU.Location = new System.Drawing.Point(9, 60);
            this.lblFNSKU.Name = "lblFNSKU";
            this.lblFNSKU.Size = new System.Drawing.Size(46, 13);
            this.lblFNSKU.TabIndex = 3;
            this.lblFNSKU.Text = "FNSKU:";
            // 
            // lblASIN
            // 
            this.lblASIN.AutoSize = true;
            this.lblASIN.Location = new System.Drawing.Point(9, 29);
            this.lblASIN.Name = "lblASIN";
            this.lblASIN.Size = new System.Drawing.Size(35, 13);
            this.lblASIN.TabIndex = 1;
            this.lblASIN.Text = "ASIN:";
            // 
            // tbASIN
            // 
            this.tbASIN.Location = new System.Drawing.Point(173, 25);
            this.tbASIN.Name = "tbASIN";
            this.tbASIN.Size = new System.Drawing.Size(173, 20);
            this.tbASIN.TabIndex = 7;
            // 
            // lblProductParent
            // 
            this.lblProductParent.AutoSize = true;
            this.lblProductParent.Location = new System.Drawing.Point(9, 156);
            this.lblProductParent.Name = "lblProductParent";
            this.lblProductParent.Size = new System.Drawing.Size(64, 13);
            this.lblProductParent.TabIndex = 0;
            this.lblProductParent.Text = "Parent Item:";
            // 
            // cbParentItem
            // 
            this.cbParentItem.FormattingEnabled = true;
            this.cbParentItem.Location = new System.Drawing.Point(173, 152);
            this.cbParentItem.Name = "cbParentItem";
            this.cbParentItem.Size = new System.Drawing.Size(173, 21);
            this.cbParentItem.TabIndex = 1;
            // 
            // gbAmazon
            // 
            this.gbAmazon.Controls.Add(this.cbParentItem);
            this.gbAmazon.Controls.Add(this.lblProductParent);
            this.gbAmazon.Controls.Add(this.tbASIN);
            this.gbAmazon.Controls.Add(this.lblASIN);
            this.gbAmazon.Controls.Add(this.lblFNSKU);
            this.gbAmazon.Controls.Add(this.tbFNSKU);
            this.gbAmazon.Controls.Add(this.cbSizeTier);
            this.gbAmazon.Controls.Add(this.cbSalesCategory);
            this.gbAmazon.Controls.Add(this.lblFBATier);
            this.gbAmazon.Controls.Add(this.lblSalesCateory);
            this.gbAmazon.Enabled = false;
            this.gbAmazon.Location = new System.Drawing.Point(427, 49);
            this.gbAmazon.Name = "gbAmazon";
            this.gbAmazon.Size = new System.Drawing.Size(358, 186);
            this.gbAmazon.TabIndex = 23;
            this.gbAmazon.TabStop = false;
            this.gbAmazon.Text = "Amazon Information";
            // 
            // gbEbay
            // 
            this.gbEbay.Controls.Add(this.tbEbayItemNumber);
            this.gbEbay.Controls.Add(this.lblItemNumber);
            this.gbEbay.Controls.Add(this.lblListingURL);
            this.gbEbay.Controls.Add(this.tbEbayURL);
            this.gbEbay.Enabled = false;
            this.gbEbay.Location = new System.Drawing.Point(427, 256);
            this.gbEbay.Name = "gbEbay";
            this.gbEbay.Size = new System.Drawing.Size(358, 99);
            this.gbEbay.TabIndex = 24;
            this.gbEbay.TabStop = false;
            this.gbEbay.Text = "eBay Information";
            // 
            // tbEbayItemNumber
            // 
            this.tbEbayItemNumber.Location = new System.Drawing.Point(173, 28);
            this.tbEbayItemNumber.Name = "tbEbayItemNumber";
            this.tbEbayItemNumber.Size = new System.Drawing.Size(173, 20);
            this.tbEbayItemNumber.TabIndex = 7;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(9, 32);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(70, 13);
            this.lblItemNumber.TabIndex = 1;
            this.lblItemNumber.Text = "Item Number:";
            // 
            // lblListingURL
            // 
            this.lblListingURL.AutoSize = true;
            this.lblListingURL.Location = new System.Drawing.Point(9, 66);
            this.lblListingURL.Name = "lblListingURL";
            this.lblListingURL.Size = new System.Drawing.Size(65, 13);
            this.lblListingURL.TabIndex = 3;
            this.lblListingURL.Text = "Listing URL:";
            // 
            // tbEbayURL
            // 
            this.tbEbayURL.Location = new System.Drawing.Point(173, 62);
            this.tbEbayURL.Name = "tbEbayURL";
            this.tbEbayURL.Size = new System.Drawing.Size(173, 20);
            this.tbEbayURL.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 604);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Location = new System.Drawing.Point(176, 240);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Size = new System.Drawing.Size(220, 20);
            this.tbSalePrice.TabIndex = 29;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(12, 244);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(58, 13);
            this.lblSalePrice.TabIndex = 28;
            this.lblSalePrice.Text = "Sale Price:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(176, 278);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(81, 20);
            this.tbWeight.TabIndex = 31;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 282);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 30;
            this.lblWeight.Text = "Weight:";
            // 
            // cbWeightUnit
            // 
            this.cbWeightUnit.FormattingEnabled = true;
            this.cbWeightUnit.Items.AddRange(new object[] {
            "lb",
            "oz",
            "g",
            "kg"});
            this.cbWeightUnit.Location = new System.Drawing.Point(282, 278);
            this.cbWeightUnit.Name = "cbWeightUnit";
            this.cbWeightUnit.Size = new System.Drawing.Size(114, 21);
            this.cbWeightUnit.TabIndex = 32;
            // 
            // cbDimensionUnit
            // 
            this.cbDimensionUnit.FormattingEnabled = true;
            this.cbDimensionUnit.Items.AddRange(new object[] {
            "in",
            "cm",
            "mm"});
            this.cbDimensionUnit.Location = new System.Drawing.Point(321, 317);
            this.cbDimensionUnit.Name = "cbDimensionUnit";
            this.cbDimensionUnit.Size = new System.Drawing.Size(75, 21);
            this.cbDimensionUnit.TabIndex = 35;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(12, 320);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(64, 13);
            this.lblDimensions.TabIndex = 33;
            this.lblDimensions.Text = "Dimensions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "x";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(176, 316);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(28, 20);
            this.tbLength.TabIndex = 34;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(229, 316);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(28, 20);
            this.tbWidth.TabIndex = 38;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(282, 317);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(28, 20);
            this.tbHeight.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "x";
            // 
            // cbProductStatus
            // 
            this.cbProductStatus.FormattingEnabled = true;
            this.cbProductStatus.Items.AddRange(new object[] {
            "Development",
            "Active",
            "Discontinued"});
            this.cbProductStatus.Location = new System.Drawing.Point(176, 353);
            this.cbProductStatus.Name = "cbProductStatus";
            this.cbProductStatus.Size = new System.Drawing.Size(220, 21);
            this.cbProductStatus.TabIndex = 42;
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Location = new System.Drawing.Point(12, 357);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(40, 13);
            this.lblProductStatus.TabIndex = 41;
            this.lblProductStatus.Text = "Status:";
            // 
            // lblLaunchDate
            // 
            this.lblLaunchDate.AutoSize = true;
            this.lblLaunchDate.Location = new System.Drawing.Point(13, 393);
            this.lblLaunchDate.Name = "lblLaunchDate";
            this.lblLaunchDate.Size = new System.Drawing.Size(72, 13);
            this.lblLaunchDate.TabIndex = 43;
            this.lblLaunchDate.Text = "Launch Date:";
            // 
            // dtpLaunchDate
            // 
            this.dtpLaunchDate.CustomFormat = "yyyy-MM-dd";
            this.dtpLaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLaunchDate.Location = new System.Drawing.Point(176, 393);
            this.dtpLaunchDate.Name = "dtpLaunchDate";
            this.dtpLaunchDate.Size = new System.Drawing.Size(220, 20);
            this.dtpLaunchDate.TabIndex = 44;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(12, 168);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(32, 13);
            this.lblSKU.TabIndex = 45;
            this.lblSKU.Text = "SKU:";
            // 
            // tbSKU
            // 
            this.tbSKU.Location = new System.Drawing.Point(176, 164);
            this.tbSKU.Name = "tbSKU";
            this.tbSKU.Size = new System.Drawing.Size(218, 20);
            this.tbSKU.TabIndex = 46;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 638);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.tbSKU);
            this.Controls.Add(this.dtpLaunchDate);
            this.Controls.Add(this.lblLaunchDate);
            this.Controls.Add(this.cbProductStatus);
            this.Controls.Add(this.lblProductStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDimensionUnit);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.cbWeightUnit);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbSalePrice);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbEbay);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.gbAmazon);
            this.Controls.Add(this.cbSalesChannel);
            this.Controls.Add(this.lblSalesChannel);
            this.Controls.Add(this.tbProductTitle);
            this.Controls.Add(this.lblProductTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProductType);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.gbAmazon.ResumeLayout(false);
            this.gbAmazon.PerformLayout();
            this.gbEbay.ResumeLayout(false);
            this.gbEbay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbProductTitle;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.ComboBox cbSalesChannel;
        private System.Windows.Forms.Label lblSalesChannel;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label lblSalesCateory;
        private System.Windows.Forms.Label lblFBATier;
        private System.Windows.Forms.ComboBox cbSalesCategory;
        private System.Windows.Forms.ComboBox cbSizeTier;
        private System.Windows.Forms.TextBox tbFNSKU;
        private System.Windows.Forms.Label lblFNSKU;
        private System.Windows.Forms.Label lblASIN;
        private System.Windows.Forms.TextBox tbASIN;
        private System.Windows.Forms.Label lblProductParent;
        private System.Windows.Forms.ComboBox cbParentItem;
        private System.Windows.Forms.GroupBox gbAmazon;
        private System.Windows.Forms.GroupBox gbEbay;
        private System.Windows.Forms.TextBox tbEbayItemNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblListingURL;
        private System.Windows.Forms.TextBox tbEbayURL;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ComboBox cbWeightUnit;
        private System.Windows.Forms.ComboBox cbDimensionUnit;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProductStatus;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Label lblLaunchDate;
        private System.Windows.Forms.DateTimePicker dtpLaunchDate;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox tbSKU;
    }
}