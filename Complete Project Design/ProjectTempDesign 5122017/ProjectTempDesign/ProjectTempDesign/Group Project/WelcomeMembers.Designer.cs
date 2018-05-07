namespace Group_Project
{
    partial class WelcomeMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeMembers));
            this.lblWelcomeMembers = new System.Windows.Forms.Label();
            this.txtMemberUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblRetypePass = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtMemAddress1 = new System.Windows.Forms.TextBox();
            this.txtMemAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtMemCity = new System.Windows.Forms.TextBox();
            this.txtMemZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtMemState = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnCreateAcct = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAppearAccount = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNumOnly = new System.Windows.Forms.Label();
            this.combCountry = new System.Windows.Forms.ComboBox();
            this.pnlMainInfo = new System.Windows.Forms.Panel();
            this.lblWingman = new System.Windows.Forms.Label();
            this.picWings = new System.Windows.Forms.PictureBox();
            this.pnlMainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMembers
            // 
            this.lblWelcomeMembers.AutoSize = true;
            this.lblWelcomeMembers.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMembers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcomeMembers.Location = new System.Drawing.Point(24, 16);
            this.lblWelcomeMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeMembers.Name = "lblWelcomeMembers";
            this.lblWelcomeMembers.Size = new System.Drawing.Size(284, 21);
            this.lblWelcomeMembers.TabIndex = 14;
            this.lblWelcomeMembers.Text = "Welcome To Members Login!";
            // 
            // txtMemberUsername
            // 
            this.txtMemberUsername.Location = new System.Drawing.Point(114, 54);
            this.txtMemberUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberUsername.Name = "txtMemberUsername";
            this.txtMemberUsername.Size = new System.Drawing.Size(128, 20);
            this.txtMemberUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(46, 57);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(47, 89);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 86);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(246, 67);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(17, 194);
            this.lblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(83, 13);
            this.lblNewUser.TabIndex = 18;
            this.lblNewUser.Text = "Enter Username";
            this.lblNewUser.Visible = false;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(114, 191);
            this.txtNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(104, 20);
            this.txtNewUser.TabIndex = 4;
            this.txtNewUser.Visible = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(114, 212);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(104, 20);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.Visible = false;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(19, 215);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(81, 13);
            this.lblNewPass.TabIndex = 19;
            this.lblNewPass.Text = "Enter Password";
            this.lblNewPass.Visible = false;
            // 
            // lblRetypePass
            // 
            this.lblRetypePass.AutoSize = true;
            this.lblRetypePass.Location = new System.Drawing.Point(7, 236);
            this.lblRetypePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetypePass.Name = "lblRetypePass";
            this.lblRetypePass.Size = new System.Drawing.Size(93, 13);
            this.lblRetypePass.TabIndex = 20;
            this.lblRetypePass.Text = "Re-type Password";
            this.lblRetypePass.Visible = false;
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(114, 233);
            this.txtRetypePass.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '*';
            this.txtRetypePass.Size = new System.Drawing.Size(104, 20);
            this.txtRetypePass.TabIndex = 6;
            this.txtRetypePass.Visible = false;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(23, 257);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblAddress1.TabIndex = 21;
            this.lblAddress1.Text = "Address Line 1";
            this.lblAddress1.Visible = false;
            // 
            // txtMemAddress1
            // 
            this.txtMemAddress1.Location = new System.Drawing.Point(114, 254);
            this.txtMemAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemAddress1.Name = "txtMemAddress1";
            this.txtMemAddress1.Size = new System.Drawing.Size(104, 20);
            this.txtMemAddress1.TabIndex = 7;
            this.txtMemAddress1.Visible = false;
            // 
            // txtMemAddress2
            // 
            this.txtMemAddress2.Location = new System.Drawing.Point(114, 275);
            this.txtMemAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemAddress2.Name = "txtMemAddress2";
            this.txtMemAddress2.Size = new System.Drawing.Size(104, 20);
            this.txtMemAddress2.TabIndex = 8;
            this.txtMemAddress2.Visible = false;
            this.txtMemAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(23, 278);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblAddress2.TabIndex = 22;
            this.lblAddress2.Text = "Address Line 2";
            this.lblAddress2.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(43, 298);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 13);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City/Street";
            this.lblCity.Visible = false;
            // 
            // txtMemCity
            // 
            this.txtMemCity.Location = new System.Drawing.Point(114, 295);
            this.txtMemCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemCity.Name = "txtMemCity";
            this.txtMemCity.Size = new System.Drawing.Size(104, 20);
            this.txtMemCity.TabIndex = 9;
            this.txtMemCity.Visible = false;
            // 
            // txtMemZip
            // 
            this.txtMemZip.Location = new System.Drawing.Point(114, 316);
            this.txtMemZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemZip.Name = "txtMemZip";
            this.txtMemZip.Size = new System.Drawing.Size(68, 20);
            this.txtMemZip.TabIndex = 10;
            this.txtMemZip.Visible = false;
            this.txtMemZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemZip_KeyPress);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(78, 319);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 24;
            this.lblZip.Text = "Zip";
            this.lblZip.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(68, 340);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "State";
            this.lblState.Visible = false;
            // 
            // txtMemState
            // 
            this.txtMemState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMemState.Location = new System.Drawing.Point(114, 337);
            this.txtMemState.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemState.Name = "txtMemState";
            this.txtMemState.Size = new System.Drawing.Size(68, 20);
            this.txtMemState.TabIndex = 11;
            this.txtMemState.Visible = false;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(57, 358);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 26;
            this.lblCountry.Text = "Country";
            this.lblCountry.Visible = false;
            // 
            // btnCreateAcct
            // 
            this.btnCreateAcct.Location = new System.Drawing.Point(115, 410);
            this.btnCreateAcct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAcct.Name = "btnCreateAcct";
            this.btnCreateAcct.Size = new System.Drawing.Size(103, 25);
            this.btnCreateAcct.TabIndex = 13;
            this.btnCreateAcct.Text = "Create Account";
            this.btnCreateAcct.UseVisualStyleBackColor = true;
            this.btnCreateAcct.Visible = false;
            this.btnCreateAcct.Click += new System.EventHandler(this.btnCreateAcct_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(46, 174);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "Full Name";
            this.lblFirstName.Visible = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(114, 171);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(104, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Visible = false;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(246, 409);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(62, 27);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAppearAccount
            // 
            this.btnAppearAccount.Location = new System.Drawing.Point(114, 133);
            this.btnAppearAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppearAccount.Name = "btnAppearAccount";
            this.btnAppearAccount.Size = new System.Drawing.Size(115, 22);
            this.btnAppearAccount.TabIndex = 28;
            this.btnAppearAccount.Text = "Need An Account?";
            this.btnAppearAccount.UseVisualStyleBackColor = true;
            this.btnAppearAccount.Click += new System.EventHandler(this.btnAppearAccount_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(23, 113);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 29;
            // 
            // lblNumOnly
            // 
            this.lblNumOnly.AutoSize = true;
            this.lblNumOnly.ForeColor = System.Drawing.Color.Red;
            this.lblNumOnly.Location = new System.Drawing.Point(205, 319);
            this.lblNumOnly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumOnly.Name = "lblNumOnly";
            this.lblNumOnly.Size = new System.Drawing.Size(77, 13);
            this.lblNumOnly.TabIndex = 30;
            this.lblNumOnly.Text = "*Numbers Only";
            this.lblNumOnly.Visible = false;
            // 
            // combCountry
            // 
            this.combCountry.FormattingEnabled = true;
            this.combCountry.Items.AddRange(new object[] {
            "United States ",
            "United Kingdom",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.combCountry.Location = new System.Drawing.Point(114, 355);
            this.combCountry.Margin = new System.Windows.Forms.Padding(2);
            this.combCountry.Name = "combCountry";
            this.combCountry.Size = new System.Drawing.Size(82, 21);
            this.combCountry.TabIndex = 31;
            this.combCountry.Visible = false;
            // 
            // pnlMainInfo
            // 
            this.pnlMainInfo.Controls.Add(this.lblWelcomeMembers);
            this.pnlMainInfo.Controls.Add(this.lblNumOnly);
            this.pnlMainInfo.Controls.Add(this.btnCreateAcct);
            this.pnlMainInfo.Controls.Add(this.lblError);
            this.pnlMainInfo.Controls.Add(this.btnReturn);
            this.pnlMainInfo.Controls.Add(this.combCountry);
            this.pnlMainInfo.Controls.Add(this.lblUsername);
            this.pnlMainInfo.Controls.Add(this.txtMemberUsername);
            this.pnlMainInfo.Controls.Add(this.lblPassword);
            this.pnlMainInfo.Controls.Add(this.btnAppearAccount);
            this.pnlMainInfo.Controls.Add(this.txtFullName);
            this.pnlMainInfo.Controls.Add(this.lblCountry);
            this.pnlMainInfo.Controls.Add(this.txtPassword);
            this.pnlMainInfo.Controls.Add(this.txtMemState);
            this.pnlMainInfo.Controls.Add(this.lblFirstName);
            this.pnlMainInfo.Controls.Add(this.lblState);
            this.pnlMainInfo.Controls.Add(this.btnLogin);
            this.pnlMainInfo.Controls.Add(this.txtMemZip);
            this.pnlMainInfo.Controls.Add(this.lblZip);
            this.pnlMainInfo.Controls.Add(this.lblNewUser);
            this.pnlMainInfo.Controls.Add(this.txtNewUser);
            this.pnlMainInfo.Controls.Add(this.txtMemCity);
            this.pnlMainInfo.Controls.Add(this.lblNewPass);
            this.pnlMainInfo.Controls.Add(this.lblCity);
            this.pnlMainInfo.Controls.Add(this.txtNewPass);
            this.pnlMainInfo.Controls.Add(this.txtMemAddress2);
            this.pnlMainInfo.Controls.Add(this.lblAddress2);
            this.pnlMainInfo.Controls.Add(this.lblRetypePass);
            this.pnlMainInfo.Controls.Add(this.txtRetypePass);
            this.pnlMainInfo.Controls.Add(this.txtMemAddress1);
            this.pnlMainInfo.Controls.Add(this.lblAddress1);
            this.pnlMainInfo.Location = new System.Drawing.Point(113, 29);
            this.pnlMainInfo.Name = "pnlMainInfo";
            this.pnlMainInfo.Size = new System.Drawing.Size(347, 456);
            this.pnlMainInfo.TabIndex = 32;
            // 
            // lblWingman
            // 
            this.lblWingman.AutoSize = true;
            this.lblWingman.BackColor = System.Drawing.Color.Transparent;
            this.lblWingman.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingman.ForeColor = System.Drawing.Color.White;
            this.lblWingman.Location = new System.Drawing.Point(118, 517);
            this.lblWingman.Name = "lblWingman";
            this.lblWingman.Size = new System.Drawing.Size(363, 36);
            this.lblWingman.TabIndex = 33;
            this.lblWingman.Text = "Wingman Clothing Co.";
            // 
            // picWings
            // 
            this.picWings.BackColor = System.Drawing.Color.Transparent;
            this.picWings.Image = ((System.Drawing.Image)(resources.GetObject("picWings.Image")));
            this.picWings.Location = new System.Drawing.Point(12, 503);
            this.picWings.Name = "picWings";
            this.picWings.Size = new System.Drawing.Size(100, 50);
            this.picWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWings.TabIndex = 34;
            this.picWings.TabStop = false;
            // 
            // WelcomeMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 565);
            this.Controls.Add(this.picWings);
            this.Controls.Add(this.lblWingman);
            this.Controls.Add(this.pnlMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeMembers";
            this.Text = "WelcomeMembers";
            this.Load += new System.EventHandler(this.WelcomeMembers_Load);
            this.pnlMainInfo.ResumeLayout(false);
            this.pnlMainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMembers;
        private System.Windows.Forms.TextBox txtMemberUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblRetypePass;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtMemAddress1;
        private System.Windows.Forms.TextBox txtMemAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtMemCity;
        private System.Windows.Forms.TextBox txtMemZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtMemState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnCreateAcct;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAppearAccount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNumOnly;
        private System.Windows.Forms.ComboBox combCountry;
        private System.Windows.Forms.Panel pnlMainInfo;
        private System.Windows.Forms.Label lblWingman;
        private System.Windows.Forms.PictureBox picWings;
    }
}