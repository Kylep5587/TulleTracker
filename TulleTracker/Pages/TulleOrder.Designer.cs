namespace TulleTracker.Pages
{
    partial class TulleOrder
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
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColor0 = new System.Windows.Forms.ComboBox();
            this.tbQty0 = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 71);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(12, 105);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(76, 13);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expected Delivery:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 208);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Order Total:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(466, 22);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(104, 20);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "Order Items";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(46, 22);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(115, 20);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Order Details";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(579, 100);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "New Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(548, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(341, 70);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color:";
            // 
            // cbColor0
            // 
            this.cbColor0.FormattingEnabled = true;
            this.cbColor0.Location = new System.Drawing.Point(392, 66);
            this.cbColor0.Name = "cbColor0";
            this.cbColor0.Size = new System.Drawing.Size(134, 21);
            this.cbColor0.TabIndex = 6;
            // 
            // tbQty0
            // 
            this.tbQty0.Location = new System.Drawing.Point(603, 66);
            this.tbQty0.Name = "tbQty0";
            this.tbQty0.Size = new System.Drawing.Size(51, 20);
            this.tbQty0.TabIndex = 7;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "yyyy-MM-dd";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(132, 67);
            this.dtpOrderDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(153, 20);
            this.dtpOrderDate.TabIndex = 1;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(132, 101);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(153, 20);
            this.tbOrderID.TabIndex = 2;
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Location = new System.Drawing.Point(132, 135);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(153, 21);
            this.cbOrderStatus.TabIndex = 3;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(132, 170);
            this.dtpDeliveryDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(153, 20);
            this.dtpDeliveryDate.TabIndex = 4;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(132, 204);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(153, 20);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.Text = "252.45";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(319, 306);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // TulleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 353);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.cbOrderStatus);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.tbQty0);
            this.Controls.Add(this.cbColor0);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderDate);
            this.Name = "TulleOrder";
            this.Text = "New Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TulleOrder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor0;
        private System.Windows.Forms.TextBox tbQty0;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnAddOrder;
    }
}