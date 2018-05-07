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
    public partial class Guests : Form
    {   //declare variables and constants
        const string FILENAME1 = "GuestCustomer.txt";

        

      
        public Guests()
        {
            InitializeComponent();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guests_Load(object sender, EventArgs e)
        { 
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream outFile = new FileStream(FILENAME1, FileMode.Create, FileAccess.Write);

            // writing the input
            string guestName;
            string guestAddress1;
            string guestAddress2;
            string guestCity;
            string guestZip;
            string guestState;
            string guestCountry;        

            guestName = txtName.Text;
            guestAddress1= txtAddress1.Text;
            guestAddress2 = txtAddress2.Text;
            guestCity = txtCity.Text;
            guestZip = txtZip.Text;
            guestState = txtState.Text;
            //guestCountry = txtCountry.Text;
            guestCountry = comboxCountry.Text;

            txtName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtZip.Clear();
            txtState.Clear();
            
            txtName.Focus();

            StreamWriter writer = new StreamWriter(outFile); // connecting with the file

            if (guestName != ""  && guestAddress1 != "" && guestCity != "" && guestZip != "" && guestState != "" && guestCountry != "")
            {

                writer.WriteLine(guestName);
                writer.WriteLine(guestAddress1);
                writer.WriteLine(guestAddress2);
                writer.WriteLine(guestCity);
                writer.WriteLine(guestZip);
                writer.WriteLine(guestState);
                writer.WriteLine(guestCountry);
            }
            else
                MessageBox.Show(" Sorry! But one of fields was empty. Please make sure you fill all the field (Address 2 is optional!");

            writer.Close();
            outFile.Close();

            Shopping forthForm = new Shopping();
            forthForm.loginName = guestName;
            forthForm.Show();
            this.Hide();
        }
        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmIntro firstForm = new FrmIntro();
            firstForm.Show();
            this.Hide();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( char.IsNumber (e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
