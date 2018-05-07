namespace Group_Project
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.btnBackContact = new System.Windows.Forms.Button();
            this.picMadMen = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.picTopWings = new System.Windows.Forms.PictureBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMadMen)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackContact
            // 
            this.btnBackContact.Location = new System.Drawing.Point(326, 314);
            this.btnBackContact.Name = "btnBackContact";
            this.btnBackContact.Size = new System.Drawing.Size(75, 23);
            this.btnBackContact.TabIndex = 0;
            this.btnBackContact.Text = "Back";
            this.btnBackContact.UseVisualStyleBackColor = true;
            this.btnBackContact.Click += new System.EventHandler(this.btnBackContact_Click);
            // 
            // picMadMen
            // 
            this.picMadMen.Image = ((System.Drawing.Image)(resources.GetObject("picMadMen.Image")));
            this.picMadMen.Location = new System.Drawing.Point(63, 54);
            this.picMadMen.Name = "picMadMen";
            this.picMadMen.Size = new System.Drawing.Size(338, 195);
            this.picMadMen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMadMen.TabIndex = 1;
            this.picMadMen.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.lblTopTitle);
            this.pnlTop.Controls.Add(this.picTopWings);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 48);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTopTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(83, 9);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(270, 27);
            this.lblTopTitle.TabIndex = 1;
            this.lblTopTitle.Text = "Wingman Clothing Co.";
            // 
            // picTopWings
            // 
            this.picTopWings.Image = ((System.Drawing.Image)(resources.GetObject("picTopWings.Image")));
            this.picTopWings.Location = new System.Drawing.Point(12, 3);
            this.picTopWings.Name = "picTopWings";
            this.picTopWings.Size = new System.Drawing.Size(65, 45);
            this.picTopWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopWings.TabIndex = 0;
            this.picTopWings.TabStop = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(60, 271);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 292);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(191, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:         wingman@wmclothing.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(63, 314);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:       714-123-4567";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(63, 336);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(154, 26);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:    123 Wingman Way\r\n                  Fullerton, CA 92831\r\n";
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 405);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.picMadMen);
            this.Controls.Add(this.btnBackContact);
            this.Name = "frmContact";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.picMadMen)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackContact;
        private System.Windows.Forms.PictureBox picMadMen;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.PictureBox picTopWings;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
    }
}