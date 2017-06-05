namespace SWENWindowForm
{
    partial class GuestStatusReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.GuestStatusGrid = new System.Windows.Forms.DataGridView();
            this.bEachGuest = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bAllGuest = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guestDataSet = new SWENWindowForm.GuestDataSet();
            this.guestTableAdapter = new SWENWindowForm.GuestDataSetTableAdapters.GuestTableAdapter();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestStatusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Status";
            // 
            // GuestStatusGrid
            // 
            this.GuestStatusGrid.AutoGenerateColumns = false;
            this.GuestStatusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestStatusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestIDDataGridViewTextBoxColumn,
            this.guestFirstNameDataGridViewTextBoxColumn,
            this.guestLastNameDataGridViewTextBoxColumn,
            this.guestAgeDataGridViewTextBoxColumn,
            this.guestDOBDataGridViewTextBoxColumn,
            this.guestAddressDataGridViewTextBoxColumn,
            this.guestCountryDataGridViewTextBoxColumn,
            this.guestPostalCodeDataGridViewTextBoxColumn,
            this.guestEmailDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn});
            this.GuestStatusGrid.DataSource = this.bindingSource1;
            this.GuestStatusGrid.Location = new System.Drawing.Point(24, 99);
            this.GuestStatusGrid.Name = "GuestStatusGrid";
            this.GuestStatusGrid.RowTemplate.Height = 28;
            this.GuestStatusGrid.Size = new System.Drawing.Size(1033, 404);
            this.GuestStatusGrid.TabIndex = 1;
            // 
            // bEachGuest
            // 
            this.bEachGuest.Location = new System.Drawing.Point(347, 509);
            this.bEachGuest.Name = "bEachGuest";
            this.bEachGuest.Size = new System.Drawing.Size(148, 49);
            this.bEachGuest.TabIndex = 2;
            this.bEachGuest.Text = "Guests Per Room";
            this.bEachGuest.UseVisualStyleBackColor = true;
            this.bEachGuest.Click += new System.EventHandler(this.bEachGuest_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(12, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(128, 59);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bAllGuest
            // 
            this.bAllGuest.Location = new System.Drawing.Point(626, 509);
            this.bAllGuest.Name = "bAllGuest";
            this.bAllGuest.Size = new System.Drawing.Size(122, 49);
            this.bAllGuest.TabIndex = 5;
            this.bAllGuest.Text = "All Guests";
            this.bAllGuest.UseVisualStyleBackColor = true;
            this.bAllGuest.Click += new System.EventHandler(this.bAllGuest_Click);
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
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "Guest_ID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "Guest_ID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            // 
            // guestFirstNameDataGridViewTextBoxColumn
            // 
            this.guestFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Guest_FirstName";
            this.guestFirstNameDataGridViewTextBoxColumn.HeaderText = "Guest_FirstName";
            this.guestFirstNameDataGridViewTextBoxColumn.Name = "guestFirstNameDataGridViewTextBoxColumn";
            // 
            // guestLastNameDataGridViewTextBoxColumn
            // 
            this.guestLastNameDataGridViewTextBoxColumn.DataPropertyName = "Guest_LastName";
            this.guestLastNameDataGridViewTextBoxColumn.HeaderText = "Guest_LastName";
            this.guestLastNameDataGridViewTextBoxColumn.Name = "guestLastNameDataGridViewTextBoxColumn";
            // 
            // guestAgeDataGridViewTextBoxColumn
            // 
            this.guestAgeDataGridViewTextBoxColumn.DataPropertyName = "Guest_Age";
            this.guestAgeDataGridViewTextBoxColumn.HeaderText = "Guest_Age";
            this.guestAgeDataGridViewTextBoxColumn.Name = "guestAgeDataGridViewTextBoxColumn";
            // 
            // guestDOBDataGridViewTextBoxColumn
            // 
            this.guestDOBDataGridViewTextBoxColumn.DataPropertyName = "Guest_DOB";
            this.guestDOBDataGridViewTextBoxColumn.HeaderText = "Guest_DOB";
            this.guestDOBDataGridViewTextBoxColumn.Name = "guestDOBDataGridViewTextBoxColumn";
            // 
            // guestAddressDataGridViewTextBoxColumn
            // 
            this.guestAddressDataGridViewTextBoxColumn.DataPropertyName = "Guest_Address";
            this.guestAddressDataGridViewTextBoxColumn.HeaderText = "Guest_Address";
            this.guestAddressDataGridViewTextBoxColumn.Name = "guestAddressDataGridViewTextBoxColumn";
            // 
            // guestCountryDataGridViewTextBoxColumn
            // 
            this.guestCountryDataGridViewTextBoxColumn.DataPropertyName = "Guest_Country";
            this.guestCountryDataGridViewTextBoxColumn.HeaderText = "Guest_Country";
            this.guestCountryDataGridViewTextBoxColumn.Name = "guestCountryDataGridViewTextBoxColumn";
            // 
            // guestPostalCodeDataGridViewTextBoxColumn
            // 
            this.guestPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Guest_PostalCode";
            this.guestPostalCodeDataGridViewTextBoxColumn.HeaderText = "Guest_PostalCode";
            this.guestPostalCodeDataGridViewTextBoxColumn.Name = "guestPostalCodeDataGridViewTextBoxColumn";
            // 
            // guestEmailDataGridViewTextBoxColumn
            // 
            this.guestEmailDataGridViewTextBoxColumn.DataPropertyName = "Guest_Email";
            this.guestEmailDataGridViewTextBoxColumn.HeaderText = "Guest_Email";
            this.guestEmailDataGridViewTextBoxColumn.Name = "guestEmailDataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room_No";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // iRoomNo
            // 
            this.iRoomNo.Location = new System.Drawing.Point(241, 520);
            this.iRoomNo.Name = "iRoomNo";
            this.iRoomNo.Size = new System.Drawing.Size(100, 26);
            this.iRoomNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room No";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(881, 28);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(122, 49);
            this.bRefresh.TabIndex = 8;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // GuestStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 582);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iRoomNo);
            this.Controls.Add(this.bAllGuest);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEachGuest);
            this.Controls.Add(this.GuestStatusGrid);
            this.Controls.Add(this.label1);
            this.Name = "GuestStatusReport";
            this.Text = "GuestStatusReport";
            this.Load += new System.EventHandler(this.GuestStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GuestStatusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GuestStatusGrid;
        private System.Windows.Forms.Button bEachGuest;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bAllGuest;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GuestDataSet guestDataSet;
        private GuestDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox iRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRefresh;
    }
}