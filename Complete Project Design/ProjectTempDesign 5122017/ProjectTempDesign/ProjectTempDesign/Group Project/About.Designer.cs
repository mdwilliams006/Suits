namespace Group_Project
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblWing2 = new System.Windows.Forms.Label();
            this.lblWingmanTitle = new System.Windows.Forms.Label();
            this.picTopWings = new System.Windows.Forms.PictureBox();
            this.picRatPack = new System.Windows.Forms.PictureBox();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.lblAboutCaption = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRatPack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(423, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 26);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.lblWing2);
            this.pnlTop.Controls.Add(this.lblWingmanTitle);
            this.pnlTop.Controls.Add(this.picTopWings);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(521, 71);
            this.pnlTop.TabIndex = 1;
            // 
            // lblWing2
            // 
            this.lblWing2.AutoSize = true;
            this.lblWing2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWing2.ForeColor = System.Drawing.Color.White;
            this.lblWing2.Location = new System.Drawing.Point(256, 45);
            this.lblWing2.Name = "lblWing2";
            this.lblWing2.Size = new System.Drawing.Size(233, 17);
            this.lblWing2.TabIndex = 2;
            this.lblWing2.Text = "\"Because every man needs one\"";
            // 
            // lblWingmanTitle
            // 
            this.lblWingmanTitle.AutoSize = true;
            this.lblWingmanTitle.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingmanTitle.ForeColor = System.Drawing.Color.White;
            this.lblWingmanTitle.Location = new System.Drawing.Point(109, 12);
            this.lblWingmanTitle.Name = "lblWingmanTitle";
            this.lblWingmanTitle.Size = new System.Drawing.Size(298, 28);
            this.lblWingmanTitle.TabIndex = 1;
            this.lblWingmanTitle.Text = "Wingman Clothing Co.";
            // 
            // picTopWings
            // 
            this.picTopWings.Image = ((System.Drawing.Image)(resources.GetObject("picTopWings.Image")));
            this.picTopWings.Location = new System.Drawing.Point(3, 12);
            this.picTopWings.Name = "picTopWings";
            this.picTopWings.Size = new System.Drawing.Size(100, 50);
            this.picTopWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopWings.TabIndex = 0;
            this.picTopWings.TabStop = false;
            // 
            // picRatPack
            // 
            this.picRatPack.Image = ((System.Drawing.Image)(resources.GetObject("picRatPack.Image")));
            this.picRatPack.Location = new System.Drawing.Point(85, 77);
            this.picRatPack.Name = "picRatPack";
            this.picRatPack.Size = new System.Drawing.Size(331, 205);
            this.picRatPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRatPack.TabIndex = 2;
            this.picRatPack.TabStop = false;
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(62, 301);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(66, 17);
            this.lblAboutUs.TabIndex = 3;
            this.lblAboutUs.Text = "About Us";
            // 
            // lblAboutCaption
            // 
            this.lblAboutCaption.AutoSize = true;
            this.lblAboutCaption.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutCaption.Location = new System.Drawing.Point(62, 318);
            this.lblAboutCaption.Name = "lblAboutCaption";
            this.lblAboutCaption.Size = new System.Drawing.Size(400, 75);
            this.lblAboutCaption.TabIndex = 4;
            this.lblAboutCaption.Text = resources.GetString("lblAboutCaption.Text");
            this.lblAboutCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(521, 455);
            this.Controls.Add(this.lblAboutCaption);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.picRatPack);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRatPack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblWingmanTitle;
        private System.Windows.Forms.PictureBox picTopWings;
        private System.Windows.Forms.PictureBox picRatPack;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Label lblAboutCaption;
        private System.Windows.Forms.Label lblWing2;
    }
}