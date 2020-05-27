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
    public partial class RentedCars : Form
    {
        private CarRentEntities db;
        int AdminId = 0;
        public RentedCars(int adminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.AdminId = adminId;
            LblAdmin.Text += db.Administrators.Find(this.AdminId).Name + " " + db.Administrators.Find(this.AdminId).Surname;
            FillDGV(db.CarsOnRent.Where(c => c.AcceptedDate==null).ToList());
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
                                        rental.RentalDate != null ? rental.RentalDate.Value.ToString("dd.MM.yyyy") : "Not Found",
                                        rental.ReturnDate != null ? rental.ReturnDate.Value.ToString("dd.MM.yyyy") : "Not Found",
                                        rental.Price.Value.ToString("0.00"));
            }
        }
        private void DgvRentedCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string carNumber = DgvRentedCars.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = DgvRentedCars.Rows[e.RowIndex].Cells[3].Value.ToString();
            string surname = DgvRentedCars.Rows[e.RowIndex].Cells[4].Value.ToString();
            CloseDeal closeDeal = new CloseDeal(this.AdminId,name,surname, carNumber);
            closeDeal.Show();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<CarsOnRent> rentedCars = new List<CarsOnRent>();

            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                rentedCars = db.CarsOnRent.Where(c => (c.AvailableCars.CarNames.Name.Contains(TxtSearch.Text)) ||
                                                      (c.AvailableCars.Model.Contains(TxtSearch.Text)) ||
                                                      (c.AvailableCars.RegNumber.Contains(TxtSearch.Text)) ||
                                                      (c.Customers.Name.Contains(TxtSearch.Text)) ||
                                                      (c.Customers.Surname.Contains(TxtSearch.Text)) ||
                                                      (c.Price.ToString().Contains(TxtSearch.Text))).ToList();

            }
            else
            {
                rentedCars = db.CarsOnRent.OrderByDescending(c => c.ReturnDate).ToList();
            }

            FillDGV(rentedCars);
        }
    }
}
