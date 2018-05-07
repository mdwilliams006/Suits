using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void btnBackContact_Click(object sender, EventArgs e)
        {
            Shopping forthForm = new Shopping();
            forthForm.Show();
            this.Hide();
        }
    }
}
