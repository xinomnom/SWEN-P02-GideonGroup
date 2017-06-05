namespace SWENWindowForm
{
    partial class GuestMangementHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vCountry = new System.Windows.Forms.ComboBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iGuestID = new System.Windows.Forms.TextBox();
            this.vEmail = new System.Windows.Forms.TextBox();
            this.iPostalCode = new System.Windows.Forms.TextBox();
            this.vAddress = new System.Windows.Forms.TextBox();
            this.dtDateOfBirth = new System.Windows.Forms.TextBox();
            this.iAge = new System.Windows.Forms.TextBox();
            this.vLastName = new System.Windows.Forms.TextBox();
            this.vFirstName = new System.Windows.Forms.TextBox();
            this.GridGuestInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guestDataSet = new SWENWindowForm.GuestDataSet();
            this.iRoomID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.guestTableAdapter = new SWENWindowForm.GuestDataSetTableAdapters.GuestTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGuestInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vCountry);
            this.groupBox1.Controls.Add(this.bCreate);
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.iGuestID);
            this.groupBox1.Controls.Add(this.vEmail);
            this.groupBox1.Controls.Add(this.iPostalCode);
            this.groupBox1.Controls.Add(this.vAddress);
            this.groupBox1.Controls.Add(this.dtDateOfBirth);
            this.groupBox1.Controls.Add(this.iAge);
            this.groupBox1.Controls.Add(this.vLastName);
            this.groupBox1.Controls.Add(this.vFirstName);
            this.groupBox1.Location = new System.Drawing.Point(29, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1441, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Info";
            // 
            // vCountry
            // 
            this.vCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vCountry.FormattingEnabled = true;
            this.vCountry.Items.AddRange(new object[] {
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
            this.vCountry.Location = new System.Drawing.Point(539, 259);
            this.vCountry.Name = "vCountry";
            this.vCountry.Size = new System.Drawing.Size(268, 28);
            this.vCountry.TabIndex = 52;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(1246, 249);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(175, 47);
            this.bCreate.TabIndex = 20;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(1246, 148);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(175, 47);
            this.bDelete.TabIndex = 19;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(1246, 41);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(175, 47);
            this.bUpdate.TabIndex = 18;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(862, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Guest_ID*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(899, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(826, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Postal/Zip Code*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Country*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Birth*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name*";
            // 
            // iGuestID
            // 
            this.iGuestID.Location = new System.Drawing.Point(953, 259);
            this.iGuestID.Name = "iGuestID";
            this.iGuestID.Size = new System.Drawing.Size(269, 26);
            this.iGuestID.TabIndex = 8;
            // 
            // vEmail
            // 
            this.vEmail.Location = new System.Drawing.Point(953, 155);
            this.vEmail.Name = "vEmail";
            this.vEmail.Size = new System.Drawing.Size(269, 26);
            this.vEmail.TabIndex = 7;
            // 
            // iPostalCode
            // 
            this.iPostalCode.Location = new System.Drawing.Point(953, 51);
            this.iPostalCode.Name = "iPostalCode";
            this.iPostalCode.Size = new System.Drawing.Size(269, 26);
            this.iPostalCode.TabIndex = 6;
            // 
            // vAddress
            // 
            this.vAddress.Location = new System.Drawing.Point(538, 158);
            this.vAddress.Name = "vAddress";
            this.vAddress.Size = new System.Drawing.Size(269, 26);
            this.vAddress.TabIndex = 4;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Location = new System.Drawing.Point(538, 51);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(269, 26);
            this.dtDateOfBirth.TabIndex = 3;
            // 
            // iAge
            // 
            this.iAge.Location = new System.Drawing.Point(141, 259);
            this.iAge.Name = "iAge";
            this.iAge.Size = new System.Drawing.Size(269, 26);
            this.iAge.TabIndex = 2;
            // 
            // vLastName
            // 
            this.vLastName.Location = new System.Drawing.Point(141, 158);
            this.vLastName.Name = "vLastName";
            this.vLastName.Size = new System.Drawing.Size(269, 26);
            this.vLastName.TabIndex = 1;
            // 
            // vFirstName
            // 
            this.vFirstName.Location = new System.Drawing.Point(141, 51);
            this.vFirstName.Name = "vFirstName";
            this.vFirstName.Size = new System.Drawing.Size(269, 26);
            this.vFirstName.TabIndex = 0;
            // 
            // GridGuestInfo
            // 
            this.GridGuestInfo.AutoGenerateColumns = false;
            this.GridGuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGuestInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.GridGuestInfo.DataSource = this.bindingSource1;
            this.GridGuestInfo.Location = new System.Drawing.Point(29, 451);
            this.GridGuestInfo.Name = "GridGuestInfo";
            this.GridGuestInfo.RowTemplate.Height = 28;
            this.GridGuestInfo.Size = new System.Drawing.Size(1441, 318);
            this.GridGuestInfo.TabIndex = 2;
            this.GridGuestInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridGuestInfo_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Guest_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Guest_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Guest_FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Guest_FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Guest_LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Guest_LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Guest_Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Guest_Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Guest_DOB";
            this.dataGridViewTextBoxColumn5.HeaderText = "Guest_DOB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Guest_Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Guest_Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Guest_Country";
            this.dataGridViewTextBoxColumn7.HeaderText = "Guest_Country";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Guest_PostalCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Guest_PostalCode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Guest_Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Guest_Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Room_No";
            this.dataGridViewTextBoxColumn10.HeaderText = "Room_No";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Guest";
            this.bindingSource1.DataSource = this.guestDataSet;
            // 
            // guestDataSet
            // 
            this.guestDataSet.DataSetName = "GuestDataSet";
            this.guestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iRoomID
            // 
            this.iRoomID.Location = new System.Drawing.Point(567, 401);
            this.iRoomID.Name = "iRoomID";
            this.iRoomID.Size = new System.Drawing.Size(269, 26);
            this.iRoomID.TabIndex = 5;
            this.iRoomID.TextChanged += new System.EventHandler(this.iRoomID_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Room_ID*";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(859, 394);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(101, 41);
            this.bSearch.TabIndex = 19;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(982, 394);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(101, 41);
            this.bReset.TabIndex = 20;
            this.bReset.Text = "Refresh";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label12.Location = new System.Drawing.Point(660, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 37);
            this.label12.TabIndex = 71;
            this.label12.Text = "Guest Management";
            // 
            // GuestMangementHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 799);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iRoomID);
            this.Controls.Add(this.GridGuestInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuestMangementHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGuestInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridGuestInfo;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iGuestID;
        private System.Windows.Forms.TextBox vEmail;
        private System.Windows.Forms.TextBox iPostalCode;
        private System.Windows.Forms.TextBox vAddress;
        private System.Windows.Forms.TextBox dtDateOfBirth;
        private System.Windows.Forms.TextBox iAge;
        private System.Windows.Forms.TextBox vLastName;
        private System.Windows.Forms.TextBox vFirstName;
        private System.Windows.Forms.TextBox iRoomID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GuestDataSet guestDataSet;
        private GuestDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.ComboBox vCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label12;
    }
}