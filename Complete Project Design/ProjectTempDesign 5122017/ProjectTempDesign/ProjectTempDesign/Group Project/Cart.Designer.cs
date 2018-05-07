namespace Group_Project
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lblNameofShopper = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxApplied = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblBillPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTopWingman = new System.Windows.Forms.Label();
            this.picWings = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThankYou
            // 
            this.lblThankYou.Location = new System.Drawing.Point(64, 57);
            this.lblThankYou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(188, 49);
            this.lblThankYou.TabIndex = 0;
            this.lblThankYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThankYou.Click += new System.EventHandler(this.lblThankYou_Click);
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(88, 70);
            this.lblShoppingCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(124, 20);
            this.lblShoppingCart.TabIndex = 1;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // lblNameofShopper
            // 
            this.lblNameofShopper.AutoSize = true;
            this.lblNameofShopper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameofShopper.Location = new System.Drawing.Point(194, 141);
            this.lblNameofShopper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameofShopper.Name = "lblNameofShopper";
            this.lblNameofShopper.Size = new System.Drawing.Size(0, 17);
            this.lblNameofShopper.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 141);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "NAME:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(52, 177);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "SUBTOTAL:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(194, 177);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 17);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "label1";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(52, 209);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(39, 17);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "TAX:";
            // 
            // lblTaxApplied
            // 
            this.lblTaxApplied.AutoSize = true;
            this.lblTaxApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxApplied.Location = new System.Drawing.Point(194, 209);
            this.lblTaxApplied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxApplied.Name = "lblTaxApplied";
            this.lblTaxApplied.Size = new System.Drawing.Size(46, 17);
            this.lblTaxApplied.TabIndex = 8;
            this.lblTaxApplied.Text = "label1";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(51, 242);
            this.lblBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(117, 20);
            this.lblBill.TabIndex = 9;
            this.lblBill.Text = "TOTAL OWED:";
            // 
            // lblBillPrice
            // 
            this.lblBillPrice.AutoSize = true;
            this.lblBillPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPrice.Location = new System.Drawing.Point(194, 245);
            this.lblBillPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillPrice.Name = "lblBillPrice";
            this.lblBillPrice.Size = new System.Drawing.Size(46, 17);
            this.lblBillPrice.TabIndex = 10;
            this.lblBillPrice.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(215, 300);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 25);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.lblTopWingman);
            this.pnlTop.Controls.Add(this.picWings);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(319, 54);
            this.pnlTop.TabIndex = 12;
            // 
            // lblTopWingman
            // 
            this.lblTopWingman.AutoSize = true;
            this.lblTopWingman.BackColor = System.Drawing.Color.Transparent;
            this.lblTopWingman.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopWingman.Location = new System.Drawing.Point(72, 18);
            this.lblTopWingman.Name = "lblTopWingman";
            this.lblTopWingman.Size = new System.Drawing.Size(235, 21);
            this.lblTopWingman.TabIndex = 13;
            this.lblTopWingman.Text = "Wingman Clothing Co.";
            // 
            // picWings
            // 
            this.picWings.Image = ((System.Drawing.Image)(resources.GetObject("picWings.Image")));
            this.picWings.Location = new System.Drawing.Point(3, 1);
            this.picWings.Name = "picWings";
            this.picWings.Size = new System.Drawing.Size(63, 50);
            this.picWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWings.TabIndex = 0;
            this.picWings.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(319, 345);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBillPrice);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblTaxApplied);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameofShopper);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.lblThankYou);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Label lblNameofShopper;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxApplied;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblBillPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTopWingman;
        private System.Windows.Forms.PictureBox picWings;
    }
}