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
    public partial class CustomersOptions : Form
    {
        private CarRentEntities db;
        private int _selectedId;
        int adminId = 0;
        public CustomersOptions(int AdminId)
        {
            InitializeComponent();

            this.db = new CarRentEntities();
            this.adminId = AdminId;
            LblAdmin.Text += db.Administrators.Find(this.adminId).Name + " " + db.Administrators.Find(this.adminId).Surname;
            FillDGV();
        }
        private void FillDGV()
        {
            DgvCustomers.Rows.Clear();
            foreach (Customers c in db.Customers.ToList())
            {
                DgvCustomers.Rows.Add(c.Id, c.Name, c.Surname, c.Email, c.Address, c.Phone, c.Identification,c.EditedAddedBy);
            }
            Reset();
        }
        private void Reset()
        {
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            RtbAddress.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtId.Text = string.Empty;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            NewRent rent = new NewRent(this.adminId);
            rent.Show();
            this.Close();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = TxtFirstName.Text;
            Customers customer = db.Customers.Find(this._selectedId);
            customer.Name = TxtFirstName.Text;
            customer.Surname = TxtLastName.Text;
            customer.Email = TxtEmail.Text;
            customer.Address = RtbAddress.Text;
            customer.Phone = TxtPhone.Text;
            customer.Identification = TxtId.Text;
            customer.EditedAddedBy = this.adminId;
            db.SaveChanges();
            MessageBox.Show("You Have Updated " + oldName + " to " + customer.Name);
            FillDGV();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = TxtFirstName.Text;
            Customers customer = db.Customers.Find(this._selectedId);
            db.Customers.Remove(customer);
            db.SaveChanges();
            MessageBox.Show("You Have Deleted " + name);
            FillDGV();
        }

        private void DgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this._selectedId = Convert.ToInt32(DgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            TxtFirstName.Text = DgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtLastName.Text = DgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtEmail.Text = DgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            RtbAddress.Text = DgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtPhone.Text = DgvCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtId.Text = DgvCustomers.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text) &&
               !string.IsNullOrWhiteSpace(TxtLastName.Text) &&
               !string.IsNullOrWhiteSpace(TxtPhone.Text) &&
               !string.IsNullOrWhiteSpace(TxtEmail.Text) &&
               !string.IsNullOrWhiteSpace(RtbAddress.Text) &&
               !string.IsNullOrWhiteSpace(TxtId.Text))
            {
                if (db.Administrators.FirstOrDefault(a => a.Identification == TxtId.Text) == null)
                {
                    Customers customer = new Customers();
                    customer.Name = TxtFirstName.Text;
                    customer.Surname = TxtLastName.Text;
                    customer.Email = TxtEmail.Text;
                    customer.Address = RtbAddress.Text;
                    customer.Phone = TxtPhone.Text;
                    customer.Identification = TxtId.Text;
                    customer.EditedAddedBy = this.adminId;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    LblWarning.Text = "";
                    MessageBox.Show(" " + TxtFirstName.Text + " " + TxtLastName.Text + " As An Customer");
                    FillDGV();
                }
                else
                {
                    LblWarning.Text = "This Username exists,Please choose another one";
                }
            }
            else
            {
                LblWarning.Text = "Please Enter all (*) details!";
            }
        }
    }
}
