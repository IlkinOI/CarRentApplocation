using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentApp.EntityModel;
using CarRentApp.Forms;

namespace CarRentApp.Forms
{
    public partial class CloseDeal : Form
    {
        private CarRentEntities db;
        int AdminId = 0;
        string name = "";
        string Surname = "";
        string CarNumber = "";
        string status = "";
        double price = 0;
        double payment = 0;
        double fine = 0;
        double total = 0;

        public CloseDeal(int adminId,string name,string surname,string carNumber)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.AdminId = adminId;
            this.name = name;
            this.Surname = surname;
            this.CarNumber = carNumber;
            FillLabels();
        }
        private void FillLabels()
        {
            int carId = db.CarsOnRent.FirstOrDefault(c => c.AvailableCars.RegNumber == this.CarNumber).Id;
            CarsOnRent Car = db.CarsOnRent.Find(carId);
            double totalRentDays = (Car.ReturnDate.Value - Car.RentalDate.Value).TotalDays;
            price = Convert.ToDouble(Car.Price);
            
            if (Car.ReturnDate >= DtpAcceptedDate.Value)
            {
                payment = Convert.ToDouble(Car.Price) * totalRentDays;
                fine = 0;
                status = "Rent time is not expired!";
                total = Convert.ToDouble(fine + payment);
            }
            else
            {
                payment = Convert.ToDouble(Car.Price) * totalRentDays;
                double expiredDays = (DtpAcceptedDate.Value - Car.ReturnDate.Value).TotalDays;
                fine = Convert.ToDouble(expiredDays * ((price / 100) * 20));
                total = Convert.ToDouble(fine + payment);
                status = "Rent time expired!";
            }
           
            LblStatus.Text += status.ToString();
            LblCustomerName.Text += name + " " + Surname;
            LblCarNum.Text += this.CarNumber;
            LblPrice.Text += price.ToString("0.00") + " $";
            LblPayment.Text += payment.ToString("0.00") + " $";
            LblFine.Text += fine.ToString("0.00") + " $";
            LblTotal.Text += total.ToString("0.00") + " $";
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            int carId = db.CarsOnRent.FirstOrDefault(c => c.AvailableCars.RegNumber == this.CarNumber).Id;
            if (db.CarsOnRent.Find(carId)!=null)
            {
                CarsOnRent carAccept = db.CarsOnRent.Find(carId);
                carAccept.AcceptedDate = DtpAcceptedDate.Value;
                db.SaveChanges();
                MessageBox.Show("Deal Has Been Closed");
                this.Close();
                RentedCars rented = new RentedCars(this.AdminId);
                rented.Show();

            }
        }

        private void DtpAcceptedDate_ValueChanged(object sender, EventArgs e)
        {
            LblStatus.Text = "STATUS: ";
            LblCustomerName.Text = "Customer Name: ";
            LblCarNum.Text = "Car Number: ";
            LblPrice.Text = "Price Per Day: ";
            LblPayment.Text = "Payment: ";
            LblFine.Text = "Fine: ";
            LblTotal.Text = "Total Payment: ";
            FillLabels();
        }
    }
}
