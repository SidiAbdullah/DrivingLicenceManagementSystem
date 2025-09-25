using DrivingLicenseManagement;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DrivingLicenseManagement.BusinessLayer;


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
            cmbNationality.ValueMember = "CountryID";

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
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
                        ptbPersonImage.Image = Image.FromFile(@"C:\all_my_projects\DrivingLicenceManagementSystem\Icons\Icons\Male.png");
                    }
                    else if (gender == "Female")
                    {
                        ptbPersonImage.Image = Image.FromFile(@"C:\all_my_projects\DrivingLicenceManagementSystem\Icons\Icons\Female.png");
                    }
                    else
                    {
                        ptbPersonImage.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in uploading photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ptbPersonImage.Image = null; 
            }
        }
    }
}
