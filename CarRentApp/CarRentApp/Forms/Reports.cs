using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentApp.Forms;
using CarRentApp.EntityModel;
using ClosedXML.Excel;

namespace CarRentApp.Forms
{
    public partial class Reports : Form
    {
        private CarRentEntities db;
        List<CarsOnRent> rentedCars;
        int AdminId = 0;
        public Reports(int adminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.AdminId = adminId;
            LblAdmin.Text += db.Administrators.Find(this.AdminId).Name + " " + db.Administrators.Find(this.AdminId).Surname;
            FillDGV(db.CarsOnRent.OrderByDescending(c=>c.ReturnDate).ToList());
        }
        private void Reset()
        {
            TxtSearch.Text = string.Empty;
            DtpRentDateFrom.Value = DateTime.Now;
            DtpRentDateTo.Value = DateTime.Now;
            DtpReturnDateFrom.Value = DateTime.Now;
            DtpReturnDateTo.Value = DateTime.Now;
        }
        private void FillDGV(List<CarsOnRent> Cars)
        {
            DgvRentedCars.Rows.Clear();
            foreach (CarsOnRent rental in Cars)
            {
                DgvRentedCars.Rows.Add(rental.Id, rental.AvailableCars != null &&
                                        rental.AvailableCars.CarNames != null ?
                                        rental.AvailableCars.CarNames.Name + " " + rental.AvailableCars.Model : "Not Found",
                                        rental.AvailableCars != null ? rental.AvailableCars.RegNumber : "Not Found",
                                        rental.Customers != null ? rental.Customers.Name : "Not Found",
                                        rental.Customers != null ? rental.Customers.Surname : "Not Found",
                                        rental.RentalDate !=null? rental.RentalDate.Value.ToString("dd.MM.yyyy"): "Not Found",
                                        rental.ReturnDate != null ? rental.ReturnDate.Value.ToString("dd.MM.yyyy"): "Not Found",
                                        rental.AcceptedDate != null ? rental.AcceptedDate.Value.ToString("dd.MM.yyyy") : "Not Expired Yet!",
                                        rental.Price.Value.ToString("0.00"));
            }
        }
        private void ConvertToExcel(List<CarsOnRent> rentedCars)
        {
            var workBook = new XLWorkbook();
            var ws = workBook.Worksheets.Add("Rented Cars");
            ws.Row(1).Height = 30;
            ws.Row(2).Height = 25;
            ws.Column("A").Width = 12;
            ws.Column("B").Width = 16;
            ws.Column("C").Width = 16;
            ws.Column("D").Width = 16;
            ws.Column("E").Width = 16;
            ws.Column("F").Width = 16;
            ws.Column("G").Width = 16;
            ws.Column("H").Width = 16;
            ws.Column("I").Width = 10;

            ws.Range("A1:I1").Merge();
            ws.Range("A1:I1").Value = "Report";
            ws.Range("A1:I1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("A1:I1").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("A1:I1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
            ws.Range("A1:I1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
            ws.Range("A1:I1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
            ws.Range("A1:I1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
            ws.Range("A1:I1").Style.Fill.BackgroundColor = XLColor.Almond;
            ws.Range("A1:I1").Style.Font.FontColor = XLColor.CoolBlack;
            ws.Range("A1:I1").Style.Font.Bold = true;

            ws.Cell("A2").Value = "Brand";
            ws.Cell("A2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("A2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("A2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("A2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("A2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("A2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("A2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("A2").Style.Font.FontColor = XLColor.White;
            ws.Cell("A2").Style.Font.Bold = true;

            ws.Cell("B2").Value = "Model";
            ws.Cell("B2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("B2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("B2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("B2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("B2").Style.Font.FontColor = XLColor.White;
            ws.Cell("B2").Style.Font.Bold = true;

            ws.Cell("C2").Value = "Car Reg. Number";
            ws.Cell("C2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("C2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("C2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("C2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("C2").Style.Font.FontColor = XLColor.White;
            ws.Cell("C2").Style.Font.Bold = true;

            ws.Cell("D2").Value = "Customer Name";
            ws.Cell("D2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("D2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("D2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("D2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("D2").Style.Font.FontColor = XLColor.White;
            ws.Cell("D2").Style.Font.Bold = true;

            ws.Cell("E2").Value = "Customer Surname";
            ws.Cell("E2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("E2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("E2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("E2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("E2").Style.Font.FontColor = XLColor.White;
            ws.Cell("E2").Style.Font.Bold = true;

            ws.Cell("F2").Value = "Rent Date";
            ws.Cell("F2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("F2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("F2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("F2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("F2").Style.Font.FontColor = XLColor.White;
            ws.Cell("F2").Style.Font.Bold = true;

            ws.Cell("G2").Value = "Return Date";
            ws.Cell("G2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("G2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("G2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("G2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("G2").Style.Font.FontColor = XLColor.White;
            ws.Cell("G2").Style.Font.Bold = true;

            ws.Cell("H2").Value = "Aceepted Date";
            ws.Cell("H2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("H2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("H2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("H2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("H2").Style.Font.FontColor = XLColor.White;
            ws.Cell("H2").Style.Font.Bold = true;

            ws.Cell("I2").Value = "Price";
            ws.Cell("I2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("I2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("I2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("I2").Style.Fill.BackgroundColor = XLColor.Amber;
            ws.Cell("I2").Style.Font.FontColor = XLColor.White;
            ws.Cell("I2").Style.Font.Bold = true;

            int i = 3;
            foreach (CarsOnRent car in rentedCars)
            {
                ws.Cell("A" + i + "").Value = car.AvailableCarsId!=null && car.AvailableCars.CarNameId!=null? car.AvailableCars.CarNames.Name:"";
                ws.Cell("A" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("A" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("A" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("A" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("A" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("A" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("A" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("A" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("B" + i + "").Value = car.AvailableCarsId != null ? car.AvailableCars.Model : "Not Found";
                ws.Cell("B" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("B" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("B" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("B" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("C" + i + "").Value = car.AvailableCarsId!=null? car.AvailableCars.RegNumber:"Not Found";
                ws.Cell("C" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("C" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("C" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("C" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("D" + i + "").Value = car.CustomerId != null ? car.Customers.Name : "Not Found";
                ws.Cell("D" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("D" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("D" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("D" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("E" + i + "").Value = car.CustomerId != null ? car.Customers.Surname : "Not Found";
                ws.Cell("E" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("E" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("E" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("E" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("F" + i + "").Value = car.RentalDate.Value.ToString("dd.MM.yyyy");
                ws.Cell("F" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("F" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("F" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("F" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("G" + i + "").Value = car.ReturnDate.Value.ToString("dd.MM.yyyy");
                ws.Cell("G" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("G" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("G" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("G" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("H" + i + "").Value = car.AcceptedDate != null ? car.AcceptedDate.Value.ToString("dd.MM.yyyy") : "Not Expired Yet";
                ws.Cell("H" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("H" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("H" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("H" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                ws.Cell("I" + i + "").Value = car.Price.Value.ToString("0.00");
                ws.Cell("I" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("I" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("I" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Fill.BackgroundColor = XLColor.AliceBlue;
                ws.Cell("I" + i + "").Style.Font.FontColor = XLColor.CoolBlack;

                i++;
            }

            ws.Row(i).Height = 25;
            ws.Range("A" + i + ":H" + i + "").Merge();
            ws.Range("A" + i + ":H" + i + "").Value = "Total Rented Cars";
            ws.Range("A" + i + ":H" + i + "").Style.Font.Bold = true;
            ws.Range("A" + i + ":H" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("A" + i + ":H" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thick;
            ws.Range("A" + i + ":H" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
            ws.Range("A" + i + ":H" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
            ws.Range("A" + i + ":H" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thick;

            ws.Cell("I" + i + "").Value = rentedCars.Count();
            ws.Cell("I" + i + "").Style.Font.Bold = true;
            ws.Cell("I" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("I" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("I" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thick;
            ws.Cell("I" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
            ws.Cell("I" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
            ws.Cell("I" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thick;

            workBook.SaveAs(@"C:\Users\Ilkin\Desktop\Report.xlsx");

        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtSearch.Text))
            {
                rentedCars = db.CarsOnRent.Where(c =>((!string.IsNullOrEmpty(TxtSearch.Text) ? c.AvailableCars.CarNames.Name.Contains(TxtSearch.Text) : true) ||
                                                     (!string.IsNullOrEmpty(TxtSearch.Text) ? c.AvailableCars.Model.Contains(TxtSearch.Text) : true) ||
                                                     (!string.IsNullOrEmpty(TxtSearch.Text) ? c.AvailableCars.RegNumber.Contains(TxtSearch.Text) : true) ||
                                                     (!string.IsNullOrEmpty(TxtSearch.Text) ? c.Customers.Name.Contains(TxtSearch.Text) : true) ||
                                                     (!string.IsNullOrEmpty(TxtSearch.Text) ? c.Customers.Surname.Contains(TxtSearch.Text) : true) ||
                                                     (!string.IsNullOrEmpty(TxtSearch.Text) ? c.Price.ToString().Contains(TxtSearch.Text) : true)) &&
                                                     (c.RentalDate.Value >= DtpRentDateFrom.Value) &&
                                                     (c.RentalDate.Value <= DtpRentDateTo.Value) &&
                                                     (c.ReturnDate.Value >= DtpReturnDateFrom.Value) &&
                                                     (c.ReturnDate.Value <= DtpReturnDateTo.Value)
                                                     ).ToList();
            }
            else
            {
                rentedCars = db.CarsOnRent.ToList();
            }
            

            FillDGV(rentedCars);
            Reset();
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (this.rentedCars!=null)
            {
                ConvertToExcel(this.rentedCars);
            }
            else
            {
                ConvertToExcel(db.CarsOnRent.ToList());
            }
            MessageBox.Show("Report Converted to Excel. Please check your desktop!");
        }
    }
}
