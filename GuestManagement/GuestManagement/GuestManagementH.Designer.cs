namespace GuestManagement
{
    partial class GuestList
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
            this.GridGuestInfo = new System.Windows.Forms.DataGridView();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet1 = new GuestManagement.SWENDatabaseDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.vCountry = new System.Windows.Forms.ComboBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iGuestID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vAddress = new System.Windows.Forms.TextBox();
            this.dtDateOfBirth = new System.Windows.Forms.TextBox();
            this.iPostalCode = new System.Windows.Forms.TextBox();
            this.vEmail = new System.Windows.Forms.TextBox();
            this.iAge = new System.Windows.Forms.TextBox();
            this.vLastName = new System.Windows.Forms.TextBox();
            this.vFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iRoomID = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.guestTableAdapter2 = new GuestManagement.SWENDatabaseDataSet1TableAdapters.GuestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridGuestInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet1)).BeginInit();
            this.StaffDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridGuestInfo
            // 
            this.GridGuestInfo.AutoGenerateColumns = false;
            this.GridGuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGuestInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestIDDataGridViewTextBoxColumn,
            this.guestFirstNameDataGridViewTextBoxColumn,
            this.guestLastNameDataGridViewTextBoxColumn,
            this.guestAgeDataGridViewTextBoxColumn,
            this.guestDOBDataGridViewTextBoxColumn,
            this.guestAddressDataGridViewTextBoxColumn,
            this.guestCountryDataGridViewTextBoxColumn,
            this.guestPostalCodeDataGridViewTextBoxColumn,
            this.guestEmailDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn});
            this.GridGuestInfo.DataSource = this.bindingSource2;
            this.GridGuestInfo.Location = new System.Drawing.Point(22, 411);
            this.GridGuestInfo.Margin = new System.Windows.Forms.Padding(4);
            this.GridGuestInfo.Name = "GridGuestInfo";
            this.GridGuestInfo.RowTemplate.Height = 24;
            this.GridGuestInfo.Size = new System.Drawing.Size(1431, 335);
            this.GridGuestInfo.TabIndex = 1;
            this.GridGuestInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridGuestInfo_MouseDoubleClick);
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "Guest_ID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "Guest_ID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestFirstNameDataGridViewTextBoxColumn
            // 
            this.guestFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Guest_FirstName";
            this.guestFirstNameDataGridViewTextBoxColumn.HeaderText = "Guest_FirstName";
            this.guestFirstNameDataGridViewTextBoxColumn.Name = "guestFirstNameDataGridViewTextBoxColumn";
            this.guestFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // guestLastNameDataGridViewTextBoxColumn
            // 
            this.guestLastNameDataGridViewTextBoxColumn.DataPropertyName = "Guest_LastName";
            this.guestLastNameDataGridViewTextBoxColumn.HeaderText = "Guest_LastName";
            this.guestLastNameDataGridViewTextBoxColumn.Name = "guestLastNameDataGridViewTextBoxColumn";
            this.guestLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestLastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // guestAgeDataGridViewTextBoxColumn
            // 
            this.guestAgeDataGridViewTextBoxColumn.DataPropertyName = "Guest_Age";
            this.guestAgeDataGridViewTextBoxColumn.HeaderText = "Guest_Age";
            this.guestAgeDataGridViewTextBoxColumn.Name = "guestAgeDataGridViewTextBoxColumn";
            this.guestAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestDOBDataGridViewTextBoxColumn
            // 
            this.guestDOBDataGridViewTextBoxColumn.DataPropertyName = "Guest_DOB";
            this.guestDOBDataGridViewTextBoxColumn.HeaderText = "Guest_DOB";
            this.guestDOBDataGridViewTextBoxColumn.Name = "guestDOBDataGridViewTextBoxColumn";
            this.guestDOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestDOBDataGridViewTextBoxColumn.Width = 120;
            // 
            // guestAddressDataGridViewTextBoxColumn
            // 
            this.guestAddressDataGridViewTextBoxColumn.DataPropertyName = "Guest_Address";
            this.guestAddressDataGridViewTextBoxColumn.HeaderText = "Guest_Address";
            this.guestAddressDataGridViewTextBoxColumn.Name = "guestAddressDataGridViewTextBoxColumn";
            this.guestAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // guestCountryDataGridViewTextBoxColumn
            // 
            this.guestCountryDataGridViewTextBoxColumn.DataPropertyName = "Guest_Country";
            this.guestCountryDataGridViewTextBoxColumn.HeaderText = "Guest_Country";
            this.guestCountryDataGridViewTextBoxColumn.Name = "guestCountryDataGridViewTextBoxColumn";
            this.guestCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // guestPostalCodeDataGridViewTextBoxColumn
            // 
            this.guestPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Guest_PostalCode";
            this.guestPostalCodeDataGridViewTextBoxColumn.HeaderText = "Guest_PostalCode";
            this.guestPostalCodeDataGridViewTextBoxColumn.Name = "guestPostalCodeDataGridViewTextBoxColumn";
            this.guestPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestPostalCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // guestEmailDataGridViewTextBoxColumn
            // 
            this.guestEmailDataGridViewTextBoxColumn.DataPropertyName = "Guest_Email";
            this.guestEmailDataGridViewTextBoxColumn.HeaderText = "Guest_Email";
            this.guestEmailDataGridViewTextBoxColumn.Name = "guestEmailDataGridViewTextBoxColumn";
            this.guestEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestEmailDataGridViewTextBoxColumn.Width = 170;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Guest";
            this.bindingSource2.DataSource = this.sWENDatabaseDataSet1;
            // 
            // sWENDatabaseDataSet1
            // 
            this.sWENDatabaseDataSet1.DataSetName = "SWENDatabaseDataSet1";
            this.sWENDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(601, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guest Management";
            // 
            // StaffDetailsGroupBox
            // 
            this.StaffDetailsGroupBox.Controls.Add(this.vCountry);
            this.StaffDetailsGroupBox.Controls.Add(this.bUpdate);
            this.StaffDetailsGroupBox.Controls.Add(this.bDelete);
            this.StaffDetailsGroupBox.Controls.Add(this.bCreate);
            this.StaffDetailsGroupBox.Controls.Add(this.label11);
            this.StaffDetailsGroupBox.Controls.Add(this.label9);
            this.StaffDetailsGroupBox.Controls.Add(this.iGuestID);
            this.StaffDetailsGroupBox.Controls.Add(this.label8);
            this.StaffDetailsGroupBox.Controls.Add(this.label7);
            this.StaffDetailsGroupBox.Controls.Add(this.label6);
            this.StaffDetailsGroupBox.Controls.Add(this.label5);
            this.StaffDetailsGroupBox.Controls.Add(this.label4);
            this.StaffDetailsGroupBox.Controls.Add(this.label3);
            this.StaffDetailsGroupBox.Controls.Add(this.label2);
            this.StaffDetailsGroupBox.Controls.Add(this.vAddress);
            this.StaffDetailsGroupBox.Controls.Add(this.dtDateOfBirth);
            this.StaffDetailsGroupBox.Controls.Add(this.iPostalCode);
            this.StaffDetailsGroupBox.Controls.Add(this.vEmail);
            this.StaffDetailsGroupBox.Controls.Add(this.iAge);
            this.StaffDetailsGroupBox.Controls.Add(this.vLastName);
            this.StaffDetailsGroupBox.Controls.Add(this.vFirstName);
            this.StaffDetailsGroupBox.Location = new System.Drawing.Point(36, 66);
            this.StaffDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.StaffDetailsGroupBox.Name = "StaffDetailsGroupBox";
            this.StaffDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.StaffDetailsGroupBox.Size = new System.Drawing.Size(1406, 266);
            this.StaffDetailsGroupBox.TabIndex = 4;
            this.StaffDetailsGroupBox.TabStop = false;
            this.StaffDetailsGroupBox.Text = "Guest Info";
            // 
            // vCountry
            // 
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
            this.vCountry.Location = new System.Drawing.Point(515, 196);
            this.vCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vCountry.Name = "vCountry";
            this.vCountry.Size = new System.Drawing.Size(270, 28);
            this.vCountry.TabIndex = 52;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(1223, 30);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(169, 43);
            this.bUpdate.TabIndex = 5;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(1223, 117);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(169, 40);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(1223, 200);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(169, 37);
            this.bCreate.TabIndex = 7;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(838, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Guest_ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(867, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            // 
            // iGuestID
            // 
            this.iGuestID.Location = new System.Drawing.Point(930, 196);
            this.iGuestID.Name = "iGuestID";
            this.iGuestID.Size = new System.Drawing.Size(270, 27);
            this.iGuestID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(797, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Postal/Zip Code*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Country*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Birth*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name*";
            // 
            // vAddress
            // 
            this.vAddress.AllowDrop = true;
            this.vAddress.Location = new System.Drawing.Point(515, 114);
            this.vAddress.Name = "vAddress";
            this.vAddress.Size = new System.Drawing.Size(270, 27);
            this.vAddress.TabIndex = 8;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Location = new System.Drawing.Point(515, 27);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(270, 27);
            this.dtDateOfBirth.TabIndex = 7;
            // 
            // iPostalCode
            // 
            this.iPostalCode.Location = new System.Drawing.Point(930, 27);
            this.iPostalCode.Name = "iPostalCode";
            this.iPostalCode.Size = new System.Drawing.Size(270, 27);
            this.iPostalCode.TabIndex = 6;
            // 
            // vEmail
            // 
            this.vEmail.Location = new System.Drawing.Point(930, 111);
            this.vEmail.Name = "vEmail";
            this.vEmail.Size = new System.Drawing.Size(270, 27);
            this.vEmail.TabIndex = 5;
            // 
            // iAge
            // 
            this.iAge.Location = new System.Drawing.Point(119, 197);
            this.iAge.Name = "iAge";
            this.iAge.Size = new System.Drawing.Size(270, 27);
            this.iAge.TabIndex = 2;
            // 
            // vLastName
            // 
            this.vLastName.Location = new System.Drawing.Point(119, 114);
            this.vLastName.Name = "vLastName";
            this.vLastName.Size = new System.Drawing.Size(270, 27);
            this.vLastName.TabIndex = 1;
            // 
            // vFirstName
            // 
            this.vFirstName.Location = new System.Drawing.Point(119, 27);
            this.vFirstName.Name = "vFirstName";
            this.vFirstName.Size = new System.Drawing.Size(270, 27);
            this.vFirstName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Room_ID*";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // iRoomID
            // 
            this.iRoomID.Location = new System.Drawing.Point(557, 361);
            this.iRoomID.Name = "iRoomID";
            this.iRoomID.Size = new System.Drawing.Size(270, 27);
            this.iRoomID.TabIndex = 4;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(833, 359);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(85, 30);
            this.bSearch.TabIndex = 13;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(924, 359);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(85, 30);
            this.bReset.TabIndex = 14;
            this.bReset.Text = "Refresh";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // guestTableAdapter2
            // 
            this.guestTableAdapter2.ClearBeforeFill = true;
            // 
            // GuestList
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 759);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.StaffDetailsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridGuestInfo);
            this.Controls.Add(this.iRoomID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGuestInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet1)).EndInit();
            this.StaffDetailsGroupBox.ResumeLayout(false);
            this.StaffDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView GridGuestInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StaffDetailsGroupBox;
        private System.Windows.Forms.ComboBox vCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vAddress;
        private System.Windows.Forms.TextBox dtDateOfBirth;
        private System.Windows.Forms.TextBox iPostalCode;
        private System.Windows.Forms.TextBox vEmail;
        private System.Windows.Forms.TextBox iRoomID;
        private System.Windows.Forms.TextBox iAge;
        private System.Windows.Forms.TextBox vLastName;
        private System.Windows.Forms.TextBox vFirstName;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox iGuestID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bReset;
        private SWENDatabaseDataSet1 sWENDatabaseDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private SWENDatabaseDataSet1TableAdapters.GuestTableAdapter guestTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
    }
}

