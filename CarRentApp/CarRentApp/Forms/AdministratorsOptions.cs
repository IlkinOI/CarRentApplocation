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
    public partial class AdministratorsOptions : Form
    {
        private CarRentEntities db;
        private int _selectedId;
        int adminId = 0;
        public AdministratorsOptions(int AdminId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.adminId = AdminId;
            LblAdmin.Text += db.Administrators.Find(this.adminId).Name + " " + db.Administrators.Find(this.adminId).Surname;
            FillDGV();
        }
        private void FillDGV()
        {
            DgvAdmins.Rows.Clear();
            foreach (Administrators a in db.Administrators.ToList())
            {
                DgvAdmins.Rows.Add(a.Id, a.Name, a.Surname, a.Username, a.Password, a.Email, a.Address, a.Phone, a.Identification,a.AddedEditedBy);
            }
            Reset();
        }
        private void Reset()
        {
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtUserName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            RtbAddress.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtId.Text = string.Empty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(TxtLastName.Text) &&
                !string.IsNullOrWhiteSpace(TxtUserName.Text) &&
                !string.IsNullOrWhiteSpace(TxtPassword.Text) &&
                !string.IsNullOrWhiteSpace(TxtPhone.Text) &&
                !string.IsNullOrWhiteSpace(TxtEmail.Text) &&
                !string.IsNullOrWhiteSpace(RtbAddress.Text) &&
                !string.IsNullOrWhiteSpace(TxtId.Text))
            {
                if (db.Administrators.FirstOrDefault(a=>a.Username==TxtUserName.Text)==null)
                {
                    Administrators admin = new Administrators();
                    admin.Name = TxtFirstName.Text;
                    admin.Surname = TxtLastName.Text;
                    admin.Username = TxtUserName.Text;
                    admin.Password = TxtPassword.Text;
                    admin.Email = TxtEmail.Text;
                    admin.Address = RtbAddress.Text;
                    admin.Phone = TxtPhone.Text;
                    admin.Identification = TxtId.Text;
                    admin.AddedEditedBy = this.adminId;
                    db.Administrators.Add(admin);
                    db.SaveChanges();
                    LblWarning.Text = "";
                    MessageBox.Show(" "+TxtFirstName.Text + " " + TxtLastName.Text + " As An Admin");
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = TxtFirstName.Text;
            Administrators admin = db.Administrators.Find(this._selectedId);
            admin.Name = TxtFirstName.Text;
            admin.Surname = TxtLastName.Text;
            admin.Username = TxtUserName.Text;
            admin.Password = TxtPassword.Text;
            admin.Email = TxtEmail.Text;
            admin.Address = RtbAddress.Text;
            admin.Phone = TxtPhone.Text;
            admin.Identification = TxtId.Text;
            admin.AddedEditedBy = this.adminId;
            db.SaveChanges();
            MessageBox.Show("You Have Updated " + oldName + " to " + admin.Name);
            FillDGV();
        }

        private void DgvAdmins_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this._selectedId = Convert.ToInt32(DgvAdmins.Rows[e.RowIndex].Cells[0].Value);
            TxtFirstName.Text = DgvAdmins.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtLastName.Text = DgvAdmins.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtUserName.Text = DgvAdmins.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtPassword.Text = DgvAdmins.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtEmail.Text = DgvAdmins.Rows[e.RowIndex].Cells[5].Value.ToString();
            RtbAddress.Text = DgvAdmins.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtPhone.Text = DgvAdmins.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtId.Text = DgvAdmins.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = TxtFirstName.Text;
            Administrators admin = db.Administrators.Find(this._selectedId);
            db.Administrators.Remove(admin);
            db.SaveChanges();
            MessageBox.Show("You Have Deleted " + name);
            FillDGV();
        }
    }
}
