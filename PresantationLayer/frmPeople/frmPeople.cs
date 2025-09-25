using DrivingLicenseManagement.PresantationLayer;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using DrivingLicenseManagement.BL;

namespace DrivingLicenseManagement.PL
{
    public partial class frmPeople : Form
    {
        clsPeople people = new clsPeople();
        public frmPeople()
        {
            InitializeComponent();
            dgvPeopleList.DataSource = people.getAllPeople();
            lblRecodrs.Text = (dgvPeopleList.RowCount - 1).ToString();
            lblRecodrs.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
        }
        // Read Person
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            // dgvPeopleList.CurrentRow.Cells[0].Value
        }
        // Delete Person
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    people.deletePerson(dgvPeopleList.CurrentRow.Cells[0].Value.ToString());
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
