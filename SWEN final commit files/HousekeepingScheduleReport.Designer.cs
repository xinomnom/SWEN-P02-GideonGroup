namespace SWENWindowForm
{
    partial class HousekeepingScheduleReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sWENDatabaseDataSet18 = new SWENWindowForm.SWENDatabaseDataSet18();
            this.staffTableAdapter = new SWENWindowForm.SWENDatabaseDataSet18TableAdapters.StaffTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FilterBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sWENDatabaseDataSet19 = new SWENWindowForm.SWENDatabaseDataSet19();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new SWENWindowForm.SWENDatabaseDataSet19TableAdapters.StaffTableAdapter();
            this.sWENDatabaseDataSet20 = new SWENWindowForm.SWENDatabaseDataSet20();
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter2 = new SWENWindowForm.SWENDatabaseDataSet20TableAdapters.StaffTableAdapter();
            this.FilterBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sWENDatabaseDataSet21 = new SWENWindowForm.SWENDatabaseDataSet21();
            this.staffBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter3 = new SWENWindowForm.SWENDatabaseDataSet21TableAdapters.StaffTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffFirstNameDataGridViewTextBoxColumn,
            this.staffLastNameDataGridViewTextBoxColumn,
            this.staffDutyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(252, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(698, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // staffDutyDataGridViewTextBoxColumn
            // 
            this.staffDutyDataGridViewTextBoxColumn.DataPropertyName = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.HeaderText = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.Name = "staffDutyDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.sWENDatabaseDataSet18;
            // 
            // sWENDatabaseDataSet18
            // 
            this.sWENDatabaseDataSet18.DataSetName = "SWENDatabaseDataSet18";
            this.sWENDatabaseDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label2.Location = new System.Drawing.Point(355, -90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 48);
            this.label2.TabIndex = 23;
            this.label2.Text = "House Keeping Schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(196, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 677);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Maintanence";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1242, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 677);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estate Maintanence";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(918, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 677);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Room Maintanence";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(555, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 677);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Security";
            // 
            // FilterBox2
            // 
            this.FilterBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBox2.FormattingEnabled = true;
            this.FilterBox2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.FilterBox2.Location = new System.Drawing.Point(12, 257);
            this.FilterBox2.Name = "FilterBox2";
            this.FilterBox2.Size = new System.Drawing.Size(178, 28);
            this.FilterBox2.TabIndex = 28;
            this.FilterBox2.SelectedIndexChanged += new System.EventHandler(this.FilterBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select the days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Staff Duties";
            // 
            // sWENDatabaseDataSet19
            // 
            this.sWENDatabaseDataSet19.DataSetName = "SWENDatabaseDataSet19";
            this.sWENDatabaseDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.sWENDatabaseDataSet19;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // sWENDatabaseDataSet20
            // 
            this.sWENDatabaseDataSet20.DataSetName = "SWENDatabaseDataSet20";
            this.sWENDatabaseDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "Staff";
            this.staffBindingSource2.DataSource = this.sWENDatabaseDataSet20;
            // 
            // staffTableAdapter2
            // 
            this.staffTableAdapter2.ClearBeforeFill = true;
            // 
            // FilterBox1
            // 
            this.FilterBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBox1.FormattingEnabled = true;
            this.FilterBox1.Items.AddRange(new object[] {
            "General maintenance",
            "Security",
            "Room maintenance",
            "Estate maintenance",
            "All"});
            this.FilterBox1.Location = new System.Drawing.Point(1003, 80);
            this.FilterBox1.Name = "FilterBox1";
            this.FilterBox1.Size = new System.Drawing.Size(208, 28);
            this.FilterBox1.TabIndex = 31;
            this.FilterBox1.SelectedIndexChanged += new System.EventHandler(this.FilterBox1_SelectedIndexChanged_1);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov ",
            "Dec"});
            this.comboBox2.Location = new System.Drawing.Point(12, 366);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 28);
            this.comboBox2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Select the month";
            // 
            // sWENDatabaseDataSet21
            // 
            this.sWENDatabaseDataSet21.DataSetName = "SWENDatabaseDataSet21";
            this.sWENDatabaseDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource3
            // 
            this.staffBindingSource3.DataMember = "Staff";
            this.staffBindingSource3.DataSource = this.sWENDatabaseDataSet21;
            // 
            // staffTableAdapter3
            // 
            this.staffTableAdapter3.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 49);
            this.button4.TabIndex = 34;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HousekeepingScheduleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1537, 987);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.FilterBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HousekeepingScheduleReport";
            this.Text = "HousekeepingReport";
            this.Load += new System.EventHandler(this.HousekeepingScheduleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWENDatabaseDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private SWENDatabaseDataSet18 sWENDatabaseDataSet18;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private SWENDatabaseDataSet18TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox FilterBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private SWENDatabaseDataSet19 sWENDatabaseDataSet19;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private SWENDatabaseDataSet19TableAdapters.StaffTableAdapter staffTableAdapter1;
        private SWENDatabaseDataSet20 sWENDatabaseDataSet20;
        private System.Windows.Forms.BindingSource staffBindingSource2;
        private SWENDatabaseDataSet20TableAdapters.StaffTableAdapter staffTableAdapter2;
        private System.Windows.Forms.ComboBox FilterBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private SWENDatabaseDataSet21 sWENDatabaseDataSet21;
        private System.Windows.Forms.BindingSource staffBindingSource3;
        private SWENDatabaseDataSet21TableAdapters.StaffTableAdapter staffTableAdapter3;
        private System.Windows.Forms.Button button4;
    }
}