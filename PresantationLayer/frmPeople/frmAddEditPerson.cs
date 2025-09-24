using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicenseManagement.PresantationLayer
{
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool btnSaveClicked = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveClicked = true;
        }
    }
}
