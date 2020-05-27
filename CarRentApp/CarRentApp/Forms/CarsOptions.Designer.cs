namespace CarRentApp.Forms
{
    partial class CarsOptions
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
            this.TxtCarModel = new System.Windows.Forms.TextBox();
            this.LblBrand = new System.Windows.Forms.Label();
            this.DgvCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEngine = new System.Windows.Forms.NumericUpDown();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblEngine = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.NumYear = new System.Windows.Forms.NumericUpDown();
            this.LblNumber = new System.Windows.Forms.Label();
            this.TxtCarName = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblWarning = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.TxtRegNum = new System.Windows.Forms.TextBox();
            this.CbCarBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCarModel
            // 
            this.TxtCarModel.Location = new System.Drawing.Point(206, 118);
            this.TxtCarModel.Name = "TxtCarModel";
            this.TxtCarModel.Size = new System.Drawing.Size(179, 26);
            this.TxtCarModel.TabIndex = 4;
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Location = new System.Drawing.Point(39, 8);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(111, 20);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Choose Brand";
            // 
            // DgvCars
            // 
            this.DgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvCars.Location = new System.Drawing.Point(8, 202);
            this.DgvCars.Name = "DgvCars";
            this.DgvCars.RowHeadersWidth = 62;
            this.DgvCars.RowTemplate.Height = 28;
            this.DgvCars.Size = new System.Drawing.Size(1154, 414);
            this.DgvCars.TabIndex = 2;
            this.DgvCars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCars_RowHeaderMouseDoubleClick);
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
            this.Column3.HeaderText = "Brand";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Engine";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Year";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Reg.Number";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Add/Edit By";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // NumEngine
            // 
            this.NumEngine.Location = new System.Drawing.Point(208, 41);
            this.NumEngine.Name = "NumEngine";
            this.NumEngine.Size = new System.Drawing.Size(177, 26);
            this.NumEngine.TabIndex = 3;
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Location = new System.Drawing.Point(253, 83);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(81, 20);
            this.LblModel.TabIndex = 5;
            this.LblModel.Text = "Car Model";
            // 
            // LblEngine
            // 
            this.LblEngine.AutoSize = true;
            this.LblEngine.Location = new System.Drawing.Point(263, 8);
            this.LblEngine.Name = "LblEngine";
            this.LblEngine.Size = new System.Drawing.Size(59, 20);
            this.LblEngine.TabIndex = 7;
            this.LblEngine.Text = "Engine";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(471, 8);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(43, 20);
            this.LblYear.TabIndex = 9;
            this.LblYear.Text = "Year";
            // 
            // NumYear
            // 
            this.NumYear.Location = new System.Drawing.Point(404, 39);
            this.NumYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.NumYear.Name = "NumYear";
            this.NumYear.Size = new System.Drawing.Size(180, 26);
            this.NumYear.TabIndex = 5;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(415, 83);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(155, 20);
            this.LblNumber.TabIndex = 11;
            this.LblNumber.Text = "Registration Number";
            // 
            // TxtCarName
            // 
            this.TxtCarName.Location = new System.Drawing.Point(12, 118);
            this.TxtCarName.Name = "TxtCarName";
            this.TxtCarName.Size = new System.Drawing.Size(174, 26);
            this.TxtCarName.TabIndex = 2;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(681, 8);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 20);
            this.LblPrice.TabIndex = 14;
            this.LblPrice.Text = "Price";
            // 
            // NumPrice
            // 
            this.NumPrice.Location = new System.Drawing.Point(609, 39);
            this.NumPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(180, 26);
            this.NumPrice.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(609, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(180, 47);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(815, 28);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(103, 47);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(815, 97);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 47);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(27, 161);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 20);
            this.LblWarning.TabIndex = 39;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(942, 28);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(220, 117);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "New Rent Page";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Location = new System.Drawing.Point(991, 161);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(0, 20);
            this.LblAdmin.TabIndex = 41;
            // 
            // TxtRegNum
            // 
            this.TxtRegNum.Location = new System.Drawing.Point(404, 118);
            this.TxtRegNum.Name = "TxtRegNum";
            this.TxtRegNum.Size = new System.Drawing.Size(177, 26);
            this.TxtRegNum.TabIndex = 6;
            // 
            // CbCarBrand
            // 
            this.CbCarBrand.FormattingEnabled = true;
            this.CbCarBrand.Location = new System.Drawing.Point(12, 41);
            this.CbCarBrand.Name = "CbCarBrand";
            this.CbCarBrand.Size = new System.Drawing.Size(174, 28);
            this.CbCarBrand.TabIndex = 1;
            this.CbCarBrand.SelectedIndexChanged += new System.EventHandler(this.CbCarBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "New Brand?";
            // 
            // CarsOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbCarBrand);
            this.Controls.Add(this.TxtRegNum);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.TxtCarName);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.NumYear);
            this.Controls.Add(this.LblEngine);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.NumEngine);
            this.Controls.Add(this.DgvCars);
            this.Controls.Add(this.LblBrand);
            this.Controls.Add(this.TxtCarModel);
            this.Name = "CarsOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars Options";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCarModel;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.DataGridView DgvCars;
        private System.Windows.Forms.NumericUpDown NumEngine;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblEngine;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.NumericUpDown NumYear;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.TextBox TxtCarName;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.NumericUpDown NumPrice;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.TextBox TxtRegNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox CbCarBrand;
        private System.Windows.Forms.Label label1;
    }
}