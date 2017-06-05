namespace SWENWindowForm
{
    partial class BookingManagement
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblcustId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcheckin = new System.Windows.Forms.Label();
            this.BtnCreateCust = new System.Windows.Forms.Button();
            this.BtnDeleteCust = new System.Windows.Forms.Button();
            this.BtnUpdateCust = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ReservationPanel = new System.Windows.Forms.Panel();
            this.CustomeridCbox = new System.Windows.Forms.ComboBox();
            this.ChkinDate = new System.Windows.Forms.DateTimePicker();
            this.ChkoutDate = new System.Windows.Forms.DateTimePicker();
            this.BookingExtension = new System.Windows.Forms.TextBox();
            this.lblextension = new System.Windows.Forms.Label();
            this.RoomNumberCbox = new System.Windows.Forms.ComboBox();
            this.lblcheckout = new System.Windows.Forms.Label();
            this.sWENDatabaseDataSet14 = new SWENWindowForm.SWENDatabaseDataSet14();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new SWENWindowForm.SWENDatabaseDataSet14TableAdapters.BookingTableAdapter();
            this.sWENDatabaseDataSet15 = new SWENWindowForm.SWENDatabaseDataSet15();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter1 = new SWENWindowForm.SWENDatabaseDataSet15TableAdapters.BookingTableAdapter();
            this.sWENDatabaseDataSet16 = new SWENWindowForm.SWENDatabaseDataSet16();
            this.bookingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter2 = new SWENWindowForm.SWENDatabaseDataSet16TableAdapters.BookingTableAdapter();
            this.bookingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet17 = new SWENWindowForm.SWENDatabaseDataSet17();
            this.bookingTableAdapter3 = new SWENWindowForm.SWENDatabaseDataSet17TableAdapters.BookingTableAdapter();
            this.RoomSearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.sWENDatabaseDataSet22 = new SWENWindowForm.SWENDatabaseDataSet22();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new SWENWindowForm.SWENDatabaseDataSet22TableAdapters.RoomTableAdapter();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.roomNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIsavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet23 = new SWENWindowForm.SWENDatabaseDataSet23();
            this.roomTableAdapter1 = new SWENWindowForm.SWENDatabaseDataSet23TableAdapters.RoomTableAdapter();
            this.BookingTxtbox = new System.Windows.Forms.TextBox();
            this.BtnSearchBooking = new System.Windows.Forms.Button();
            this.bookingExtentionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingGridView = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.ReservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(-3, -1);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(112, 52);
            this.BackBtn.TabIndex = 59;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Reservation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblcustId
            // 
            this.LblcustId.AutoSize = true;
            this.LblcustId.Location = new System.Drawing.Point(10, 92);
            this.LblcustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblcustId.Name = "LblcustId";
            this.LblcustId.Size = new System.Drawing.Size(103, 20);
            this.LblcustId.TabIndex = 7;
            this.LblcustId.Text = "Customer ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Room Number:";
            // 
            // lblcheckin
            // 
            this.lblcheckin.AutoSize = true;
            this.lblcheckin.Location = new System.Drawing.Point(374, 41);
            this.lblcheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcheckin.Name = "lblcheckin";
            this.lblcheckin.Size = new System.Drawing.Size(109, 20);
            this.lblcheckin.TabIndex = 17;
            this.lblcheckin.Text = "Checkin Date:";
            // 
            // BtnCreateCust
            // 
            this.BtnCreateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateCust.Location = new System.Drawing.Point(593, 200);
            this.BtnCreateCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCreateCust.Name = "BtnCreateCust";
            this.BtnCreateCust.Size = new System.Drawing.Size(146, 52);
            this.BtnCreateCust.TabIndex = 27;
            this.BtnCreateCust.Text = "ADD";
            this.BtnCreateCust.UseVisualStyleBackColor = true;
            this.BtnCreateCust.Click += new System.EventHandler(this.btnCreateCust_Click);
            // 
            // BtnDeleteCust
            // 
            this.BtnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCust.Location = new System.Drawing.Point(189, 200);
            this.BtnDeleteCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteCust.Name = "BtnDeleteCust";
            this.BtnDeleteCust.Size = new System.Drawing.Size(146, 52);
            this.BtnDeleteCust.TabIndex = 55;
            this.BtnDeleteCust.Text = "DELETE";
            this.BtnDeleteCust.UseVisualStyleBackColor = true;
            this.BtnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // BtnUpdateCust
            // 
            this.BtnUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCust.Location = new System.Drawing.Point(14, 200);
            this.BtnUpdateCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUpdateCust.Name = "BtnUpdateCust";
            this.BtnUpdateCust.Size = new System.Drawing.Size(146, 52);
            this.BtnUpdateCust.TabIndex = 56;
            this.BtnUpdateCust.Text = "UPDATE";
            this.BtnUpdateCust.UseVisualStyleBackColor = true;
            this.BtnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(357, 200);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(213, 52);
            this.BtnClear.TabIndex = 58;
            this.BtnClear.Text = "CLEAR FORM";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ReservationPanel
            // 
            this.ReservationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReservationPanel.Controls.Add(this.CustomeridCbox);
            this.ReservationPanel.Controls.Add(this.ChkinDate);
            this.ReservationPanel.Controls.Add(this.ChkoutDate);
            this.ReservationPanel.Controls.Add(this.BookingExtension);
            this.ReservationPanel.Controls.Add(this.lblextension);
            this.ReservationPanel.Controls.Add(this.RoomNumberCbox);
            this.ReservationPanel.Controls.Add(this.lblcheckout);
            this.ReservationPanel.Controls.Add(this.BtnClear);
            this.ReservationPanel.Controls.Add(this.BtnUpdateCust);
            this.ReservationPanel.Controls.Add(this.BtnDeleteCust);
            this.ReservationPanel.Controls.Add(this.BtnCreateCust);
            this.ReservationPanel.Controls.Add(this.lblcheckin);
            this.ReservationPanel.Controls.Add(this.label6);
            this.ReservationPanel.Controls.Add(this.LblcustId);
            this.ReservationPanel.Controls.Add(this.label1);
            this.ReservationPanel.Location = new System.Drawing.Point(187, 266);
            this.ReservationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReservationPanel.Name = "ReservationPanel";
            this.ReservationPanel.Size = new System.Drawing.Size(765, 271);
            this.ReservationPanel.TabIndex = 3;
            this.ReservationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // CustomeridCbox
            // 
            this.CustomeridCbox.FormattingEnabled = true;
            this.CustomeridCbox.Location = new System.Drawing.Point(154, 89);
            this.CustomeridCbox.Name = "CustomeridCbox";
            this.CustomeridCbox.Size = new System.Drawing.Size(181, 28);
            this.CustomeridCbox.TabIndex = 74;
            // 
            // ChkinDate
            // 
            this.ChkinDate.CustomFormat = "dd-MM-yyyy";
            this.ChkinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChkinDate.Location = new System.Drawing.Point(524, 39);
            this.ChkinDate.Name = "ChkinDate";
            this.ChkinDate.Size = new System.Drawing.Size(181, 26);
            this.ChkinDate.TabIndex = 73;
            this.ChkinDate.Value = new System.DateTime(2017, 6, 3, 0, 0, 0, 0);
            // 
            // ChkoutDate
            // 
            this.ChkoutDate.CustomFormat = "dd-MM-yyyy";
            this.ChkoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChkoutDate.Location = new System.Drawing.Point(524, 80);
            this.ChkoutDate.Name = "ChkoutDate";
            this.ChkoutDate.Size = new System.Drawing.Size(181, 26);
            this.ChkoutDate.TabIndex = 72;
            this.ChkoutDate.Value = new System.DateTime(2017, 6, 3, 0, 0, 0, 0);
            // 
            // BookingExtension
            // 
            this.BookingExtension.Location = new System.Drawing.Point(524, 130);
            this.BookingExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingExtension.Name = "BookingExtension";
            this.BookingExtension.Size = new System.Drawing.Size(181, 26);
            this.BookingExtension.TabIndex = 67;
            // 
            // lblextension
            // 
            this.lblextension.AutoSize = true;
            this.lblextension.Location = new System.Drawing.Point(374, 136);
            this.lblextension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblextension.Name = "lblextension";
            this.lblextension.Size = new System.Drawing.Size(142, 20);
            this.lblextension.TabIndex = 66;
            this.lblextension.Text = "Booking Extention:";
            // 
            // RoomNumberCbox
            // 
            this.RoomNumberCbox.FormattingEnabled = true;
            this.RoomNumberCbox.Location = new System.Drawing.Point(154, 44);
            this.RoomNumberCbox.Name = "RoomNumberCbox";
            this.RoomNumberCbox.Size = new System.Drawing.Size(181, 28);
            this.RoomNumberCbox.TabIndex = 61;
            this.RoomNumberCbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblcheckout
            // 
            this.lblcheckout.AutoSize = true;
            this.lblcheckout.Location = new System.Drawing.Point(374, 86);
            this.lblcheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcheckout.Name = "lblcheckout";
            this.lblcheckout.Size = new System.Drawing.Size(120, 20);
            this.lblcheckout.TabIndex = 59;
            this.lblcheckout.Text = "Checkout Date:";
            // 
            // sWENDatabaseDataSet14
            // 
            this.sWENDatabaseDataSet14.DataSetName = "SWENDatabaseDataSet14";
            this.sWENDatabaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.sWENDatabaseDataSet14;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // sWENDatabaseDataSet15
            // 
            this.sWENDatabaseDataSet15.DataSetName = "SWENDatabaseDataSet15";
            this.sWENDatabaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.sWENDatabaseDataSet15;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // sWENDatabaseDataSet16
            // 
            this.sWENDatabaseDataSet16.DataSetName = "SWENDatabaseDataSet16";
            this.sWENDatabaseDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource2
            // 
            this.bookingBindingSource2.DataMember = "Booking";
            this.bookingBindingSource2.DataSource = this.sWENDatabaseDataSet16;
            // 
            // bookingTableAdapter2
            // 
            this.bookingTableAdapter2.ClearBeforeFill = true;
            // 
            // bookingBindingSource3
            // 
            this.bookingBindingSource3.DataMember = "Booking";
            this.bookingBindingSource3.DataSource = this.sWENDatabaseDataSet17;
            // 
            // sWENDatabaseDataSet17
            // 
            this.sWENDatabaseDataSet17.DataSetName = "SWENDatabaseDataSet17";
            this.sWENDatabaseDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter3
            // 
            this.bookingTableAdapter3.ClearBeforeFill = true;
            // 
            // RoomSearchBox
            // 
            this.RoomSearchBox.Location = new System.Drawing.Point(187, 43);
            this.RoomSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomSearchBox.Name = "RoomSearchBox";
            this.RoomSearchBox.Size = new System.Drawing.Size(268, 26);
            this.RoomSearchBox.TabIndex = 63;
            this.RoomSearchBox.Text = "Enter Room Number";
            this.RoomSearchBox.TextChanged += new System.EventHandler(this.RoomsearchBox_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(474, 43);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(92, 33);
            this.SearchBtn.TabIndex = 64;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // sWENDatabaseDataSet22
            // 
            this.sWENDatabaseDataSet22.DataSetName = "SWENDatabaseDataSet22";
            this.sWENDatabaseDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.sWENDatabaseDataSet22;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // RoomGridView
            // 
            this.RoomGridView.AutoGenerateColumns = false;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNoDataGridViewTextBoxColumn1,
            this.roomSizeDataGridViewTextBoxColumn,
            this.roomCategoryDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.vIsavailableDataGridViewTextBoxColumn});
            this.RoomGridView.DataSource = this.roomBindingSource1;
            this.RoomGridView.Location = new System.Drawing.Point(187, 90);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowTemplate.Height = 28;
            this.RoomGridView.Size = new System.Drawing.Size(764, 150);
            this.RoomGridView.TabIndex = 65;
            // 
            // roomNoDataGridViewTextBoxColumn1
            // 
            this.roomNoDataGridViewTextBoxColumn1.DataPropertyName = "Room_No";
            this.roomNoDataGridViewTextBoxColumn1.HeaderText = "Room_No";
            this.roomNoDataGridViewTextBoxColumn1.Name = "roomNoDataGridViewTextBoxColumn1";
            // 
            // roomSizeDataGridViewTextBoxColumn
            // 
            this.roomSizeDataGridViewTextBoxColumn.DataPropertyName = "Room_Size";
            this.roomSizeDataGridViewTextBoxColumn.HeaderText = "Room_Size";
            this.roomSizeDataGridViewTextBoxColumn.Name = "roomSizeDataGridViewTextBoxColumn";
            // 
            // roomCategoryDataGridViewTextBoxColumn
            // 
            this.roomCategoryDataGridViewTextBoxColumn.DataPropertyName = "Room_Category";
            this.roomCategoryDataGridViewTextBoxColumn.HeaderText = "Room_Category";
            this.roomCategoryDataGridViewTextBoxColumn.Name = "roomCategoryDataGridViewTextBoxColumn";
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Price";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "Room_Price";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            // 
            // vIsavailableDataGridViewTextBoxColumn
            // 
            this.vIsavailableDataGridViewTextBoxColumn.DataPropertyName = "vIsavailable";
            this.vIsavailableDataGridViewTextBoxColumn.HeaderText = "vIsavailable";
            this.vIsavailableDataGridViewTextBoxColumn.Name = "vIsavailableDataGridViewTextBoxColumn";
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataMember = "Room";
            this.roomBindingSource1.DataSource = this.sWENDatabaseDataSet23;
            // 
            // sWENDatabaseDataSet23
            // 
            this.sWENDatabaseDataSet23.DataSetName = "SWENDatabaseDataSet23";
            this.sWENDatabaseDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // BookingTxtbox
            // 
            this.BookingTxtbox.Location = new System.Drawing.Point(188, 571);
            this.BookingTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingTxtbox.Name = "BookingTxtbox";
            this.BookingTxtbox.Size = new System.Drawing.Size(268, 26);
            this.BookingTxtbox.TabIndex = 66;
            this.BookingTxtbox.Text = "Enter Booking Number";
            this.BookingTxtbox.TextChanged += new System.EventHandler(this.RoomNotxtbox_TextChanged);
            // 
            // BtnSearchBooking
            // 
            this.BtnSearchBooking.Location = new System.Drawing.Point(474, 571);
            this.BtnSearchBooking.Name = "BtnSearchBooking";
            this.BtnSearchBooking.Size = new System.Drawing.Size(92, 33);
            this.BtnSearchBooking.TabIndex = 67;
            this.BtnSearchBooking.Text = "SEARCH";
            this.BtnSearchBooking.UseVisualStyleBackColor = true;
            this.BtnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // bookingExtentionDataGridViewTextBoxColumn
            // 
            this.bookingExtentionDataGridViewTextBoxColumn.DataPropertyName = "Booking_Extention";
            this.bookingExtentionDataGridViewTextBoxColumn.HeaderText = "Booking_Extention";
            this.bookingExtentionDataGridViewTextBoxColumn.Name = "bookingExtentionDataGridViewTextBoxColumn";
            // 
            // bookingEndDateDataGridViewTextBoxColumn
            // 
            this.bookingEndDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_EndDate";
            this.bookingEndDateDataGridViewTextBoxColumn.HeaderText = "Booking_EndDate";
            this.bookingEndDateDataGridViewTextBoxColumn.Name = "bookingEndDateDataGridViewTextBoxColumn";
            // 
            // bookingStartDateDataGridViewTextBoxColumn
            // 
            this.bookingStartDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_StartDate";
            this.bookingStartDateDataGridViewTextBoxColumn.HeaderText = "Booking_StartDate";
            this.bookingStartDateDataGridViewTextBoxColumn.Name = "bookingStartDateDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room_No";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookingGridView
            // 
            this.BookingGridView.AutoGenerateColumns = false;
            this.BookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.bookingStartDateDataGridViewTextBoxColumn,
            this.bookingEndDateDataGridViewTextBoxColumn,
            this.bookingExtentionDataGridViewTextBoxColumn});
            this.BookingGridView.DataSource = this.bookingBindingSource3;
            this.BookingGridView.Location = new System.Drawing.Point(187, 619);
            this.BookingGridView.Name = "BookingGridView";
            this.BookingGridView.RowTemplate.Height = 28;
            this.BookingGridView.Size = new System.Drawing.Size(765, 150);
            this.BookingGridView.TabIndex = 62;
            this.BookingGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingGridView_CellContentDoubleClick);
            this.BookingGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookingGridView_CellMouseDoubleClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(590, 571);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(114, 33);
            this.BtnRefresh.TabIndex = 68;
            this.BtnRefresh.Text = "REFRESH";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 868);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSearchBooking);
            this.Controls.Add(this.BookingTxtbox);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.RoomSearchBox);
            this.Controls.Add(this.BookingGridView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ReservationPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookingManagement";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.BookingManagement_Load);
            this.ReservationPanel.ResumeLayout(false);
            this.ReservationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblcustId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcheckin;
        private System.Windows.Forms.Button BtnCreateCust;
        private System.Windows.Forms.Button BtnDeleteCust;
        private System.Windows.Forms.Button BtnUpdateCust;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel ReservationPanel;
        private System.Windows.Forms.Label lblcheckout;
        private SWENDatabaseDataSet14 sWENDatabaseDataSet14;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private SWENDatabaseDataSet14TableAdapters.BookingTableAdapter bookingTableAdapter;
        private SWENDatabaseDataSet15 sWENDatabaseDataSet15;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private SWENDatabaseDataSet15TableAdapters.BookingTableAdapter bookingTableAdapter1;
        private SWENDatabaseDataSet16 sWENDatabaseDataSet16;
        private System.Windows.Forms.BindingSource bookingBindingSource2;
        private SWENDatabaseDataSet16TableAdapters.BookingTableAdapter bookingTableAdapter2;
        private System.Windows.Forms.ComboBox RoomNumberCbox;
        private System.Windows.Forms.Label lblextension;
        private System.Windows.Forms.TextBox BookingExtension;
        private System.Windows.Forms.DateTimePicker ChkinDate;
        private System.Windows.Forms.DateTimePicker ChkoutDate;
        private SWENDatabaseDataSet17 sWENDatabaseDataSet17;
        private System.Windows.Forms.BindingSource bookingBindingSource3;
        private SWENDatabaseDataSet17TableAdapters.BookingTableAdapter bookingTableAdapter3;
        private System.Windows.Forms.ComboBox CustomeridCbox;
        private System.Windows.Forms.TextBox RoomSearchBox;
        private System.Windows.Forms.Button SearchBtn;
        private SWENDatabaseDataSet22 sWENDatabaseDataSet22;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private SWENDatabaseDataSet22TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridView RoomGridView;
        private SWENDatabaseDataSet23 sWENDatabaseDataSet23;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private SWENDatabaseDataSet23TableAdapters.RoomTableAdapter roomTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIsavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox BookingTxtbox;
        private System.Windows.Forms.Button BtnSearchBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingExtentionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView BookingGridView;
        private System.Windows.Forms.Button BtnRefresh;
    }
}