namespace Group_Project
{
    partial class ManagerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerReport));
            this.lblManagerReport = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTanSuitInv = new System.Windows.Forms.Label();
            this.lblBlueSuitInv = new System.Windows.Forms.Label();
            this.lblLilacShirtInv = new System.Windows.Forms.Label();
            this.lblRev = new System.Windows.Forms.Label();
            this.lblSuits = new System.Windows.Forms.Label();
            this.lblSuitsRev = new System.Windows.Forms.Label();
            this.lblShirt = new System.Windows.Forms.Label();
            this.lblShirtRev = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblTieRev = new System.Windows.Forms.Label();
            this.lblShoes = new System.Windows.Forms.Label();
            this.lblShoeRev = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalRev = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblExpenseNum = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblProfitTotal = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.picTopWings = new System.Windows.Forms.PictureBox();
            this.picWingsMid = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWingsMid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagerReport
            // 
            this.lblManagerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerReport.Location = new System.Drawing.Point(170, 70);
            this.lblManagerReport.Name = "lblManagerReport";
            this.lblManagerReport.Size = new System.Drawing.Size(136, 23);
            this.lblManagerReport.TabIndex = 0;
            this.lblManagerReport.Text = "Manager Report";
            this.lblManagerReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventory
            // 
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(12, 70);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(100, 23);
            this.lblInventory.TabIndex = 1;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInventory.Click += new System.EventHandler(this.lblInventory_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(45, 93);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(100, 23);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Need To Order";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrder.UseWaitCursor = true;
            // 
            // lblTanSuitInv
            // 
            this.lblTanSuitInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanSuitInv.Location = new System.Drawing.Point(61, 116);
            this.lblTanSuitInv.Name = "lblTanSuitInv";
            this.lblTanSuitInv.Size = new System.Drawing.Size(100, 23);
            this.lblTanSuitInv.TabIndex = 3;
            this.lblTanSuitInv.Text = "Tan Suit (10)";
            this.lblTanSuitInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTanSuitInv.UseWaitCursor = true;
            // 
            // lblBlueSuitInv
            // 
            this.lblBlueSuitInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueSuitInv.Location = new System.Drawing.Point(61, 139);
            this.lblBlueSuitInv.Name = "lblBlueSuitInv";
            this.lblBlueSuitInv.Size = new System.Drawing.Size(100, 23);
            this.lblBlueSuitInv.TabIndex = 4;
            this.lblBlueSuitInv.Text = "Blue Suit (10)";
            this.lblBlueSuitInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBlueSuitInv.UseWaitCursor = true;
            // 
            // lblLilacShirtInv
            // 
            this.lblLilacShirtInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLilacShirtInv.Location = new System.Drawing.Point(61, 162);
            this.lblLilacShirtInv.Name = "lblLilacShirtInv";
            this.lblLilacShirtInv.Size = new System.Drawing.Size(115, 23);
            this.lblLilacShirtInv.TabIndex = 5;
            this.lblLilacShirtInv.Text = "Lilac Dress Shirt (20)";
            this.lblLilacShirtInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLilacShirtInv.UseWaitCursor = true;
            // 
            // lblRev
            // 
            this.lblRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRev.Location = new System.Drawing.Point(12, 196);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(100, 23);
            this.lblRev.TabIndex = 6;
            this.lblRev.Text = "Revenue";
            this.lblRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuits
            // 
            this.lblSuits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuits.Location = new System.Drawing.Point(45, 219);
            this.lblSuits.Name = "lblSuits";
            this.lblSuits.Size = new System.Drawing.Size(100, 23);
            this.lblSuits.TabIndex = 7;
            this.lblSuits.Text = "Suits";
            this.lblSuits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuits.UseWaitCursor = true;
            // 
            // lblSuitsRev
            // 
            this.lblSuitsRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuitsRev.Location = new System.Drawing.Point(61, 242);
            this.lblSuitsRev.Name = "lblSuitsRev";
            this.lblSuitsRev.Size = new System.Drawing.Size(100, 23);
            this.lblSuitsRev.TabIndex = 8;
            this.lblSuitsRev.Text = "$12349.43";
            this.lblSuitsRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuitsRev.UseWaitCursor = true;
            // 
            // lblShirt
            // 
            this.lblShirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirt.Location = new System.Drawing.Point(45, 265);
            this.lblShirt.Name = "lblShirt";
            this.lblShirt.Size = new System.Drawing.Size(100, 23);
            this.lblShirt.TabIndex = 9;
            this.lblShirt.Text = "Dress Shirts";
            this.lblShirt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShirt.UseWaitCursor = true;
            // 
            // lblShirtRev
            // 
            this.lblShirtRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtRev.Location = new System.Drawing.Point(61, 288);
            this.lblShirtRev.Name = "lblShirtRev";
            this.lblShirtRev.Size = new System.Drawing.Size(100, 23);
            this.lblShirtRev.TabIndex = 10;
            this.lblShirtRev.Text = "$6248.90";
            this.lblShirtRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShirtRev.UseWaitCursor = true;
            // 
            // lblTies
            // 
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(45, 311);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(100, 23);
            this.lblTies.TabIndex = 11;
            this.lblTies.Text = "Ties";
            this.lblTies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTies.UseWaitCursor = true;
            // 
            // lblTieRev
            // 
            this.lblTieRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieRev.Location = new System.Drawing.Point(61, 334);
            this.lblTieRev.Name = "lblTieRev";
            this.lblTieRev.Size = new System.Drawing.Size(100, 23);
            this.lblTieRev.TabIndex = 12;
            this.lblTieRev.Text = "$2278.44";
            this.lblTieRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieRev.UseWaitCursor = true;
            // 
            // lblShoes
            // 
            this.lblShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoes.Location = new System.Drawing.Point(45, 357);
            this.lblShoes.Name = "lblShoes";
            this.lblShoes.Size = new System.Drawing.Size(100, 23);
            this.lblShoes.TabIndex = 13;
            this.lblShoes.Text = "Dress Shoes";
            this.lblShoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShoes.UseWaitCursor = true;
            // 
            // lblShoeRev
            // 
            this.lblShoeRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoeRev.Location = new System.Drawing.Point(61, 380);
            this.lblShoeRev.Name = "lblShoeRev";
            this.lblShoeRev.Size = new System.Drawing.Size(100, 23);
            this.lblShoeRev.TabIndex = 14;
            this.lblShoeRev.Text = "$8743.27";
            this.lblShoeRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShoeRev.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(45, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.UseWaitCursor = true;
            // 
            // lblTotalRev
            // 
            this.lblTotalRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRev.Location = new System.Drawing.Point(61, 426);
            this.lblTotalRev.Name = "lblTotalRev";
            this.lblTotalRev.Size = new System.Drawing.Size(100, 23);
            this.lblTotalRev.TabIndex = 16;
            this.lblTotalRev.Text = "$29,620.04";
            this.lblTotalRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalRev.UseWaitCursor = true;
            // 
            // lblExpenses
            // 
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(12, 449);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(100, 23);
            this.lblExpenses.TabIndex = 17;
            this.lblExpenses.Text = "Expenses";
            this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpenseNum
            // 
            this.lblExpenseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseNum.Location = new System.Drawing.Point(61, 472);
            this.lblExpenseNum.Name = "lblExpenseNum";
            this.lblExpenseNum.Size = new System.Drawing.Size(100, 23);
            this.lblExpenseNum.TabIndex = 18;
            this.lblExpenseNum.Text = "$9623.86";
            this.lblExpenseNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpenseNum.UseWaitCursor = true;
            // 
            // lblProfit
            // 
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(12, 505);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(100, 23);
            this.lblProfit.TabIndex = 19;
            this.lblProfit.Text = "Profit";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitTotal
            // 
            this.lblProfitTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitTotal.Location = new System.Drawing.Point(61, 528);
            this.lblProfitTotal.Name = "lblProfitTotal";
            this.lblProfitTotal.Size = new System.Drawing.Size(100, 23);
            this.lblProfitTotal.TabIndex = 20;
            this.lblProfitTotal.Text = "$18367.13";
            this.lblProfitTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProfitTotal.UseWaitCursor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.lblTopTitle);
            this.pnlTop.Controls.Add(this.picTopWings);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(484, 67);
            this.pnlTop.TabIndex = 21;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Lucida Handwriting", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.Location = new System.Drawing.Point(109, 19);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(329, 29);
            this.lblTopTitle.TabIndex = 1;
            this.lblTopTitle.Text = "Wingman Clothing Co.";
            // 
            // picTopWings
            // 
            this.picTopWings.Image = ((System.Drawing.Image)(resources.GetObject("picTopWings.Image")));
            this.picTopWings.Location = new System.Drawing.Point(3, 3);
            this.picTopWings.Name = "picTopWings";
            this.picTopWings.Size = new System.Drawing.Size(100, 61);
            this.picTopWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopWings.TabIndex = 0;
            this.picTopWings.TabStop = false;
            // 
            // picWingsMid
            // 
            this.picWingsMid.Image = ((System.Drawing.Image)(resources.GetObject("picWingsMid.Image")));
            this.picWingsMid.Location = new System.Drawing.Point(167, 235);
            this.picWingsMid.Name = "picWingsMid";
            this.picWingsMid.Size = new System.Drawing.Size(300, 214);
            this.picWingsMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picWingsMid.TabIndex = 22;
            this.picWingsMid.TabStop = false;
            // 
            // ManagerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(484, 586);
            this.Controls.Add(this.picWingsMid);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblProfitTotal);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblExpenseNum);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblTotalRev);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblShoeRev);
            this.Controls.Add(this.lblShoes);
            this.Controls.Add(this.lblTieRev);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblShirtRev);
            this.Controls.Add(this.lblShirt);
            this.Controls.Add(this.lblSuitsRev);
            this.Controls.Add(this.lblSuits);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.lblLilacShirtInv);
            this.Controls.Add(this.lblBlueSuitInv);
            this.Controls.Add(this.lblTanSuitInv);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblManagerReport);
            this.Name = "ManagerReport";
            this.Text = "ManagerReport";
            this.Load += new System.EventHandler(this.ManagerReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWingsMid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerReport;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblTanSuitInv;
        private System.Windows.Forms.Label lblBlueSuitInv;
        private System.Windows.Forms.Label lblLilacShirtInv;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.Label lblSuits;
        private System.Windows.Forms.Label lblSuitsRev;
        private System.Windows.Forms.Label lblShirt;
        private System.Windows.Forms.Label lblShirtRev;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblTieRev;
        private System.Windows.Forms.Label lblShoes;
        private System.Windows.Forms.Label lblShoeRev;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalRev;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblExpenseNum;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblProfitTotal;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.PictureBox picTopWings;
        private System.Windows.Forms.PictureBox picWingsMid;
    }
}