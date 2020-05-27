namespace CarRentApp.Forms
{
    partial class NewRent
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
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.CbName = new System.Windows.Forms.ComboBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.LblAddCustomer = new System.Windows.Forms.Label();
            this.GbCustomer = new System.Windows.Forms.GroupBox();
            this.LblManEmail = new System.Windows.Forms.Label();
            this.LblManPhone = new System.Windows.Forms.Label();
            this.LblManId = new System.Windows.Forms.Label();
            this.LblCustomerSurname = new System.Windows.Forms.Label();
            this.CbSurname = new System.Windows.Forms.ComboBox();
            this.GbCar = new System.Windows.Forms.GroupBox();
            this.CbRegNum = new System.Windows.Forms.ComboBox();
            this.LblRegNum = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblEngine = new System.Windows.Forms.Label();
            this.CbModel = new System.Windows.Forms.ComboBox();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblNewCar = new System.Windows.Forms.Label();
            this.CbBrand = new System.Windows.Forms.ComboBox();
            this.BtnAddCar = new System.Windows.Forms.Button();
            this.LblCarBrand = new System.Windows.Forms.Label();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.GbDate = new System.Windows.Forms.GroupBox();
            this.BtnRent = new System.Windows.Forms.Button();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.LblTo = new System.Windows.Forms.Label();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.LblWarning = new System.Windows.Forms.Label();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.GbCustomer.SuspendLayout();
            this.GbCar.SuspendLayout();
            this.GbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(70, 33);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(104, 20);
            this.LblCustomerName.TabIndex = 0;
            this.LblCustomerName.Text = "Select Name:";
            // 
            // CbName
            // 
            this.CbName.FormattingEnabled = true;
            this.CbName.Location = new System.Drawing.Point(38, 70);
            this.CbName.Name = "CbName";
            this.CbName.Size = new System.Drawing.Size(171, 28);
            this.CbName.TabIndex = 1;
            this.CbName.SelectedIndexChanged += new System.EventHandler(this.CbName_SelectedIndexChanged);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(38, 160);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(171, 51);
            this.BtnAddCustomer.TabIndex = 2;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.CustomFormat = "dd.MM.yyyy";
            this.DtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentDate.Location = new System.Drawing.Point(22, 70);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(200, 26);
            this.DtpRentDate.TabIndex = 3;
            // 
            // LblAddCustomer
            // 
            this.LblAddCustomer.AutoSize = true;
            this.LblAddCustomer.Location = new System.Drawing.Point(62, 122);
            this.LblAddCustomer.Name = "LblAddCustomer";
            this.LblAddCustomer.Size = new System.Drawing.Size(122, 20);
            this.LblAddCustomer.TabIndex = 4;
            this.LblAddCustomer.Text = "New Customer?";
            // 
            // GbCustomer
            // 
            this.GbCustomer.Controls.Add(this.LblManEmail);
            this.GbCustomer.Controls.Add(this.LblManPhone);
            this.GbCustomer.Controls.Add(this.LblManId);
            this.GbCustomer.Controls.Add(this.LblCustomerSurname);
            this.GbCustomer.Controls.Add(this.CbSurname);
            this.GbCustomer.Controls.Add(this.BtnAddCustomer);
            this.GbCustomer.Controls.Add(this.LblAddCustomer);
            this.GbCustomer.Controls.Add(this.LblCustomerName);
            this.GbCustomer.Controls.Add(this.CbName);
            this.GbCustomer.Location = new System.Drawing.Point(15, 294);
            this.GbCustomer.Name = "GbCustomer";
            this.GbCustomer.Size = new System.Drawing.Size(434, 265);
            this.GbCustomer.TabIndex = 5;
            this.GbCustomer.TabStop = false;
            this.GbCustomer.Text = "Choose Customer";
            // 
            // LblManEmail
            // 
            this.LblManEmail.AutoSize = true;
            this.LblManEmail.Location = new System.Drawing.Point(244, 191);
            this.LblManEmail.Name = "LblManEmail";
            this.LblManEmail.Size = new System.Drawing.Size(56, 20);
            this.LblManEmail.TabIndex = 19;
            this.LblManEmail.Text = "Email: ";
            // 
            // LblManPhone
            // 
            this.LblManPhone.AutoSize = true;
            this.LblManPhone.Location = new System.Drawing.Point(244, 155);
            this.LblManPhone.Name = "LblManPhone";
            this.LblManPhone.Size = new System.Drawing.Size(63, 20);
            this.LblManPhone.TabIndex = 18;
            this.LblManPhone.Text = "Phone: ";
            // 
            // LblManId
            // 
            this.LblManId.AutoSize = true;
            this.LblManId.Location = new System.Drawing.Point(244, 122);
            this.LblManId.Name = "LblManId";
            this.LblManId.Size = new System.Drawing.Size(30, 20);
            this.LblManId.TabIndex = 17;
            this.LblManId.Text = "ID:";
            // 
            // LblCustomerSurname
            // 
            this.LblCustomerSurname.AutoSize = true;
            this.LblCustomerSurname.Location = new System.Drawing.Point(244, 33);
            this.LblCustomerSurname.Name = "LblCustomerSurname";
            this.LblCustomerSurname.Size = new System.Drawing.Size(127, 20);
            this.LblCustomerSurname.TabIndex = 6;
            this.LblCustomerSurname.Text = "Select Surname:";
            // 
            // CbSurname
            // 
            this.CbSurname.FormattingEnabled = true;
            this.CbSurname.Location = new System.Drawing.Point(223, 70);
            this.CbSurname.Name = "CbSurname";
            this.CbSurname.Size = new System.Drawing.Size(171, 28);
            this.CbSurname.TabIndex = 5;
            this.CbSurname.SelectedIndexChanged += new System.EventHandler(this.CbSurname_SelectedIndexChanged);
            // 
            // GbCar
            // 
            this.GbCar.Controls.Add(this.BtnDashBoard);
            this.GbCar.Controls.Add(this.CbRegNum);
            this.GbCar.Controls.Add(this.LblRegNum);
            this.GbCar.Controls.Add(this.LblPrice);
            this.GbCar.Controls.Add(this.LblYear);
            this.GbCar.Controls.Add(this.LblEngine);
            this.GbCar.Controls.Add(this.CbModel);
            this.GbCar.Controls.Add(this.LblModel);
            this.GbCar.Controls.Add(this.LblNewCar);
            this.GbCar.Controls.Add(this.CbBrand);
            this.GbCar.Controls.Add(this.BtnAddCar);
            this.GbCar.Controls.Add(this.LblCarBrand);
            this.GbCar.Location = new System.Drawing.Point(15, 49);
            this.GbCar.Name = "GbCar";
            this.GbCar.Size = new System.Drawing.Size(693, 239);
            this.GbCar.TabIndex = 6;
            this.GbCar.TabStop = false;
            this.GbCar.Text = "Select Car";
            // 
            // CbRegNum
            // 
            this.CbRegNum.FormattingEnabled = true;
            this.CbRegNum.Location = new System.Drawing.Point(474, 70);
            this.CbRegNum.Name = "CbRegNum";
            this.CbRegNum.Size = new System.Drawing.Size(171, 28);
            this.CbRegNum.TabIndex = 18;
            // 
            // LblRegNum
            // 
            this.LblRegNum.AutoSize = true;
            this.LblRegNum.Location = new System.Drawing.Point(492, 33);
            this.LblRegNum.Name = "LblRegNum";
            this.LblRegNum.Size = new System.Drawing.Size(125, 20);
            this.LblRegNum.TabIndex = 17;
            this.LblRegNum.Text = "Select Reg.Num";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(258, 191);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(52, 20);
            this.LblPrice.TabIndex = 16;
            this.LblPrice.Text = "Price: ";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(259, 160);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(51, 20);
            this.LblYear.TabIndex = 15;
            this.LblYear.Text = "Year: ";
            // 
            // LblEngine
            // 
            this.LblEngine.AutoSize = true;
            this.LblEngine.Location = new System.Drawing.Point(258, 126);
            this.LblEngine.Name = "LblEngine";
            this.LblEngine.Size = new System.Drawing.Size(67, 20);
            this.LblEngine.TabIndex = 14;
            this.LblEngine.Text = "Engine: ";
            // 
            // CbModel
            // 
            this.CbModel.FormattingEnabled = true;
            this.CbModel.Location = new System.Drawing.Point(258, 70);
            this.CbModel.Name = "CbModel";
            this.CbModel.Size = new System.Drawing.Size(171, 28);
            this.CbModel.TabIndex = 13;
            this.CbModel.SelectedIndexChanged += new System.EventHandler(this.CbModel_SelectedIndexChanged);
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Location = new System.Drawing.Point(290, 33);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(105, 20);
            this.LblModel.TabIndex = 12;
            this.LblModel.Text = "Select Model:";
            // 
            // LblNewCar
            // 
            this.LblNewCar.AutoSize = true;
            this.LblNewCar.Location = new System.Drawing.Point(84, 126);
            this.LblNewCar.Name = "LblNewCar";
            this.LblNewCar.Size = new System.Drawing.Size(78, 20);
            this.LblNewCar.TabIndex = 10;
            this.LblNewCar.Text = "New Car?";
            // 
            // CbBrand
            // 
            this.CbBrand.FormattingEnabled = true;
            this.CbBrand.Location = new System.Drawing.Point(38, 70);
            this.CbBrand.Name = "CbBrand";
            this.CbBrand.Size = new System.Drawing.Size(171, 28);
            this.CbBrand.TabIndex = 8;
            this.CbBrand.SelectedIndexChanged += new System.EventHandler(this.CbBrand_SelectedIndexChanged);
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.Location = new System.Drawing.Point(38, 160);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(171, 51);
            this.BtnAddCar.TabIndex = 9;
            this.BtnAddCar.Text = "Add New Car";
            this.BtnAddCar.UseVisualStyleBackColor = true;
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // LblCarBrand
            // 
            this.LblCarBrand.AutoSize = true;
            this.LblCarBrand.Location = new System.Drawing.Point(69, 33);
            this.LblCarBrand.Name = "LblCarBrand";
            this.LblCarBrand.Size = new System.Drawing.Size(105, 20);
            this.LblCarBrand.TabIndex = 7;
            this.LblCarBrand.Text = "Select Brand:";
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Location = new System.Drawing.Point(94, 33);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(54, 20);
            this.LblRentDate.TabIndex = 13;
            this.LblRentDate.Text = "From: ";
            // 
            // GbDate
            // 
            this.GbDate.Controls.Add(this.BtnRent);
            this.GbDate.Controls.Add(this.DtpReturnDate);
            this.GbDate.Controls.Add(this.LblTo);
            this.GbDate.Controls.Add(this.LblRentDate);
            this.GbDate.Controls.Add(this.DtpRentDate);
            this.GbDate.Location = new System.Drawing.Point(467, 302);
            this.GbDate.Name = "GbDate";
            this.GbDate.Size = new System.Drawing.Size(241, 257);
            this.GbDate.TabIndex = 14;
            this.GbDate.TabStop = false;
            this.GbDate.Text = "Select Rent Date";
            // 
            // BtnRent
            // 
            this.BtnRent.Location = new System.Drawing.Point(34, 205);
            this.BtnRent.Name = "BtnRent";
            this.BtnRent.Size = new System.Drawing.Size(171, 37);
            this.BtnRent.TabIndex = 17;
            this.BtnRent.Text = "Rent A Car";
            this.BtnRent.UseVisualStyleBackColor = true;
            this.BtnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.CustomFormat = "dd.MM.yyyy";
            this.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpReturnDate.Location = new System.Drawing.Point(22, 154);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(200, 26);
            this.DtpReturnDate.TabIndex = 15;
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Location = new System.Drawing.Point(103, 122);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(35, 20);
            this.LblTo.TabIndex = 14;
            this.LblTo.Text = "To: ";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Location = new System.Drawing.Point(25, 18);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(111, 20);
            this.LblAdmin.TabIndex = 42;
            this.LblAdmin.Text = "Administrator: ";
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(280, 18);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 20);
            this.LblWarning.TabIndex = 43;
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.Location = new System.Drawing.Point(474, 160);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Size = new System.Drawing.Size(171, 51);
            this.BtnDashBoard.TabIndex = 19;
            this.BtnDashBoard.Text = "To Dashboard";
            this.BtnDashBoard.UseVisualStyleBackColor = true;
            this.BtnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // NewRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 600);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.GbDate);
            this.Controls.Add(this.GbCar);
            this.Controls.Add(this.GbCustomer);
            this.Name = "NewRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent a Car And Keep Smiling";
            this.GbCustomer.ResumeLayout(false);
            this.GbCustomer.PerformLayout();
            this.GbCar.ResumeLayout(false);
            this.GbCar.PerformLayout();
            this.GbDate.ResumeLayout(false);
            this.GbDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.ComboBox CbName;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.Label LblAddCustomer;
        private System.Windows.Forms.GroupBox GbCustomer;
        private System.Windows.Forms.GroupBox GbCar;
        private System.Windows.Forms.ComboBox CbModel;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblNewCar;
        private System.Windows.Forms.ComboBox CbBrand;
        private System.Windows.Forms.Button BtnAddCar;
        private System.Windows.Forms.Label LblCarBrand;
        private System.Windows.Forms.Label LblRentDate;
        private System.Windows.Forms.Label LblEngine;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.GroupBox GbDate;
        private System.Windows.Forms.Button BtnRent;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Label LblCustomerSurname;
        private System.Windows.Forms.ComboBox CbSurname;
        private System.Windows.Forms.Label LblManId;
        private System.Windows.Forms.Label LblManEmail;
        private System.Windows.Forms.Label LblManPhone;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.ComboBox CbRegNum;
        private System.Windows.Forms.Label LblRegNum;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.Button BtnDashBoard;
    }
}