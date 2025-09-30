namespace DrivingLicenseManagement.PresantationLayer
{
    partial class frmAddEditPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPersonInfo = new System.Windows.Forms.GroupBox();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ptbPersonImage = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThird = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblAddUpdatePerson = new System.Windows.Forms.Label();
            this.grbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonInfo
            // 
            this.grbPersonInfo.Controls.Add(this.cmbNationality);
            this.grbPersonInfo.Controls.Add(this.cmbGender);
            this.grbPersonInfo.Controls.Add(this.dtpDateOfBirth);
            this.grbPersonInfo.Controls.Add(this.btnClose);
            this.grbPersonInfo.Controls.Add(this.btnSave);
            this.grbPersonInfo.Controls.Add(this.linkLabel2);
            this.grbPersonInfo.Controls.Add(this.linkLabel1);
            this.grbPersonInfo.Controls.Add(this.ptbPersonImage);
            this.grbPersonInfo.Controls.Add(this.label13);
            this.grbPersonInfo.Controls.Add(this.txtPhone);
            this.grbPersonInfo.Controls.Add(this.label12);
            this.grbPersonInfo.Controls.Add(this.label11);
            this.grbPersonInfo.Controls.Add(this.txtAddress);
            this.grbPersonInfo.Controls.Add(this.label10);
            this.grbPersonInfo.Controls.Add(this.txtEmail);
            this.grbPersonInfo.Controls.Add(this.label9);
            this.grbPersonInfo.Controls.Add(this.label8);
            this.grbPersonInfo.Controls.Add(this.txtNationalNo);
            this.grbPersonInfo.Controls.Add(this.label7);
            this.grbPersonInfo.Controls.Add(this.label6);
            this.grbPersonInfo.Controls.Add(this.txtLast);
            this.grbPersonInfo.Controls.Add(this.label5);
            this.grbPersonInfo.Controls.Add(this.txtThird);
            this.grbPersonInfo.Controls.Add(this.label4);
            this.grbPersonInfo.Controls.Add(this.txtSecond);
            this.grbPersonInfo.Controls.Add(this.label3);
            this.grbPersonInfo.Controls.Add(this.txtFirst);
            this.grbPersonInfo.Controls.Add(this.label2);
            this.grbPersonInfo.Location = new System.Drawing.Point(2, 168);
            this.grbPersonInfo.Name = "grbPersonInfo";
            this.grbPersonInfo.Size = new System.Drawing.Size(1056, 506);
            this.grbPersonInfo.TabIndex = 0;
            this.grbPersonInfo.TabStop = false;
            // 
            // cmbNationality
            // 
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(609, 219);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(189, 28);
            this.cmbNationality.TabIndex = 34;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(171, 165);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(189, 28);
            this.cmbGender.TabIndex = 33;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(609, 115);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(189, 26);
            this.dtpDateOfBirth.TabIndex = 32;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnClose.Image = global::DrivingLicenseManagement.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(647, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 52);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSave.Image = global::DrivingLicenseManagement.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(477, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 52);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(941, 346);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 22);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Remove";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(824, 346);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 22);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Set Image";
            // 
            // ptbPersonImage
            // 
            this.ptbPersonImage.Location = new System.Drawing.Point(828, 114);
            this.ptbPersonImage.Name = "ptbPersonImage";
            this.ptbPersonImage.Size = new System.Drawing.Size(189, 208);
            this.ptbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPersonImage.TabIndex = 27;
            this.ptbPersonImage.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(460, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Country :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(609, 166);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(189, 26);
            this.txtPhone.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(460, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Phone :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(460, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date Of Birth :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 283);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(627, 108);
            this.txtAddress.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Address :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(19, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gendor :";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(171, 114);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(189, 26);
            this.txtNationalNo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Natoinal No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(849, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(828, 64);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(189, 26);
            this.txtLast.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(685, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Third";
            // 
            // txtThird
            // 
            this.txtThird.Location = new System.Drawing.Point(609, 64);
            this.txtThird.Name = "txtThird";
            this.txtThird.Size = new System.Drawing.Size(189, 26);
            this.txtThird.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(450, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Second";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(390, 64);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(189, 26);
            this.txtSecond.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(241, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "First";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(171, 63);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(189, 26);
            this.txtFirst.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPerson.Location = new System.Drawing.Point(21, 113);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(110, 22);
            this.lblPerson.TabIndex = 1;
            this.lblPerson.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.Location = new System.Drawing.Point(177, 113);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(32, 22);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "??";
            // 
            // lblAddUpdatePerson
            // 
            this.lblAddUpdatePerson.AutoSize = true;
            this.lblAddUpdatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddUpdatePerson.ForeColor = System.Drawing.Color.Blue;
            this.lblAddUpdatePerson.Location = new System.Drawing.Point(414, 62);
            this.lblAddUpdatePerson.Name = "lblAddUpdatePerson";
            this.lblAddUpdatePerson.Size = new System.Drawing.Size(216, 32);
            this.lblAddUpdatePerson.TabIndex = 3;
            this.lblAddUpdatePerson.Text = "Update Person";
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 686);
            this.Controls.Add(this.lblAddUpdatePerson);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.grbPersonInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPerson";
            this.Text = "Add / Edit Person Info";
            this.grbPersonInfo.ResumeLayout(false);
            this.grbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.GroupBox grbPersonInfo;
        public System.Windows.Forms.TextBox txtThird;
        public System.Windows.Forms.TextBox txtSecond;
        public System.Windows.Forms.TextBox txtFirst;
        public System.Windows.Forms.TextBox txtLast;
        public System.Windows.Forms.TextBox txtNationalNo;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.PictureBox ptbPersonImage;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        public System.Windows.Forms.Label lblAddUpdatePerson;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.ComboBox cmbNationality;
        public System.Windows.Forms.Label lblPersonID;
    }
}