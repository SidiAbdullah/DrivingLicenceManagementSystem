using System;
using System.Windows.Forms;

namespace DrivingLicenseManagement.PL
{
    public partial class frmPeople : Form
    {
        BL.buisnessLayer bl = new BL.buisnessLayer();
        public frmPeople()
        {
            InitializeComponent();
            dgvPeopleList.DataSource = bl.getAllPeople();
            lblRecodrs.Text = (dgvPeopleList.RowCount - 1).ToString();
            lblRecodrs.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = cmbFilterBy.SelectedItem.ToString();
            txtFilter.Visible = true;
        }
    }
}
