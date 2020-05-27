namespace CarRentApp.Forms
{
    partial class Dashboard
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
            this.DgvLastTenCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnCarReturn = new System.Windows.Forms.Button();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.MtsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MtsOurCars = new System.Windows.Forms.ToolStripMenuItem();
            this.MtsOurCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MtsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LblAllCars = new System.Windows.Forms.Label();
            this.CbxRent = new System.Windows.Forms.CheckBox();
            this.CbxReturned = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastTenCars)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvLastTenCars
            // 
            this.DgvLastTenCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLastTenCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLastTenCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvLastTenCars.Location = new System.Drawing.Point(13, 120);
            this.DgvLastTenCars.Name = "DgvLastTenCars";
            this.DgvLastTenCars.RowHeadersWidth = 62;
            this.DgvLastTenCars.RowTemplate.Height = 28;
            this.DgvLastTenCars.Size = new System.Drawing.Size(1216, 413);
            this.DgvLastTenCars.TabIndex = 1;
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
            this.Column3.HeaderText = "Car Model";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car Number";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rental Date";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Return Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Accepted Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(13, 37);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(213, 42);
            this.BtnNewOrder.TabIndex = 1;
            this.BtnNewOrder.Text = "New Rent";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // BtnCarReturn
            // 
            this.BtnCarReturn.Location = new System.Drawing.Point(263, 37);
            this.BtnCarReturn.Name = "BtnCarReturn";
            this.BtnCarReturn.Size = new System.Drawing.Size(200, 42);
            this.BtnCarReturn.TabIndex = 2;
            this.BtnCarReturn.Text = "Car Return";
            this.BtnCarReturn.UseVisualStyleBackColor = true;
            this.BtnCarReturn.Click += new System.EventHandler(this.BtnCarReturn_Click);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Location = new System.Drawing.Point(898, 9);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(105, 20);
            this.LblAdmin.TabIndex = 4;
            this.LblAdmin.Text = "Welcome Mr :";
            // 
            // MtsAdmin
            // 
            this.MtsAdmin.Name = "MtsAdmin";
            this.MtsAdmin.Size = new System.Drawing.Size(145, 29);
            this.MtsAdmin.Text = "Administrators";
            this.MtsAdmin.Click += new System.EventHandler(this.MtsAdmin_Click);
            // 
            // MtsOurCars
            // 
            this.MtsOurCars.Name = "MtsOurCars";
            this.MtsOurCars.Size = new System.Drawing.Size(97, 29);
            this.MtsOurCars.Text = "Our Cars";
            this.MtsOurCars.Click += new System.EventHandler(this.MtsOurCars_Click);
            // 
            // MtsOurCustomers
            // 
            this.MtsOurCustomers.Name = "MtsOurCustomers";
            this.MtsOurCustomers.Size = new System.Drawing.Size(148, 29);
            this.MtsOurCustomers.Text = "Our Customers";
            this.MtsOurCustomers.Click += new System.EventHandler(this.MtsOurCustomers_Click);
            // 
            // MtsReport
            // 
            this.MtsReport.Name = "MtsReport";
            this.MtsReport.Size = new System.Drawing.Size(81, 29);
            this.MtsReport.Text = "Report";
            this.MtsReport.Click += new System.EventHandler(this.MtsReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MtsAdmin,
            this.MtsOurCars,
            this.MtsOurCustomers,
            this.MtsReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LblAllCars
            // 
            this.LblAllCars.AutoSize = true;
            this.LblAllCars.Location = new System.Drawing.Point(562, 94);
            this.LblAllCars.Name = "LblAllCars";
            this.LblAllCars.Size = new System.Drawing.Size(124, 20);
            this.LblAllCars.TabIndex = 5;
            this.LblAllCars.Text = "RENTED CARS";
            // 
            // CbxRent
            // 
            this.CbxRent.AutoSize = true;
            this.CbxRent.Location = new System.Drawing.Point(996, 47);
            this.CbxRent.Name = "CbxRent";
            this.CbxRent.Size = new System.Drawing.Size(181, 24);
            this.CbxRent.TabIndex = 6;
            this.CbxRent.Text = "Sort By Active Rents";
            this.CbxRent.UseVisualStyleBackColor = true;
            this.CbxRent.CheckedChanged += new System.EventHandler(this.CbxRent_CheckedChanged);
            // 
            // CbxReturned
            // 
            this.CbxReturned.AutoSize = true;
            this.CbxReturned.Location = new System.Drawing.Point(996, 81);
            this.CbxReturned.Name = "CbxReturned";
            this.CbxReturned.Size = new System.Drawing.Size(195, 24);
            this.CbxReturned.TabIndex = 7;
            this.CbxReturned.Text = "Sort By Returned Cars";
            this.CbxReturned.UseVisualStyleBackColor = true;
            this.CbxReturned.CheckedChanged += new System.EventHandler(this.CbxReturned_CheckedChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 598);
            this.Controls.Add(this.CbxReturned);
            this.Controls.Add(this.CbxRent);
            this.Controls.Add(this.LblAllCars);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.BtnCarReturn);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.DgvLastTenCars);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastTenCars)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvLastTenCars;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnCarReturn;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.ToolStripMenuItem MtsAdmin;
        private System.Windows.Forms.ToolStripMenuItem MtsOurCars;
        private System.Windows.Forms.ToolStripMenuItem MtsOurCustomers;
        private System.Windows.Forms.ToolStripMenuItem MtsReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label LblAllCars;
        private System.Windows.Forms.CheckBox CbxRent;
        private System.Windows.Forms.CheckBox CbxReturned;
    }
}