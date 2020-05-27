using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentApp.EntityModel;
using CarRentApp.Forms;

namespace CarRentApp.Forms
{
    public partial class Dashboard : Form
    {
        private CarRentEntities db;
        int adminId = 0;
        List<CarsOnRent> cars;
        public Dashboard(int AdminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.adminId = AdminId;
            LblAdmin.Text += db.Administrators.Find(this.adminId).Name + " " + db.Administrators.Find(this.adminId).Surname;
            FillDGV();
        }
        private void FillDGV()
        {
            if (CbxRent.Checked==true && CbxReturned.Checked==false)
            {
                cars = db.CarsOnRent.Where(C => C.AcceptedDate == null).OrderByDescending(c => c.ReturnDate).Take(10).ToList();
            }
            else if (CbxRent.Checked == false && CbxReturned.Checked == true)
            {
                cars = db.CarsOnRent.Where(C => C.AcceptedDate != null).OrderByDescending(c => c.ReturnDate).Take(10).ToList();
            }
            else if (CbxRent.Checked == true && CbxReturned.Checked == true)
            {
                cars = db.CarsOnRent.OrderByDescending(c => c.ReturnDate).Take(10).ToList();
            }
            else
            {
                cars = db.CarsOnRent.OrderByDescending(c => c.ReturnDate).Take(10).ToList();
            }
            DgvLastTenCars.Rows.Clear();
            
            foreach (CarsOnRent rental in cars)
            {
                DgvLastTenCars.Rows.Add(rental.Id, rental.AvailableCars != null &&
                                        rental.AvailableCars.CarNames != null ?
                                        rental.AvailableCars.CarNames.Name + " " + rental.AvailableCars.Model : "Not Found",
                                        rental.AvailableCars != null ? rental.AvailableCars.RegNumber : "Not Found",
                                        rental.Customers != null ? rental.Customers.Name + " " + rental.Customers.Surname : "Not Found",
                                        rental.RentalDate != null ? rental.RentalDate.Value.ToString("dd.MM.yyyy") : "Not Found",
                                        rental.ReturnDate != null ? rental.ReturnDate.Value.ToString("dd.MM.yyyy") : "Not Found",
                                        rental.AcceptedDate != null ? rental.AcceptedDate.Value.ToString("dd.MM.yyyy") : "Not Expired Yet!",
                                        rental.Price.Value.ToString("0.00"));
            }
        }

        private void MtsAdmin_Click(object sender, EventArgs e)
        {
            AdministratorsOptions admins = new AdministratorsOptions(this.adminId);
            admins.Show();
        }

        private void MtsOurCars_Click(object sender, EventArgs e)
        {
            CarsOptions cars = new CarsOptions(this.adminId);
            cars.Show();
        }

        private void MtsOurCustomers_Click(object sender, EventArgs e)
        {
            CustomersOptions customers = new CustomersOptions(this.adminId);
            customers.Show();
        }

        private void MtsReport_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(this.adminId);
            reports.Show();
        }
        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            NewRent rent = new NewRent(this.adminId);
            rent.Show();
            this.Close();
        }

        private void BtnCarReturn_Click(object sender, EventArgs e)
        {
            RentedCars rented = new RentedCars(this.adminId);
            rented.Show();
        }

        private void CbxRent_CheckedChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void CbxReturned_CheckedChanged(object sender, EventArgs e)
        {
            FillDGV();
        }
    }
}
