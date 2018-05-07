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
    public partial class WelcomeMembers : Form
    {   //declare variables and constants
        const string MANAGER_USERNAME = "tarun";
        const string MANAGER_PASSWORD = "sharma";

        string[] fullName;
        string[] newUsername;
        string[] newPassword;
        string[] address1;
        string[] address2;
        string[] city;
        string[] zip;
        string[] state;
        string[] country;
        int count = 0;
        const int DATA_TYPE = 9;
        int custCount;

        public string userFullName; // creating an account

        const string FILENAME = "Members.txt";

        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

        FileStream inFile2 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

        public WelcomeMembers()
        {
            InitializeComponent();
        }

        private void WelcomeMembers_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(inFile);
            while (reader.ReadLine() != null)
                count += 1;

            reader.Close();
            inFile.Close();

            custCount = count / 9;
            //assigning values to array
            fullName = new string[custCount];
            newUsername= new string[custCount];
            newPassword= new string[custCount];
            address1= new string[custCount];
            address2= new string[custCount];
            city= new string[custCount]; 
            zip= new string[custCount];
            state= new string[custCount]; ;
            country= new string[custCount];

            StreamReader reader2 = new StreamReader(inFile2);
            for( int x=0; x<custCount; ++x)
            {
                fullName[x] = reader2.ReadLine();
                newUsername[x]= reader2.ReadLine();
                newPassword[x]= reader2.ReadLine();
                address1[x]= reader2.ReadLine();
                address2[x]= reader2.ReadLine();
                city[x]= reader2.ReadLine();
                zip[x]= reader2.ReadLine();
                state[x]= reader2.ReadLine();
                country[x]= reader2.ReadLine();
            }
            //closer reader 2 and infile2
            reader2.Close();
            inFile2.Close();
            
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string memberUsername;
            string memberPass;
            string managerUser;
            string managerPass;


            memberUsername = txtMemberUsername.Text;
            memberPass = txtPassword.Text;

            managerUser = txtMemberUsername.Text;
            managerPass = txtPassword.Text;

            FileStream inFile3 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read); // reading the file again to user members data to login
            StreamReader reader3 = new StreamReader(inFile3);

            bool found = false;
            string loginFullName = ""; 
            for (int y = 0; y < custCount; ++y) // reading the file and using the username and password to login s
            {
                fullName[y] = reader3.ReadLine();
                newUsername[y] = reader3.ReadLine();
                newPassword[y] = reader3.ReadLine();
                address1[y] = reader3.ReadLine();
                address2[y] = reader3.ReadLine();
                city[y] = reader3.ReadLine();
                zip[y] = reader3.ReadLine();
                state[y] = reader3.ReadLine();
                country[y] = reader3.ReadLine();

                if (memberUsername == newUsername[y] && memberPass == newPassword[y])
                {
                    found = true;
                    loginFullName = fullName[y];
                    break;
                }
            }
            if (found)
            {
                Shopping forthform = new Shopping();
                forthform.loginName = loginFullName;
                forthform.Show();
                this.Hide();
            }
            if (managerUser == MANAGER_USERNAME && managerPass == MANAGER_PASSWORD)
            {
                ManagerReport managerForm = new ManagerReport();
                managerForm.Show();
                this.Hide();
            }
            else
            {

                txtMemberUsername.Clear();
                txtMemberUsername.Focus();
                txtPassword.Clear();
                lblError.Text= ("Sorry! Username or password you have entered is incorrect!");
            }
            
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAcct_Click(object sender, EventArgs e)
        {
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);

           
            string userUsername;
            string firstPass;
            string retypePass;
            string userAddress1;
            string userAddress2;
            string userCity;
            string userZip;
            string userState;
            string userCountry;

            userFullName = txtFullName.Text;
            userUsername = txtNewUser.Text;
            firstPass = txtNewPass.Text;
            retypePass = txtRetypePass.Text;
            userAddress1 = txtMemAddress1.Text;
            userAddress2 = txtMemAddress2.Text;
            userCity = txtMemCity.Text;
            userZip = txtMemZip.Text;
            userState = txtMemState.Text;
            userCountry = combCountry.Text;

            txtFullName.Clear();
            txtNewUser.Clear();
            txtNewPass.Clear();
            txtRetypePass.Clear();
            txtMemAddress1.Clear();
            txtMemAddress2.Clear();
            txtMemCity.Clear();
            txtMemZip.Clear();
            txtMemState.Clear();
            

            StreamWriter writer = new StreamWriter(outFile);

            if (userFullName != "" && userUsername != "" && firstPass != "" && retypePass != "" && (firstPass == retypePass) && userAddress1 != "" && userCity != "" && userZip != "" && userState != "" && userCountry != "")
            {
                writer.WriteLine(userFullName);
                writer.WriteLine(userUsername);
                writer.WriteLine(retypePass);
                writer.WriteLine(userAddress1);
                writer.WriteLine(userAddress2);
                writer.WriteLine(userCity);
                writer.WriteLine(userZip);
                writer.WriteLine(userState);
                writer.WriteLine(userCountry);

                Shopping forthForm = new Shopping();
                forthForm.loginName = userFullName;
                forthForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sorry! but one or more fields are empty!");
            }
            writer.Close();
            outFile.Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmIntro firstForm = new FrmIntro();
            firstForm.Show();
            this.Hide();
        }

        private void btnAppearAccount_Click(object sender, EventArgs e)
        {
            txtFullName.Visible = true;
            lblFirstName.Visible = true;
            txtNewUser.Visible = true;
            lblNewUser.Visible = true;
            lblNewPass.Visible = true;
            txtNewPass.Visible = true;
            lblRetypePass.Visible = true;
            txtRetypePass.Visible = true;
            lblAddress1.Visible = true;
            txtMemAddress1.Visible = true;
            txtMemAddress2.Visible = true;
            lblAddress2.Visible = true;
            txtMemCity.Visible = true;
            lblCity.Visible = true;
            txtMemZip.Visible = true;
            lblZip.Visible = true;
            lblNumOnly.Visible = true;
            lblState.Visible = true;
            txtMemState.Visible = true;
            combCountry.Visible = true;
            lblCountry.Visible = true;
            btnCreateAcct.Visible = true;
        }

        private void txtMemZip_KeyPress(object sender, KeyPressEventArgs e)
        {  // numbers only for zip
            if( char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtMemCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
