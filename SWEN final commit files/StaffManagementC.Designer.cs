namespace SWENWindowForm
{
    partial class StaffManagementC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iContactNumCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sDutyCreate = new System.Windows.Forms.ComboBox();
            this.sCountryCreate = new System.Windows.Forms.ComboBox();
            this.vBankNumberCreate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vSalaryCreate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iPostalCodeCreate = new System.Windows.Forms.TextBox();
            this.vAddressCreate = new System.Windows.Forms.TextBox();
            this.vEmailCreate = new System.Windows.Forms.TextBox();
            this.vNRICCreate = new System.Windows.Forms.TextBox();
            this.sLastNameCreate = new System.Windows.Forms.TextBox();
            this.sFirstNameCreate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.iContactNumCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sDutyCreate);
            this.panel1.Controls.Add(this.sCountryCreate);
            this.panel1.Controls.Add(this.vBankNumberCreate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vSalaryCreate);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.iPostalCodeCreate);
            this.panel1.Controls.Add(this.vAddressCreate);
            this.panel1.Controls.Add(this.vEmailCreate);
            this.panel1.Controls.Add(this.vNRICCreate);
            this.panel1.Controls.Add(this.sLastNameCreate);
            this.panel1.Controls.Add(this.sFirstNameCreate);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 591);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Value = new System.DateTime(2017, 6, 3, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // iContactNumCreate
            // 
            this.iContactNumCreate.Location = new System.Drawing.Point(196, 228);
            this.iContactNumCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iContactNumCreate.Name = "iContactNumCreate";
            this.iContactNumCreate.Size = new System.Drawing.Size(268, 26);
            this.iContactNumCreate.TabIndex = 41;
            this.iContactNumCreate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Contact Number*";
            // 
            // sDutyCreate
            // 
            this.sDutyCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sDutyCreate.FormattingEnabled = true;
            this.sDutyCreate.Items.AddRange(new object[] {
            "General maintenance",
            "Security",
            "Room maintenance",
            "Estate maintenance"});
            this.sDutyCreate.Location = new System.Drawing.Point(196, 391);
            this.sDutyCreate.Name = "sDutyCreate";
            this.sDutyCreate.Size = new System.Drawing.Size(268, 28);
            this.sDutyCreate.TabIndex = 39;
            this.sDutyCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sCountryCreate
            // 
            this.sCountryCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sCountryCreate.FormattingEnabled = true;
            this.sCountryCreate.Items.AddRange(new object[] {
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
            "Bahamas",
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
            "Top of Page",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Top of Page",
            "East Timor (see Timor-Leste)",
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
            "Top of Page",
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
            this.sCountryCreate.Location = new System.Drawing.Point(196, 262);
            this.sCountryCreate.Name = "sCountryCreate";
            this.sCountryCreate.Size = new System.Drawing.Size(268, 28);
            this.sCountryCreate.TabIndex = 38;
            this.sCountryCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.sCountryCreate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sCountryCreate_KeyDown);
            // 
            // vBankNumberCreate
            // 
            this.vBankNumberCreate.Location = new System.Drawing.Point(196, 474);
            this.vBankNumberCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vBankNumberCreate.Name = "vBankNumberCreate";
            this.vBankNumberCreate.Size = new System.Drawing.Size(268, 26);
            this.vBankNumberCreate.TabIndex = 36;
            this.vBankNumberCreate.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bank a/n:*";
            // 
            // vSalaryCreate
            // 
            this.vSalaryCreate.Location = new System.Drawing.Point(196, 434);
            this.vSalaryCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vSalaryCreate.Name = "vSalaryCreate";
            this.vSalaryCreate.Size = new System.Drawing.Size(268, 26);
            this.vSalaryCreate.TabIndex = 34;
            this.vSalaryCreate.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 434);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Salary:*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 52);
            this.button1.TabIndex = 30;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iPostalCodeCreate
            // 
            this.iPostalCodeCreate.Location = new System.Drawing.Point(196, 351);
            this.iPostalCodeCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iPostalCodeCreate.Name = "iPostalCodeCreate";
            this.iPostalCodeCreate.Size = new System.Drawing.Size(268, 26);
            this.iPostalCodeCreate.TabIndex = 28;
            this.iPostalCodeCreate.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // vAddressCreate
            // 
            this.vAddressCreate.Location = new System.Drawing.Point(196, 306);
            this.vAddressCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vAddressCreate.Name = "vAddressCreate";
            this.vAddressCreate.Size = new System.Drawing.Size(268, 26);
            this.vAddressCreate.TabIndex = 27;
            this.vAddressCreate.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // vEmailCreate
            // 
            this.vEmailCreate.Location = new System.Drawing.Point(196, 193);
            this.vEmailCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vEmailCreate.Name = "vEmailCreate";
            this.vEmailCreate.Size = new System.Drawing.Size(268, 26);
            this.vEmailCreate.TabIndex = 25;
            this.vEmailCreate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // vNRICCreate
            // 
            this.vNRICCreate.Location = new System.Drawing.Point(196, 114);
            this.vNRICCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vNRICCreate.Name = "vNRICCreate";
            this.vNRICCreate.Size = new System.Drawing.Size(268, 26);
            this.vNRICCreate.TabIndex = 23;
            this.vNRICCreate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sLastNameCreate
            // 
            this.sLastNameCreate.Location = new System.Drawing.Point(196, 74);
            this.sLastNameCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sLastNameCreate.Name = "sLastNameCreate";
            this.sLastNameCreate.Size = new System.Drawing.Size(268, 26);
            this.sLastNameCreate.TabIndex = 22;
            this.sLastNameCreate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sFirstNameCreate
            // 
            this.sFirstNameCreate.Location = new System.Drawing.Point(196, 34);
            this.sFirstNameCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sFirstNameCreate.Name = "sFirstNameCreate";
            this.sFirstNameCreate.Size = new System.Drawing.Size(268, 26);
            this.sFirstNameCreate.TabIndex = 21;
            this.sFirstNameCreate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 154);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "DOB:*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 355);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Postal Code:*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 262);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Country:*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 306);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 17;
            this.label20.Text = "Address:*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 193);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 20);
            this.label21.TabIndex = 16;
            this.label21.Text = "Email:*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 114);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 20);
            this.label22.TabIndex = 15;
            this.label22.Text = "NRIC*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(0, 40);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 20);
            this.label23.TabIndex = 14;
            this.label23.Text = "FirstName:*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 394);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 20);
            this.label24.TabIndex = 13;
            this.label24.Text = "Duty:*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 74);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 20);
            this.label25.TabIndex = 6;
            this.label25.Text = "LastName:*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 22);
            this.label26.TabIndex = 5;
            this.label26.Text = "Staff Info";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StaffManagementC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 637);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffManagementC";
            this.Text = "Create staff";
            this.Load += new System.EventHandler(this.StaffManagementC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox vBankNumberCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vSalaryCreate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iPostalCodeCreate;
        private System.Windows.Forms.TextBox vAddressCreate;
        private System.Windows.Forms.TextBox vEmailCreate;
        private System.Windows.Forms.TextBox vNRICCreate;
        private System.Windows.Forms.TextBox sLastNameCreate;
        private System.Windows.Forms.TextBox sFirstNameCreate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox iContactNumCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sDutyCreate;
        private System.Windows.Forms.ComboBox sCountryCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}