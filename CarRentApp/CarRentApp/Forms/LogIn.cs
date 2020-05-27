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

namespace CarRentApp
{
    public partial class LogIn : Form
    {
        private CarRentEntities db;
        public LogIn()
        {
            InitializeComponent();
            this.db = new CarRentEntities();
        }
        private void Reset()
        {
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            LblWarning.Text = "";
        }
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsername.Text) && !string.IsNullOrEmpty(TxtPassword.Text))
            {
                if (db.Administrators.FirstOrDefault(a=>a.Username == TxtUsername.Text && a.Password==TxtPassword.Text)!=null)
                {
                    int adminId = db.Administrators.FirstOrDefault(a => a.Username == TxtUsername.Text).Id;
                    Dashboard dashboard = new Dashboard(adminId);
                    dashboard.Show();
                    Reset();
                }
                else
                {
                    LblWarning.Text = "  Please Enter correct \nUsername or Password";
                }
            }
            else
            {
                LblWarning.Text = "Please Enter Username and Password";
            }
        }
        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblWarning.Text = "";
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblWarning.Text = "";
        }
    }
}
