using DrivingLicenseManagement;
using DrivingLicenseManagement.BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace DrivingLicenseManagement.PresantationLayer
{
    public partial class frmAddEditPerson : Form
    {
        clsCountries countries = new clsCountries();
        public frmAddEditPerson()
        {
            InitializeComponent();
            cmbNationality.DataSource = countries.getAllCountries();
            cmbNationality.DisplayMember = "CountryName";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool btnSaveClicked = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveClicked = true;
            this.Close();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGender.SelectedItem != null)
                {
                    string gender = cmbGender.SelectedItem.ToString();

                    if (gender == "Male")
                    {
                        ptbPersonImage.Image = Image.FromFile(@"C:\all_my_projects\DrivingLicenceManagementSystem\Icons\Icons.Male512.png");
                    }
                    else if (gender == "Female")
                    {
                        ptbPersonImage.Image = Image.FromFile(@"C:\all_my_projects\DrivingLicenceManagementSystem\Icons\Icons.Female512.png");
                    }
                    else
                    {
                        ptbPersonImage.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ptbPersonImage.Image = null; 
            }
        }
    }
}
