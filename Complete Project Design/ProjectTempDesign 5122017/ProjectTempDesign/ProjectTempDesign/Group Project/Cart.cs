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
    public partial class Cart : Form
    {
        public string custName;
        public string totalShopping;
        public string tax;
        public string carrySales;


        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            lblNameofShopper.Text = custName;
            lblTotalPrice.Text = totalShopping;
            lblTaxApplied.Text = tax;
            lblBillPrice.Text = carrySales;
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmIntro forthForm = new FrmIntro();
            forthForm.Show();
            this.Hide();

        }

        private void lblThankYou_Click(object sender, EventArgs e)
        {

        }
    }
}
