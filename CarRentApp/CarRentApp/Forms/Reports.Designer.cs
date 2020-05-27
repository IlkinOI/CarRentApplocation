namespace CarRentApp.Forms
{
    partial class Reports
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
            this.DtpReturnDateTo = new System.Windows.Forms.DateTimePicker();
            this.LblReturnDateTo = new System.Windows.Forms.Label();
            this.LblReturnDateFrom = new System.Windows.Forms.Label();
            this.DtpReturnDateFrom = new System.Windows.Forms.DateTimePicker();
            this.DtpRentDateTo = new System.Windows.Forms.DateTimePicker();
            this.LblRentTo = new System.Windows.Forms.Label();
            this.LblRentFrom = new System.Windows.Forms.Label();
            this.DtpRentDateFrom = new System.Windows.Forms.DateTimePicker();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GbRentDate = new System.Windows.Forms.GroupBox();
            this.GbReturnDate = new System.Windows.Forms.GroupBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DgvRentedCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GbRentDate.SuspendLayout();
            this.GbReturnDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRentedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpReturnDateTo
            // 
            this.DtpReturnDateTo.CustomFormat = "dd.MM.yyyy";
            this.DtpReturnDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReturnDateTo.Location = new System.Drawing.Point(208, 69);
            this.DtpReturnDateTo.Name = "DtpReturnDateTo";
            this.DtpReturnDateTo.Size = new System.Drawing.Size(163, 26);
            this.DtpReturnDateTo.TabIndex = 52;
            // 
            // LblReturnDateTo
            // 
            this.LblReturnDateTo.AutoSize = true;
            this.LblReturnDateTo.Location = new System.Drawing.Point(273, 36);
            this.LblReturnDateTo.Name = "LblReturnDateTo";
            this.LblReturnDateTo.Size = new System.Drawing.Size(35, 20);
            this.LblReturnDateTo.TabIndex = 51;
            this.LblReturnDateTo.Text = "To: ";
            // 
            // LblReturnDateFrom
            // 
            this.LblReturnDateFrom.AutoSize = true;
            this.LblReturnDateFrom.Location = new System.Drawing.Point(72, 36);
            this.LblReturnDateFrom.Name = "LblReturnDateFrom";
            this.LblReturnDateFrom.Size = new System.Drawing.Size(54, 20);
            this.LblReturnDateFrom.TabIndex = 50;
            this.LblReturnDateFrom.Text = "From: ";
            // 
            // DtpReturnDateFrom
            // 
            this.DtpReturnDateFrom.CustomFormat = "dd.MM.yyyy";
            this.DtpReturnDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReturnDateFrom.Location = new System.Drawing.Point(17, 69);
            this.DtpReturnDateFrom.Name = "DtpReturnDateFrom";
            this.DtpReturnDateFrom.Size = new System.Drawing.Size(163, 26);
            this.DtpReturnDateFrom.TabIndex = 49;
            // 
            // DtpRentDateTo
            // 
            this.DtpRentDateTo.CustomFormat = "dd.MM.yyyy";
            this.DtpRentDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentDateTo.Location = new System.Drawing.Point(208, 69);
            this.DtpRentDateTo.Name = "DtpRentDateTo";
            this.DtpRentDateTo.Size = new System.Drawing.Size(163, 26);
            this.DtpRentDateTo.TabIndex = 48;
            // 
            // LblRentTo
            // 
            this.LblRentTo.AutoSize = true;
            this.LblRentTo.Location = new System.Drawing.Point(273, 36);
            this.LblRentTo.Name = "LblRentTo";
            this.LblRentTo.Size = new System.Drawing.Size(35, 20);
            this.LblRentTo.TabIndex = 47;
            this.LblRentTo.Text = "To: ";
            // 
            // LblRentFrom
            // 
            this.LblRentFrom.AutoSize = true;
            this.LblRentFrom.Location = new System.Drawing.Point(71, 36);
            this.LblRentFrom.Name = "LblRentFrom";
            this.LblRentFrom.Size = new System.Drawing.Size(54, 20);
            this.LblRentFrom.TabIndex = 46;
            this.LblRentFrom.Text = "From: ";
            // 
            // DtpRentDateFrom
            // 
            this.DtpRentDateFrom.CustomFormat = "dd.MM.yyyy";
            this.DtpRentDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentDateFrom.Location = new System.Drawing.Point(19, 69);
            this.DtpRentDateFrom.Name = "DtpRentDateFrom";
            this.DtpRentDateFrom.Size = new System.Drawing.Size(163, 26);
            this.DtpRentDateFrom.TabIndex = 45;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(1066, 74);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(226, 44);
            this.BtnExcel.TabIndex = 72;
            this.BtnExcel.Text = "Convert To Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Location = new System.Drawing.Point(13, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(111, 20);
            this.LblAdmin.TabIndex = 71;
            this.LblAdmin.Text = "Administrator: ";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(17, 81);
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(226, 35);
            this.TxtSearch.TabIndex = 70;
            // 
            // GbRentDate
            // 
            this.GbRentDate.Controls.Add(this.DtpRentDateFrom);
            this.GbRentDate.Controls.Add(this.LblRentFrom);
            this.GbRentDate.Controls.Add(this.LblRentTo);
            this.GbRentDate.Controls.Add(this.DtpRentDateTo);
            this.GbRentDate.Location = new System.Drawing.Point(257, 12);
            this.GbRentDate.Name = "GbRentDate";
            this.GbRentDate.Size = new System.Drawing.Size(396, 106);
            this.GbRentDate.TabIndex = 73;
            this.GbRentDate.TabStop = false;
            this.GbRentDate.Text = "Rent Date";
            // 
            // GbReturnDate
            // 
            this.GbReturnDate.Controls.Add(this.LblReturnDateFrom);
            this.GbReturnDate.Controls.Add(this.DtpReturnDateFrom);
            this.GbReturnDate.Controls.Add(this.LblReturnDateTo);
            this.GbReturnDate.Controls.Add(this.DtpReturnDateTo);
            this.GbReturnDate.Location = new System.Drawing.Point(660, 12);
            this.GbReturnDate.Name = "GbReturnDate";
            this.GbReturnDate.Size = new System.Drawing.Size(396, 106);
            this.GbReturnDate.TabIndex = 74;
            this.GbReturnDate.TabStop = false;
            this.GbReturnDate.Text = "Return Date";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(95, 48);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(60, 20);
            this.LblSearch.TabIndex = 75;
            this.LblSearch.Text = "Search";
            // 
            // DgvRentedCars
            // 
            this.DgvRentedCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRentedCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column7,
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6});
            this.DgvRentedCars.Location = new System.Drawing.Point(17, 136);
            this.DgvRentedCars.Name = "DgvRentedCars";
            this.DgvRentedCars.RowHeadersWidth = 62;
            this.DgvRentedCars.RowTemplate.Height = 28;
            this.DgvRentedCars.Size = new System.Drawing.Size(1275, 501);
            this.DgvRentedCars.TabIndex = 76;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Car";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Car Reg. Number";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Surname";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rent Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Return Date";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Accepted Date";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1066, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(226, 47);
            this.BtnSearch.TabIndex = 77;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1314, 694);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgvRentedCars);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.GbReturnDate);
            this.Controls.Add(this.GbRentDate);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.TxtSearch);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.GbRentDate.ResumeLayout(false);
            this.GbRentDate.PerformLayout();
            this.GbReturnDate.ResumeLayout(false);
            this.GbReturnDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRentedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpReturnDateTo;
        private System.Windows.Forms.Label LblReturnDateTo;
        private System.Windows.Forms.Label LblReturnDateFrom;
        private System.Windows.Forms.DateTimePicker DtpReturnDateFrom;
        private System.Windows.Forms.DateTimePicker DtpRentDateTo;
        private System.Windows.Forms.Label LblRentTo;
        private System.Windows.Forms.Label LblRentFrom;
        private System.Windows.Forms.DateTimePicker DtpRentDateFrom;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.GroupBox GbRentDate;
        private System.Windows.Forms.GroupBox GbReturnDate;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridView DgvRentedCars;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}