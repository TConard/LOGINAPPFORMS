using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAppForms2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newVendorInfoDataSet.NewVendorsDB' table. You can move, or remove it, as needed.
            this.newVendorsDBTableAdapter1.Fill(this.newVendorInfoDataSet.NewVendorsDB);

        }

        private void btnBackLogIn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Close();
        }

        private void btnNewVendorLog_Click(object sender, EventArgs e)
        {
            this.newVendorsDBTableAdapter1.Fill(this.newVendorInfoDataSet.NewVendorsDB);
            dgNewVendor.DataSource = this.newVendorInfoDataSet.NewVendorsDB;
            new NewVendorInfo().Show();
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorLoginDataSet.VendorCredentials' table. You can move, or remove it, as needed.
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials);
            dgUserData.DataSource = this.vendorLoginDataSet.VendorCredentials;
            dgUserData.Visible = true;
            dgUserData.BringToFront();
            dgVendorDelivery.Visible = false;
            dgNewVendor.Visible = false;
        }

        private void btnViewVendorData_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorLoginDataSet.VendorCredentials' table. You can move, or remove it, as needed.
            this.newVendorsDBTableAdapter.Fill(this.newVendorInfoData.NewVendorsDB);
            dgNewVendor.DataSource = this.newVendorInfoData.NewVendorsDB;
            dgNewVendor.Visible = true;
            dgNewVendor.BringToFront();
            dgVendorDelivery.Visible = false;
            dgUserData.Visible = false;
        }

        private void btnViewVendorDelivery_Click(object sender, EventArgs e)
        {
            this.vendorInfo2TableAdapter.Fill(this.vendorInfo2Data.VendorInfo2);
            dgVendorDelivery.DataSource = this.vendorInfo2Data.VendorInfo2;
            dgVendorDelivery.Visible = true;
            dgVendorDelivery.BringToFront();
            dgUserData.Visible = false;
            dgNewVendor.Visible = false;
        }
    }
}
