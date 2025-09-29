using DrivingLicenseManagement.BL;
using DrivingLicenseManagement.PresantationLayer;
using DrivingLicenseManagement.PresantationLayer.frmPeople;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DrivingLicenseManagement.PL
{
    public partial class frmPeople : Form
    {
        clsPeople people = new clsPeople();
        public frmPeople()
        {
            InitializeComponent();
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvPeopleList.DataSource = people.getAllPeople();
            lblRecodrs.Text = (dgvPeopleList.RowCount - 1).ToString();
            lblRecodrs.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Read Person
        // 1. getBySearch
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
        }
        private void txtFilter_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = null;
            string filterValue = txtFilter.Text;

            if (string.IsNullOrEmpty(filterValue))
                return;

            switch (cmbFilterBy.SelectedItem.ToString())
            {
                case "PersonID":
                    if (int.TryParse(filterValue, out int personID))
                        dt = people.getPersonByID(personID);
                    break;

                case "NationalNo":
                    dt = people.getPersonByNationalNo(filterValue);
                    break;

                case "FirstName":
                    dt = people.getPersonByFirstName(filterValue);
                    break;

                case "SecondName":
                    dt = people.getPersonBySecondName(filterValue);
                    break;

                case "ThirdName":
                    dt = people.getPersonByThirdName(filterValue);
                    break;

                case "LastName":
                    dt = people.getPersonByLastName(filterValue);
                    break;

                //case "Nationality":
                //    dt = people.getPersonByNationalityNo(filterValue);
                //    break;

                case "Gendor":
                    dt = people.getPersonByGendor(filterValue);
                    break;

                case "Phone":
                    dt = people.getPersonByPhone(filterValue);
                    break;

                case "Email":
                    dt = people.getPersonByGmail(filterValue);
                    break;
            }

            if (dt != null)
            {
                dgvPeopleList.DataSource = dt;
            }
        }

        // 2. getAll
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails();
            int personID = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);
            personDetails.lblPersonID.Text = personID.ToString();


            byte[] imgBytes = people.GetPersonPhoto(personID);

            if (imgBytes != null && imgBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    personDetails.ptbPersonImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                personDetails.ptbPersonImage.Image = null; 
            }


            personDetails.lblNationalNo.Text = dgvPeopleList.CurrentRow.Cells[1].Value.ToString();
            personDetails.lblName.Text = dgvPeopleList.CurrentRow.Cells[2].Value.ToString() + " " + 
                                         dgvPeopleList.CurrentRow.Cells[3].Value.ToString() + " " +
                                         dgvPeopleList.CurrentRow.Cells[4].Value.ToString() + " " +
                                         dgvPeopleList.CurrentRow.Cells[5].Value.ToString();
            personDetails.lblGendor.Text = dgvPeopleList.CurrentRow.Cells[6].Value.ToString();
            personDetails.lblDateOfBirth.Text = dgvPeopleList.CurrentRow.Cells[7].Value.ToString();
            personDetails.lblCountry.Text = dgvPeopleList.CurrentRow.Cells[8].Value.ToString();
            personDetails.lblPhone.Text = dgvPeopleList.CurrentRow.Cells[9].Value.ToString();
            personDetails.lblEmail.Text = dgvPeopleList.CurrentRow.Cells[10].Value.ToString();
            personDetails.ShowDialog();
        }
        // Delete Person
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    people.deletePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
                    dgvPeopleList.DataSource = people.getAllPeople();
                    lblRecodrs.Text = dgvPeopleList.RowCount.ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Person
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson();
            addEditPerson.lblAddUpdatePerson.Text = "Add Person";
            addEditPerson.ShowDialog();

            if (addEditPerson.btnSaveClicked)
            {
                try
                {
                    byte gendorAsByte = (addEditPerson.cmbGender.SelectedItem.ToString() == "Male") ? (byte)0 : (byte)1;

                    byte[] imageBytes = null;
                    if (addEditPerson.ptbPersonImage.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            addEditPerson.ptbPersonImage.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    people.addNewPerson(
                        addEditPerson.txtNationalNo.Text,
                        addEditPerson.txtFirst.Text,
                        addEditPerson.txtSecond.Text,
                        addEditPerson.txtThird.Text,
                        addEditPerson.txtLast.Text,
                        addEditPerson.dtpDateOfBirth.Value,
                        gendorAsByte,
                        addEditPerson.txtAddress.Text,
                        addEditPerson.txtPhone.Text,
                        addEditPerson.txtEmail.Text,
                        Convert.ToInt32(addEditPerson.cmbNationality.SelectedValue),
                        imageBytes
                    );

                    dgvPeopleList.DataSource = people.getAllPeople();
                    lblRecodrs.Text = (dgvPeopleList.RowCount - 1).ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            btnAddPerson_Click(sender, e);
        }

        // Edit Person
        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson();
            addEditPerson.lblAddUpdatePerson.Text = "Update Person";

            addEditPerson.lblPersonID.Text = dgvPeopleList.CurrentRow.Cells[0].Value.ToString();
            addEditPerson.txtFirst.Text = dgvPeopleList.CurrentRow.Cells[1].Value.ToString();
            addEditPerson.txtSecond.Text = dgvPeopleList.CurrentRow.Cells[2].Value.ToString();
            addEditPerson.txtThird.Text = dgvPeopleList.CurrentRow.Cells[3].Value.ToString();
            addEditPerson.txtLast.Text = dgvPeopleList.CurrentRow.Cells[4].Value.ToString();
            addEditPerson.txtNationalNo.Text = dgvPeopleList.CurrentRow.Cells[5].Value.ToString();
            addEditPerson.dtpDateOfBirth.Value = Convert.ToDateTime(dgvPeopleList.CurrentRow.Cells[6].Value);

            byte genderValue = Convert.ToByte(dgvPeopleList.CurrentRow.Cells[7].Value);
            addEditPerson.cmbGender.SelectedItem = (genderValue == 0) ? "Male" : "Female";

            addEditPerson.txtAddress.Text = dgvPeopleList.CurrentRow.Cells[8].Value.ToString();
            addEditPerson.txtPhone.Text = dgvPeopleList.CurrentRow.Cells[9].Value.ToString();
            addEditPerson.txtEmail.Text = dgvPeopleList.CurrentRow.Cells[10].Value.ToString();
            addEditPerson.cmbNationality.SelectedValue = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[11].Value);

            if (dgvPeopleList.CurrentRow.Cells[12].Value != DBNull.Value)
            {
                byte[] imageBytes = (byte[])dgvPeopleList.CurrentRow.Cells[12].Value;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    addEditPerson.ptbPersonImage.Image = System.Drawing.Image.FromStream(ms);
                }
            }

            addEditPerson.ShowDialog();

            if (addEditPerson.btnSaveClicked)
            {
                try
                {
                    byte gendorAsByte = (addEditPerson.cmbGender.SelectedItem.ToString() == "Male") ? (byte)0 : (byte)1;

                    byte[] imageBytes = null;
                    if (addEditPerson.ptbPersonImage.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            addEditPerson.ptbPersonImage.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    people.updatePerson(
                        addEditPerson.txtNationalNo.Text,
                        addEditPerson.txtFirst.Text,
                        addEditPerson.txtSecond.Text,
                        addEditPerson.txtThird.Text,
                        addEditPerson.txtLast.Text,
                        addEditPerson.dtpDateOfBirth.Value,
                        gendorAsByte,
                        addEditPerson.txtAddress.Text,
                        addEditPerson.txtPhone.Text,
                        addEditPerson.txtEmail.Text,
                        Convert.ToInt32(addEditPerson.cmbNationality.SelectedValue),
                        imageBytes
                    );

                    dgvPeopleList.DataSource = people.getAllPeople();
                    lblRecodrs.Text = (dgvPeopleList.RowCount - 1).ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
