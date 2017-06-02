namespace SWENWindowForm
{
    partial class StaffManagementH
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet = new SWENWindowForm.SWENDatabaseDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffTableAdapter = new SWENWindowForm.SWENDatabaseDataSetTableAdapters.StaffTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.vEmail = new System.Windows.Forms.TextBox();
            this.sDuty = new System.Windows.Forms.ComboBox();
            this.sCountry = new System.Windows.Forms.ComboBox();
            this.vSalary = new System.Windows.Forms.TextBox();
            this.iPostalCode = new System.Windows.Forms.TextBox();
            this.vAddress = new System.Windows.Forms.TextBox();
            this.iContactNum = new System.Windows.Forms.TextBox();
            this.vDOB = new System.Windows.Forms.TextBox();
            this.vNRIC = new System.Windows.Forms.TextBox();
            this.sLastName = new System.Windows.Forms.TextBox();
            this.sFirstName = new System.Windows.Forms.TextBox();
            this.vBankAccount = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNRICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBankNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet1 = new SWENWindowForm.SWENDatabaseDataSet1();
            this.staffTableAdapter1 = new SWENWindowForm.SWENDatabaseDataSet1TableAdapters.StaffTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label2.Location = new System.Drawing.Point(458, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 48);
            this.label2.TabIndex = 22;
            this.label2.Text = "Staff Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(37, 934);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 31;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.sWENDatabaseDataSet;
            // 
            // sWENDatabaseDataSet
            // 
            this.sWENDatabaseDataSet.DataSetName = "SWENDatabaseDataSet";
            this.sWENDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1277, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 52);
            this.button6.TabIndex = 36;
            this.button6.Text = "UPDATE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 52);
            this.button3.TabIndex = 37;
            this.button3.Text = "CREATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1277, 123);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 52);
            this.button4.TabIndex = 38;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(1443, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 404);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(-34, 409);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(268, 26);
            this.textBox11.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-34, -31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 26);
            this.textBox1.TabIndex = 42;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // vEmail
            // 
            this.vEmail.Location = new System.Drawing.Point(966, 139);
            this.vEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vEmail.Name = "vEmail";
            this.vEmail.Size = new System.Drawing.Size(268, 26);
            this.vEmail.TabIndex = 53;
            this.vEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // sDuty
            // 
            this.sDuty.FormattingEnabled = true;
            this.sDuty.Items.AddRange(new object[] {
            "General maintenance",
            "Security",
            "Room maintenance",
            "Estate maintenance"});
            this.sDuty.Location = new System.Drawing.Point(966, 205);
            this.sDuty.Name = "sDuty";
            this.sDuty.Size = new System.Drawing.Size(268, 28);
            this.sDuty.TabIndex = 52;
            this.sDuty.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sCountry
            // 
            this.sCountry.FormattingEnabled = true;
            this.sCountry.Items.AddRange(new object[] {
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
            this.sCountry.Location = new System.Drawing.Point(966, 79);
            this.sCountry.Name = "sCountry";
            this.sCountry.Size = new System.Drawing.Size(268, 28);
            this.sCountry.TabIndex = 51;
            this.sCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vSalary
            // 
            this.vSalary.Location = new System.Drawing.Point(540, 145);
            this.vSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vSalary.Name = "vSalary";
            this.vSalary.Size = new System.Drawing.Size(268, 26);
            this.vSalary.TabIndex = 49;
            this.vSalary.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // iPostalCode
            // 
            this.iPostalCode.Location = new System.Drawing.Point(966, 19);
            this.iPostalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iPostalCode.Name = "iPostalCode";
            this.iPostalCode.Size = new System.Drawing.Size(268, 26);
            this.iPostalCode.TabIndex = 48;
            this.iPostalCode.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // vAddress
            // 
            this.vAddress.Location = new System.Drawing.Point(146, 145);
            this.vAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vAddress.Name = "vAddress";
            this.vAddress.Size = new System.Drawing.Size(268, 26);
            this.vAddress.TabIndex = 47;
            this.vAddress.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // iContactNum
            // 
            this.iContactNum.Location = new System.Drawing.Point(146, 205);
            this.iContactNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iContactNum.Name = "iContactNum";
            this.iContactNum.Size = new System.Drawing.Size(268, 26);
            this.iContactNum.TabIndex = 46;
            this.iContactNum.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // vDOB
            // 
            this.vDOB.Location = new System.Drawing.Point(540, 82);
            this.vDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vDOB.Name = "vDOB";
            this.vDOB.Size = new System.Drawing.Size(268, 26);
            this.vDOB.TabIndex = 45;
            this.vDOB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // vNRIC
            // 
            this.vNRIC.Location = new System.Drawing.Point(540, 25);
            this.vNRIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vNRIC.Name = "vNRIC";
            this.vNRIC.Size = new System.Drawing.Size(268, 26);
            this.vNRIC.TabIndex = 44;
            this.vNRIC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sLastName
            // 
            this.sLastName.Location = new System.Drawing.Point(146, 82);
            this.sLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sLastName.Name = "sLastName";
            this.sLastName.Size = new System.Drawing.Size(268, 26);
            this.sLastName.TabIndex = 43;
            this.sLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sFirstName
            // 
            this.sFirstName.Location = new System.Drawing.Point(146, 22);
            this.sFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sFirstName.Name = "sFirstName";
            this.sFirstName.Size = new System.Drawing.Size(268, 26);
            this.sFirstName.TabIndex = 54;
            this.sFirstName.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // vBankAccount
            // 
            this.vBankAccount.Location = new System.Drawing.Point(540, 207);
            this.vBankAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vBankAccount.Name = "vBankAccount";
            this.vBankAccount.Size = new System.Drawing.Size(268, 26);
            this.vBankAccount.TabIndex = 55;
            this.vBankAccount.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(71, 413);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(268, 26);
            this.textBox13.TabIndex = 56;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 416);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "ID:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 33);
            this.button5.TabIndex = 58;
            this.button5.Text = "SEARCH";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(462, 410);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 33);
            this.button7.TabIndex = 59;
            this.button7.Text = "REFRESH";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 22);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 20);
            this.label23.TabIndex = 60;
            this.label23.Text = "FirstName:*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sCountry);
            this.groupBox2.Controls.Add(this.vDOB);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.sFirstName);
            this.groupBox2.Controls.Add(this.sLastName);
            this.groupBox2.Controls.Add(this.vBankAccount);
            this.groupBox2.Controls.Add(this.vNRIC);
            this.groupBox2.Controls.Add(this.vSalary);
            this.groupBox2.Controls.Add(this.sDuty);
            this.groupBox2.Controls.Add(this.iContactNum);
            this.groupBox2.Controls.Add(this.iPostalCode);
            this.groupBox2.Controls.Add(this.vEmail);
            this.groupBox2.Controls.Add(this.vAddress);
            this.groupBox2.Location = new System.Drawing.Point(26, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1467, 283);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(835, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Postal Code*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(835, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Duty*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Salary*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Bank a/n*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Address*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Country*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Contact Number*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "DOB*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "NRIC*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 85);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 20);
            this.label25.TabIndex = 60;
            this.label25.Text = "LastName:*";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(-34, 409);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(268, 26);
            this.textBox14.TabIndex = 50;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(-34, -31);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(268, 26);
            this.textBox15.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffFirstNameDataGridViewTextBoxColumn,
            this.staffLastNameDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn,
            this.staffContactNumberDataGridViewTextBoxColumn,
            this.staffNRICDataGridViewTextBoxColumn,
            this.staffDOBDataGridViewTextBoxColumn,
            this.staffSalaryDataGridViewTextBoxColumn,
            this.staffBankNoDataGridViewTextBoxColumn,
            this.staffPostalCodeDataGridViewTextBoxColumn,
            this.staffCountryDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn,
            this.staffDutyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 464);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1382, 438);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffFirstNameDataGridViewTextBoxColumn
            // 
            this.staffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_FirstName";
            this.staffFirstNameDataGridViewTextBoxColumn.HeaderText = "Staff_FirstName";
            this.staffFirstNameDataGridViewTextBoxColumn.Name = "staffFirstNameDataGridViewTextBoxColumn";
            // 
            // staffLastNameDataGridViewTextBoxColumn
            // 
            this.staffLastNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_LastName";
            this.staffLastNameDataGridViewTextBoxColumn.HeaderText = "Staff_LastName";
            this.staffLastNameDataGridViewTextBoxColumn.Name = "staffLastNameDataGridViewTextBoxColumn";
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "Staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "Staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            // 
            // staffContactNumberDataGridViewTextBoxColumn
            // 
            this.staffContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Staff_ContactNumber";
            this.staffContactNumberDataGridViewTextBoxColumn.HeaderText = "Staff_ContactNumber";
            this.staffContactNumberDataGridViewTextBoxColumn.Name = "staffContactNumberDataGridViewTextBoxColumn";
            // 
            // staffNRICDataGridViewTextBoxColumn
            // 
            this.staffNRICDataGridViewTextBoxColumn.DataPropertyName = "Staff_NRIC";
            this.staffNRICDataGridViewTextBoxColumn.HeaderText = "Staff_NRIC";
            this.staffNRICDataGridViewTextBoxColumn.Name = "staffNRICDataGridViewTextBoxColumn";
            // 
            // staffDOBDataGridViewTextBoxColumn
            // 
            this.staffDOBDataGridViewTextBoxColumn.DataPropertyName = "Staff_DOB";
            this.staffDOBDataGridViewTextBoxColumn.HeaderText = "Staff_DOB";
            this.staffDOBDataGridViewTextBoxColumn.Name = "staffDOBDataGridViewTextBoxColumn";
            // 
            // staffSalaryDataGridViewTextBoxColumn
            // 
            this.staffSalaryDataGridViewTextBoxColumn.DataPropertyName = "Staff_Salary";
            this.staffSalaryDataGridViewTextBoxColumn.HeaderText = "Staff_Salary";
            this.staffSalaryDataGridViewTextBoxColumn.Name = "staffSalaryDataGridViewTextBoxColumn";
            // 
            // staffBankNoDataGridViewTextBoxColumn
            // 
            this.staffBankNoDataGridViewTextBoxColumn.DataPropertyName = "Staff_BankNo";
            this.staffBankNoDataGridViewTextBoxColumn.HeaderText = "Staff_BankNo";
            this.staffBankNoDataGridViewTextBoxColumn.Name = "staffBankNoDataGridViewTextBoxColumn";
            // 
            // staffPostalCodeDataGridViewTextBoxColumn
            // 
            this.staffPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Staff_PostalCode";
            this.staffPostalCodeDataGridViewTextBoxColumn.HeaderText = "Staff_PostalCode";
            this.staffPostalCodeDataGridViewTextBoxColumn.Name = "staffPostalCodeDataGridViewTextBoxColumn";
            // 
            // staffCountryDataGridViewTextBoxColumn
            // 
            this.staffCountryDataGridViewTextBoxColumn.DataPropertyName = "Staff_Country";
            this.staffCountryDataGridViewTextBoxColumn.HeaderText = "Staff_Country";
            this.staffCountryDataGridViewTextBoxColumn.Name = "staffCountryDataGridViewTextBoxColumn";
            // 
            // staffEmailDataGridViewTextBoxColumn
            // 
            this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "Staff_Email";
            this.staffEmailDataGridViewTextBoxColumn.HeaderText = "Staff_Email";
            this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
            // 
            // staffDutyDataGridViewTextBoxColumn
            // 
            this.staffDutyDataGridViewTextBoxColumn.DataPropertyName = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.HeaderText = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.Name = "staffDutyDataGridViewTextBoxColumn";
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.sWENDatabaseDataSet1;
            // 
            // sWENDatabaseDataSet1
            // 
            this.sWENDatabaseDataSet1.DataSetName = "SWENDatabaseDataSet1";
            this.sWENDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1367, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 25);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // StaffManagementH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1680, 1038);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffManagementH";
            this.Text = "Staff info";
            this.Load += new System.EventHandler(this.StaffManagementH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private SWENDatabaseDataSet sWENDatabaseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private SWENDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox vEmail;
        private System.Windows.Forms.ComboBox sDuty;
        private System.Windows.Forms.ComboBox sCountry;
        private System.Windows.Forms.TextBox vSalary;
        private System.Windows.Forms.TextBox iPostalCode;
        private System.Windows.Forms.TextBox vAddress;
        private System.Windows.Forms.TextBox iContactNum;
        private System.Windows.Forms.TextBox vDOB;
        private System.Windows.Forms.TextBox vNRIC;
        private System.Windows.Forms.TextBox sLastName;
        private System.Windows.Forms.TextBox sFirstName;
        private System.Windows.Forms.TextBox vBankAccount;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SWENDatabaseDataSet1 sWENDatabaseDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private SWENDatabaseDataSet1TableAdapters.StaffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNRICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffBankNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}