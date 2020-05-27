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

namespace CarRentApp.Forms
{
    public partial class CarsOptions : Form
    {
        private CarRentEntities db;
        private int _selectedId;
        int AdminId = 0;
        
        public CarsOptions(int adminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.AdminId = adminId;
            LblAdmin.Text += db.Administrators.Find(this.AdminId).Name + " " + db.Administrators.Find(this.AdminId).Surname;
            FillDGV();
            FillCbCarBrand();
        }
        private void FillDGV()
        {
            DgvCars.Rows.Clear();
            foreach (AvailableCars c in db.AvailableCars.ToList())
            {
                DgvCars.Rows.Add(c.Id, c.CarNames!=null?c.CarNames.Name:"",c.Model,c.Engine,c.Year,c.RegNumber,c.Price,c.EditedAddedBy);
            }
            Reset();
        }
        private void Reset()
        {
            TxtCarName.Text = string.Empty;
            TxtCarModel.Text = string.Empty;
            NumEngine.Value = 0;
            NumYear.Value = 0;
            TxtRegNum.Text = string.Empty;
            NumPrice.Value = 0;
        }


        private void FillCbCarBrand()
        {
            CbCarBrand.Items.Clear();
            CbCarBrand.Items.Add("Choose");
            CbCarBrand.SelectedItem = "Choose";
            foreach (CarNames CarName in db.CarNames.ToList())
            {
                CbCarBrand.Items.Add(CarName.Name);
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            NewRent rent = new NewRent(this.AdminId);
            rent.Show();
            this.Close();
        }

        private void DgvCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this._selectedId = Convert.ToInt32(DgvCars.Rows[e.RowIndex].Cells[0].Value);
            TxtCarName.Text = DgvCars.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtCarModel.Text = DgvCars.Rows[e.RowIndex].Cells[2].Value.ToString();
            NumEngine.Value = Convert.ToDecimal(DgvCars.Rows[e.RowIndex].Cells[3].Value.ToString());
            NumYear.Value = Convert.ToDecimal(DgvCars.Rows[e.RowIndex].Cells[4].Value.ToString());
            TxtRegNum.Text = DgvCars.Rows[e.RowIndex].Cells[5].Value.ToString();
            NumPrice.Value = Convert.ToDecimal(DgvCars.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int CarId = 0;
            if (!string.IsNullOrEmpty(TxtCarName.Text) &&
                !string.IsNullOrEmpty(TxtCarModel.Text) && 
                NumEngine.Value > 0 && !string.IsNullOrEmpty(TxtRegNum.Text) && 
                NumPrice.Value > 0 && NumYear.Value>1900) 
            {
                
                
                if (CbCarBrand.Text!="Choose" && TxtCarName.Text==CbCarBrand.Text)
                {
                    if (db.CarNames.FirstOrDefault(c => c.Name == CbCarBrand.Text) != null)
                    {
                        CarId = db.CarNames.FirstOrDefault(c => c.Name == CbCarBrand.Text).Id;
                    }
                    CarNames carBrand = db.CarNames.Find(CarId);
                    AvailableCars car = db.AvailableCars.Find(CarId);
                    carBrand.Id = CarId;
                    car.Model = TxtCarModel.Text;
                    car.Engine = Convert.ToDecimal(NumEngine.Value);
                    car.Year = Convert.ToInt32(NumYear.Value);
                    car.RegNumber = TxtRegNum.Text;
                    car.Price = Convert.ToDecimal(NumPrice.Value);
                    car.CarNameId = CarId;
                    car.EditedAddedBy = this.AdminId;
                    db.AvailableCars.Add(car);
                }
                else
                {
                    if (db.CarNames.FirstOrDefault(c => c.Name == TxtCarName.Text) != null)
                    {
                        CarId = db.CarNames.FirstOrDefault(c => c.Name == TxtCarName.Text).Id;
                    }
                    AvailableCars car = new AvailableCars();
                    CarNames carBrand = new CarNames();
                    carBrand.Name = TxtCarName.Text;
                    car.Model = TxtCarModel.Text;
                    car.Engine = Convert.ToDecimal(NumEngine.Value);
                    car.Year = Convert.ToInt32(NumYear.Value);
                    car.RegNumber = TxtRegNum.Text;
                    car.Price = Convert.ToDecimal(NumPrice.Value);
                    car.CarNameId = CarId;
                    car.EditedAddedBy = this.AdminId;
                    db.CarNames.Add(carBrand);
                    db.AvailableCars.Add(car);
                }
                
                db.SaveChanges();
                MessageBox.Show("You Have Added New Car!");
                FillDGV();
                FillCbCarBrand();

            }
            else
            {
                LblWarning.Text = "Please Enter all (*) details!";
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = TxtCarName.Text;
            CarNames carBrand = db.CarNames.Find(this._selectedId);
            AvailableCars car = db.AvailableCars.Find(this._selectedId);
            carBrand.Name = TxtCarName.Text;
            car.Model = TxtCarModel.Text;
            car.Engine = NumEngine.Value;
            car.Year = Convert.ToInt32(NumYear.Value);
            car.RegNumber = TxtRegNum.Text;
            car.Price = Convert.ToInt32(NumPrice.Value);
            car.EditedAddedBy = this.AdminId;
            db.SaveChanges();
            LblWarning.Text = "";
            MessageBox.Show("You Have Updated  " + oldName + " to " + carBrand.Name);
            FillDGV();
            FillCbCarBrand();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = TxtCarName.Text;
            AvailableCars car = db.AvailableCars.Find(this._selectedId);
            db.AvailableCars.Remove(car);
            db.SaveChanges(); 
            LblWarning.Text = "";
            MessageBox.Show("You Have Deleted " + name);
            FillDGV();
            FillCbCarBrand();
        }

        private void CbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCarBrand.Text!="Choose")
            {
                TxtCarName.ReadOnly = true;
                TxtCarName.Text = CbCarBrand.Text;
            }
            else
            {
                TxtCarName.ReadOnly = false;
                TxtCarName.Text = "";
            }
        }
    }
}
