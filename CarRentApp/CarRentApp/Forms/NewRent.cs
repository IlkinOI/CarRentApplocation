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
    public partial class NewRent : Form
    {
        private CarRentEntities db;
        int adminId = 0;
        public NewRent(int AdminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.adminId = AdminId;
            LblAdmin.Text += db.Administrators.Find(this.adminId).Name + " " + db.Administrators.Find(this.adminId).Surname;
            FillCbName();
            FillCbCarBrand();
        }
        private void Reset()
        {
            CbName.SelectedItem = "Choose";
            CbBrand.SelectedItem = "Choose";
            CbModel.SelectedItem = "Choose";
            DtpRentDate.Value = DateTime.Now;
            DtpReturnDate.Value = DateTime.Now;
        }
        private void FillCbName()
        {
            CbName.Items.Clear();
            CbName.Items.Add("Choose");
            CbName.SelectedItem = "Choose";
            List<Customers> customers = db.Customers.ToList();
            foreach (Customers customer in customers)
            {
                CbName.Items.Add(customer.Name);
            }
        }
        private void FillCbSurname(int? manId)
        {
            CbSurname.Items.Clear();
            CbSurname.Items.Add("Choose");
            CbSurname.SelectedItem = "Choose";
            List<Customers> guys = db.Customers.Where(m => m.Id == manId).ToList();
            foreach (Customers man in guys)
            {
                CbSurname.Items.Add(man.Surname);
            }
        }
        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? manId = null;
            if (db.Customers.FirstOrDefault(m => m.Name == CbName.Text) != null)
            {
                manId = db.Customers.FirstOrDefault(m => m.Name == CbName.Text).Id;
            }
            FillCbSurname(manId);
        }
        private void FillCbCarBrand()
        {
            CbBrand.Items.Clear();
            CbBrand.Items.Add("Choose");
            CbBrand.SelectedItem = "Choose";
            foreach (CarNames CarName in db.CarNames.ToList())
            {
                CbBrand.Items.Add(CarName.Name);
            }
        }
        private void FillCbCarModels(int? brandId)
        {
            CbModel.Items.Clear();
            CbModel.Items.Add("Choose");
            CbModel.SelectedItem = "Choose";
            List<AvailableCars> cars = db.AvailableCars.Where(a=>a.CarNameId==brandId).ToList();
            foreach (AvailableCars car in cars)
            {
                CbModel.Items.Add(car.Model);
            }
        }
        private void CbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? brandId = null;
            if (db.CarNames.FirstOrDefault(c => c.Name == CbBrand.Text) != null)
            {
                brandId = db.CarNames.FirstOrDefault(c => c.Name == CbBrand.Text).Id;
            }
            FillCbCarModels(brandId);
        }
        private void CbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? modelId = null;
            if (db.AvailableCars.FirstOrDefault(c => c.Model == CbModel.Text) != null)
            {
                modelId = db.AvailableCars.FirstOrDefault(c => c.Model == CbModel.Text).Id;
            }
            FillLabels(modelId);
            FillRegNumbers(modelId);
        }
        private void FillRegNumbers(int? mId)
        {
            CbRegNum.Items.Clear();
            CbRegNum.Items.Add("Choose");
            CbRegNum.SelectedItem = "Choose";
            List<AvailableCars> cars = db.AvailableCars.Where(a => a.Id == mId).ToList();
            foreach (AvailableCars car in cars)
            {
                CbRegNum.Items.Add(car.RegNumber);
            }
        }
        private void FillLabels(int? modelId)
        {
            List<AvailableCars> cars = db.AvailableCars.Where(a=>a.Id==modelId).ToList();
            foreach (AvailableCars car in cars)
            {
                LblEngine.Text = "Engine: ";
                LblYear.Text = "Year: ";
                LblPrice.Text = "Price: ";
                LblEngine.Text += db.AvailableCars.FirstOrDefault(a => a.Id == modelId).Engine.Value.ToString("0.0");
                LblYear.Text += db.AvailableCars.FirstOrDefault(a => a.Id == modelId).Year.Value.ToString();
                LblPrice.Text += db.AvailableCars.FirstOrDefault(a => a.Id == modelId).Price.Value.ToString("0.00");
            }
        }
        private void FillManDetails(int? manId)
        {
            List<Customers> men = db.Customers.Where(m => m.Id == manId).ToList();
            foreach (Customers man in men)
            {
                LblManId.Text = "ID: ";
                LblManPhone.Text = "Phone: ";
                LblManEmail.Text = "Email: ";
                LblManId.Text += db.Customers.FirstOrDefault(m => m.Id == manId).Identification.ToString();
                LblManPhone.Text += db.Customers.FirstOrDefault(m => m.Id == manId).Phone.ToString();
                LblManEmail.Text += db.Customers.FirstOrDefault(m => m.Id == manId).Email.ToString();
            }
        }
        private void CbSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? manId = null;
            if (db.Customers.FirstOrDefault(m => m.Name == CbName.Text &&
                 m.Surname==CbSurname.Text) != null)
            {
                manId = db.Customers.FirstOrDefault(m => m.Name == CbName.Text &&
                 m.Surname == CbSurname.Text).Id;
            }
            FillManDetails(manId);
        }
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomersOptions customer = new CustomersOptions(this.adminId);
            customer.Show();
            this.Close();
        }
        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            CarsOptions car = new CarsOptions(this.adminId);
            car.Show();
            this.Close();
        }
        private void BtnRent_Click(object sender, EventArgs e)
        {
            if (CbName.Text!="Choose" &&
                CbSurname.Text != "Choose" &&
                CbBrand.Text!="Choose" &&
                CbModel.Text!="Choose" &&
                CbRegNum.Text !="Choose" &&
                DtpRentDate.Value.Date>=DateTime.Now.Date &&
                DtpReturnDate.Value.Date>DateTime.Now.Date &&
                DtpReturnDate.Value.Date>DtpRentDate.Value.Date)
            {
                int? CustomerId = null;
                int? carId = null;
                if (db.Customers.FirstOrDefault(p => p.Name == CbName.Text && p.Surname == CbSurname.Text) != null)
                {
                    CustomerId = db.Customers.FirstOrDefault(p => p.Name == CbName.Text && p.Surname == CbSurname.Text).Id;
                }
                if (db.AvailableCars.FirstOrDefault(c => c.RegNumber==CbRegNum.Text)!=null)
                {
                    carId = db.AvailableCars.FirstOrDefault(c => c.RegNumber == CbRegNum.Text).Id;
                }
                if (db.CarsOnRent.FirstOrDefault(c=> (c.AvailableCars.RegNumber == CbRegNum.Text) 
                                       && (DtpRentDate.Value.Date >= c.RentalDate && DtpRentDate.Value.Date < c.ReturnDate) 
                                       && (DtpReturnDate.Value.Date >= c.RentalDate || DtpReturnDate.Value.Date < c.ReturnDate)) ==null)
                {
                    CarsOnRent car = new CarsOnRent();
                    car.AvailableCarsId = carId;
                    car.CustomerId = CustomerId;
                    car.RentalDate = DtpRentDate.Value.Date;
                    car.ReturnDate = DtpReturnDate.Value.Date;
                    car.Price = db.AvailableCars.FirstOrDefault(c => c.Id == carId).Price.Value;
                    car.EditedAddedBy = this.adminId;
                    db.CarsOnRent.Add(car);
                    db.SaveChanges();
                    MessageBox.Show(CbBrand.Text+" "+CbModel.Text+" "+ "Has Been Rented To "+CbName.Text+" "+CbSurname.Text+" !");
                    Reset();
                }
                else
                {
                    MessageBox.Show("This Car Is Oqqupied On Selected Date!");
                }
                
            }
            else
            {
                LblWarning.Text = "Please choose all options and/or select proper date";
            }
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard board = new Dashboard(this.adminId);
            board.Show();
            this.Close();
        }
    }
}
