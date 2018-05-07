using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group_Project
{
    public partial class Shopping : Form
    {    //declare variables and constants

        public string loginName;
        public string carrySales;
        double totalSales;
        double finalSales;
        public Shopping()
        {
            InitializeComponent();
        }

        private void Shopping_Load(object sender, EventArgs e)
        {

            lblNameOfShopper.Text = loginName;
        }

        private void lblSuits_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picGreenBrightDotTie_Click(object sender, EventArgs e)
        {


        }

        private void picLightBlueDotTie_Click(object sender, EventArgs e)
        {

        }

        private void picNavySquareTie_Click(object sender, EventArgs e)
        {

        }

        private void lblTies_Click(object sender, EventArgs e)
        {

        }

        private void chkSuitNavy_CheckedChanged(object sender, EventArgs e)
        {
            double price = 549.99;
           bool flag = chkSuitNavy.Checked;
            if (flag)
            {
                totalSales += price;
                
            } else
            {
                totalSales -= price;
            }
        }

        private void chkSuitBlack_CheckedChanged(object sender, EventArgs e)
        {
           double price = 549.99;
            bool flag = chkSuitBlack.Checked;
            
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkSuitCharcoal_CheckedChanged(object sender, EventArgs e)
        {
            double price = 549.99; 
            bool flag = chkSuitCharcoal.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkSuitBlue_CheckedChanged(object sender, EventArgs e)
        {
            double price = 499.99;
            bool flag = chkSuitBlue.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkSuitLightGray_CheckedChanged(object sender, EventArgs e)
        {
            double price = 499.99; 
            bool flag = chkSuitLightGray.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkSuitTan_CheckedChanged(object sender, EventArgs e)
        {
            double price = 449.99;  
            bool flag = chkSuitTan.Checked;
            
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShirtWhite_CheckedChanged(object sender, EventArgs e)
        {
            double price = 89.99;  
            bool flag = chkDressShirtWhite.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShirtLightBlue_CheckedChanged(object sender, EventArgs e)
        {
            double price = 99.99;
            bool flag = chkDressShirtLightBlue.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShirtLilac_CheckedChanged(object sender, EventArgs e)
        {
            double price = 99.99;  
            bool flag = chkDressShirtLilac.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieNavySquare_CheckedChanged(object sender, EventArgs e)
        {
            double price = 35.99;
            bool flag = chkTieNavySquare.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieLightBlueDot_CheckedChanged(object sender, EventArgs e)
        {
            double price = 35.99;
            bool flag = chkTieLightBlueDot.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieGreenBrightDot_CheckedChanged(object sender, EventArgs e)
        {
            double price = 35.99;     
            bool flag = chkTieGreenBrightDot.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieBurgundyPlaid_CheckedChanged(object sender, EventArgs e)
        {
            double price = 29.99;  
            bool flag = chkTieBurgundyPlaid.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieOrangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            double price = 29.99;  
            bool flag = chkTieOrangeCheck.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieFuschiaFloral_CheckedChanged(object sender, EventArgs e)
        {
            double price = 25.99;  
            bool flag = chkTieFuschiaFloral.Checked;
            if (flag)
            {
                totalSales += price;
                
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieMintPaisley_CheckedChanged(object sender, EventArgs e)
        {
            double price = 39.99;
            bool flag = chkTieMintPaisley.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkTieRedStripe_CheckedChanged(object sender, EventArgs e)
        {
            double price = 25.99;
            bool flag = chkTieRedStripe.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price; 
            }
        }

        private void chkTieYellowGrid_CheckedChanged(object sender, EventArgs e)
        {
            double price = 25.99; 
            bool flag = chkTieYellowGrid.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShoeBlackOxford_CheckedChanged(object sender, EventArgs e)
        {
            double price = 99.99;
            bool flag = chkDressShoeBlackOxford.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShoeMediumBrown_CheckedChanged(object sender, EventArgs e)
        {
            double price = 89.99;
            bool flag = chkDressShoeMediumBrown.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void chkDressShoeTanOxford_CheckedChanged(object sender, EventArgs e)
        {
            double price = 99.99;
            bool flag = chkDressShoeTanOxford.Checked;
            if (flag)
            {
                totalSales += price;
            }
            else
            {
                totalSales -= price;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
            const string FILENAME = "totalSales.txt";
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            const double TAX = .08;
            double tax_amt = totalSales * TAX;
            finalSales = totalSales * (1 + TAX);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine(loginName);
            writer.WriteLine(finalSales.ToString("C"));

            writer.Close();
            outFile.Close();

            
           Cart LastForm = new Cart();
            LastForm.custName = loginName;
            LastForm.totalShopping = totalSales.ToString("C");
            LastForm.tax = tax_amt.ToString("C");
            LastForm.carrySales= finalSales.ToString("C");
           LastForm.Show();
            this.Hide();
           // MessageBox.Show(totalSales.ToString("C"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmIntro firstForm = new FrmIntro();
            firstForm.Show();
            this.Hide();
        }

        private void lblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("WingMan Clothing CO. was founded by Tarun Sharma, Kevin Romo, Christian Smith, and Trevor Sullivan");
        }

        private void lblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please email us at WingManClothing@WingManClothingCo.com");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout aboutPage = new FrmAbout();
            aboutPage.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            frmContact contactPage = new frmContact();
            contactPage.Show();
            this.Hide();
        }
    }
}
