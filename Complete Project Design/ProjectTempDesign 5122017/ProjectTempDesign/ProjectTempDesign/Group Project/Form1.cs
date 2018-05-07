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
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            WelcomeMembers secondForm = new WelcomeMembers();
            secondForm.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            Guests secondForm2 = new Guests();
            secondForm2.Show();
            this.Hide();
        }

        private void lblLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
