namespace CarRentApp.Forms
{
    partial class CloseDeal
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.GbCarReturn = new System.Windows.Forms.GroupBox();
            this.LblAcceptDate = new System.Windows.Forms.Label();
            this.DtpAcceptedDate = new System.Windows.Forms.DateTimePicker();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblPayment = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFine = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblCarNum = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.GbCarReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(235, 391);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(236, 50);
            this.BtnClose.TabIndex = 44;
            this.BtnClose.Text = "Close Deal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GbCarReturn
            // 
            this.GbCarReturn.Controls.Add(this.LblAcceptDate);
            this.GbCarReturn.Controls.Add(this.DtpAcceptedDate);
            this.GbCarReturn.Controls.Add(this.LblStatus);
            this.GbCarReturn.Controls.Add(this.LblPayment);
            this.GbCarReturn.Controls.Add(this.LblTotal);
            this.GbCarReturn.Controls.Add(this.LblFine);
            this.GbCarReturn.Controls.Add(this.LblPrice);
            this.GbCarReturn.Controls.Add(this.LblCarNum);
            this.GbCarReturn.Controls.Add(this.LblCustomerName);
            this.GbCarReturn.Location = new System.Drawing.Point(12, 22);
            this.GbCarReturn.Name = "GbCarReturn";
            this.GbCarReturn.Size = new System.Drawing.Size(680, 343);
            this.GbCarReturn.TabIndex = 45;
            this.GbCarReturn.TabStop = false;
            this.GbCarReturn.Text = "Car Return";
            // 
            // LblAcceptDate
            // 
            this.LblAcceptDate.AutoSize = true;
            this.LblAcceptDate.Location = new System.Drawing.Point(455, 46);
            this.LblAcceptDate.Name = "LblAcceptDate";
            this.LblAcceptDate.Size = new System.Drawing.Size(182, 20);
            this.LblAcceptDate.TabIndex = 54;
            this.LblAcceptDate.Text = "Choose Accepting Date:";
            // 
            // DtpAcceptedDate
            // 
            this.DtpAcceptedDate.CustomFormat = "dd.MM.yyyy";
            this.DtpAcceptedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAcceptedDate.Location = new System.Drawing.Point(446, 94);
            this.DtpAcceptedDate.Name = "DtpAcceptedDate";
            this.DtpAcceptedDate.Size = new System.Drawing.Size(200, 26);
            this.DtpAcceptedDate.TabIndex = 53;
            this.DtpAcceptedDate.ValueChanged += new System.EventHandler(this.DtpAcceptedDate_ValueChanged);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(88, 46);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(80, 20);
            this.LblStatus.TabIndex = 52;
            this.LblStatus.Text = "STATUS: ";
            // 
            // LblPayment
            // 
            this.LblPayment.AutoSize = true;
            this.LblPayment.Location = new System.Drawing.Point(89, 211);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(79, 20);
            this.LblPayment.TabIndex = 51;
            this.LblPayment.Text = "Payment: ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(50, 286);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(118, 20);
            this.LblTotal.TabIndex = 50;
            this.LblTotal.Text = "Total Payment: ";
            // 
            // LblFine
            // 
            this.LblFine.AutoSize = true;
            this.LblFine.Location = new System.Drawing.Point(120, 249);
            this.LblFine.Name = "LblFine";
            this.LblFine.Size = new System.Drawing.Size(48, 20);
            this.LblFine.TabIndex = 49;
            this.LblFine.Text = "Fine: ";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(56, 174);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(112, 20);
            this.LblPrice.TabIndex = 48;
            this.LblPrice.Text = "Price Per Day: ";
            // 
            // LblCarNum
            // 
            this.LblCarNum.AutoSize = true;
            this.LblCarNum.Location = new System.Drawing.Point(66, 137);
            this.LblCarNum.Name = "LblCarNum";
            this.LblCarNum.Size = new System.Drawing.Size(102, 20);
            this.LblCarNum.TabIndex = 47;
            this.LblCarNum.Text = "Car Number: ";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(36, 100);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(132, 20);
            this.LblCustomerName.TabIndex = 46;
            this.LblCustomerName.Text = "Customer Name: ";
            // 
            // CloseDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 493);
            this.Controls.Add(this.GbCarReturn);
            this.Controls.Add(this.BtnClose);
            this.Name = "CloseDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Deal";
            this.GbCarReturn.ResumeLayout(false);
            this.GbCarReturn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GbCarReturn;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblCarNum;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFine;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblPayment;
        private System.Windows.Forms.Label LblAcceptDate;
        private System.Windows.Forms.DateTimePicker DtpAcceptedDate;
    }
}