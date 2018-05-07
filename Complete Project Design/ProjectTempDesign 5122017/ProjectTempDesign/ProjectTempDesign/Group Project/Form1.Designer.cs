namespace Group_Project
{
    partial class FrmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntro));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.pnlLoginLogo = new System.Windows.Forms.Panel();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblrighthandman = new System.Windows.Forms.Label();
            this.picWings = new System.Windows.Forms.PictureBox();
            this.lblLoginLabel = new System.Windows.Forms.Label();
            this.pnlLoginLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(124, 57);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembers.Location = new System.Drawing.Point(148, 178);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(79, 30);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Text = "Member";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuests.Location = new System.Drawing.Point(145, 234);
            this.btnGuests.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(82, 30);
            this.btnGuests.TabIndex = 2;
            this.btnGuests.Text = "Guest";
            this.btnGuests.UseVisualStyleBackColor = false;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // pnlLoginLogo
            // 
            this.pnlLoginLogo.BackColor = System.Drawing.Color.White;
            this.pnlLoginLogo.Controls.Add(this.lblMen);
            this.pnlLoginLogo.Controls.Add(this.lblrighthandman);
            this.pnlLoginLogo.Controls.Add(this.picWings);
            this.pnlLoginLogo.Controls.Add(this.lblLoginLabel);
            this.pnlLoginLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLogo.Name = "pnlLoginLogo";
            this.pnlLoginLogo.Size = new System.Drawing.Size(365, 61);
            this.pnlLoginLogo.TabIndex = 3;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMen.Location = new System.Drawing.Point(192, 37);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(58, 15);
            this.lblMen.TabIndex = 3;
            this.lblMen.Text = "For men";
            this.lblMen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrighthandman
            // 
            this.lblrighthandman.AutoSize = true;
            this.lblrighthandman.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrighthandman.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblrighthandman.Location = new System.Drawing.Point(12, 37);
            this.lblrighthandman.Name = "lblrighthandman";
            this.lblrighthandman.Size = new System.Drawing.Size(152, 15);
            this.lblrighthandman.TabIndex = 2;
            this.lblrighthandman.Text = "\"Your right hand man\"";
            // 
            // picWings
            // 
            this.picWings.BackColor = System.Drawing.Color.Transparent;
            this.picWings.Image = ((System.Drawing.Image)(resources.GetObject("picWings.Image")));
            this.picWings.Location = new System.Drawing.Point(262, 3);
            this.picWings.Name = "picWings";
            this.picWings.Size = new System.Drawing.Size(100, 50);
            this.picWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWings.TabIndex = 1;
            this.picWings.TabStop = false;
            // 
            // lblLoginLabel
            // 
            this.lblLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginLabel.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoginLabel.Location = new System.Drawing.Point(3, 9);
            this.lblLoginLabel.Name = "lblLoginLabel";
            this.lblLoginLabel.Size = new System.Drawing.Size(260, 28);
            this.lblLoginLabel.TabIndex = 0;
            this.lblLoginLabel.Text = "Wingman Clothing Co.";
            this.lblLoginLabel.Click += new System.EventHandler(this.lblLoginLabel_Click);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 362);
            this.Controls.Add(this.pnlLoginLogo);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIntro";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLoginLogo.ResumeLayout(false);
            this.pnlLoginLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Panel pnlLoginLogo;
        private System.Windows.Forms.Label lblLoginLabel;
        private System.Windows.Forms.PictureBox picWings;
        private System.Windows.Forms.Label lblrighthandman;
        private System.Windows.Forms.Label lblMen;
    }
}

