namespace TulleTracker.Pages
{
    partial class ReceiveTulleOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.orderNumber = new System.Windows.Forms.TextBox();
            this.lblScannedOrders = new System.Windows.Forms.Label();
            this.tbScannedOrders = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(21, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scan a barcode to receive the order.";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(21, 61);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(81, 13);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Scanned Code:";
            // 
            // orderNumber
            // 
            this.orderNumber.Location = new System.Drawing.Point(118, 58);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(244, 20);
            this.orderNumber.TabIndex = 2;
            this.orderNumber.TextChanged += new System.EventHandler(this.orderNumber_TextChanged);
            // 
            // lblScannedOrders
            // 
            this.lblScannedOrders.AutoSize = true;
            this.lblScannedOrders.Location = new System.Drawing.Point(21, 101);
            this.lblScannedOrders.Name = "lblScannedOrders";
            this.lblScannedOrders.Size = new System.Drawing.Size(93, 13);
            this.lblScannedOrders.TabIndex = 3;
            this.lblScannedOrders.Text = "Scannned Orders:";
            // 
            // tbScannedOrders
            // 
            this.tbScannedOrders.Location = new System.Drawing.Point(24, 117);
            this.tbScannedOrders.Name = "tbScannedOrders";
            this.tbScannedOrders.Size = new System.Drawing.Size(338, 321);
            this.tbScannedOrders.TabIndex = 4;
            this.tbScannedOrders.Text = "";
            // 
            // ReceiveTulleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.tbScannedOrders);
            this.Controls.Add(this.lblScannedOrders);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReceiveTulleOrder";
            this.Text = "Order Receiving";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceiveTulleOrder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox orderNumber;
        private System.Windows.Forms.Label lblScannedOrders;
        private System.Windows.Forms.RichTextBox tbScannedOrders;
    }
}