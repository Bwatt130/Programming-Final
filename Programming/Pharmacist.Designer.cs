namespace Programming
{
    partial class Pharmacist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.gboAddressInfo = new System.Windows.Forms.GroupBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblPharmacistID = new System.Windows.Forms.Label();
            this.gboContactInfo = new System.Windows.Forms.GroupBox();
            this.txtWorkEmail = new System.Windows.Forms.TextBox();
            this.lblWorkEmail = new System.Windows.Forms.Label();
            this.lblHomeEmail = new System.Windows.Forms.Label();
            this.txtHomeEmail = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cboSearchForPharmacistID = new System.Windows.Forms.ComboBox();
            this.btnDeletePharmacist = new System.Windows.Forms.Button();
            this.btnUpdatePharmacist = new System.Windows.Forms.Button();
            this.btnAddPharmacist = new System.Windows.Forms.Button();
            this.gboNameGender = new System.Windows.Forms.GroupBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMi = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gboMiscellaneousInfo = new System.Windows.Forms.GroupBox();
            this.txtYearlySalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.btnSearchPharmacist = new System.Windows.Forms.Button();
            this.ttP = new System.Windows.Forms.ToolTip(this.components);
            this.gboAddressInfo.SuspendLayout();
            this.gboContactInfo.SuspendLayout();
            this.gboNameGender.SuspendLayout();
            this.gboMiscellaneousInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboAddressInfo
            // 
            this.gboAddressInfo.Controls.Add(this.cboState);
            this.gboAddressInfo.Controls.Add(this.lblState);
            this.gboAddressInfo.Controls.Add(this.txtCity);
            this.gboAddressInfo.Controls.Add(this.lblCity);
            this.gboAddressInfo.Controls.Add(this.txtZip);
            this.gboAddressInfo.Controls.Add(this.lblZip);
            this.gboAddressInfo.Controls.Add(this.txtAddress);
            this.gboAddressInfo.Controls.Add(this.lblStreetAddress);
            this.gboAddressInfo.Location = new System.Drawing.Point(235, 32);
            this.gboAddressInfo.Name = "gboAddressInfo";
            this.gboAddressInfo.Size = new System.Drawing.Size(430, 140);
            this.gboAddressInfo.TabIndex = 31;
            this.gboAddressInfo.TabStop = false;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cboState.Location = new System.Drawing.Point(271, 54);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 45;
            this.ttP.SetToolTip(this.cboState, "Please Select Home State");
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(230, 57);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 86);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(142, 20);
            this.txtCity.TabIndex = 46;
            this.ttP.SetToolTip(this.txtCity, "City Text Box");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(66, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City: ";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(118, 54);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(85, 20);
            this.txtZip.TabIndex = 44;
            this.ttP.SetToolTip(this.txtZip, "Zip Code Text Box");
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(66, 57);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 20);
            this.txtAddress.TabIndex = 43;
            this.ttP.SetToolTip(this.txtAddress, "Home Address Text Box");
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(53, 28);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(48, 13);
            this.lblStreetAddress.TabIndex = 13;
            this.lblStreetAddress.Text = "Address:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(13, 25);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(33, 13);
            this.lblDateOfBirth.TabIndex = 35;
            this.lblDateOfBirth.Text = "DOB:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(91, 19);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 47;
            this.ttP.SetToolTip(this.dtpDOB, "Please Select Date Of Birth");
            // 
            // lblPharmacistID
            // 
            this.lblPharmacistID.AutoSize = true;
            this.lblPharmacistID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistID.Location = new System.Drawing.Point(12, 9);
            this.lblPharmacistID.Name = "lblPharmacistID";
            this.lblPharmacistID.Size = new System.Drawing.Size(90, 16);
            this.lblPharmacistID.TabIndex = 33;
            this.lblPharmacistID.Text = "Pharmacist ID";
            // 
            // gboContactInfo
            // 
            this.gboContactInfo.Controls.Add(this.txtWorkEmail);
            this.gboContactInfo.Controls.Add(this.lblWorkEmail);
            this.gboContactInfo.Controls.Add(this.lblHomeEmail);
            this.gboContactInfo.Controls.Add(this.txtHomeEmail);
            this.gboContactInfo.Controls.Add(this.txtWorkPhone);
            this.gboContactInfo.Controls.Add(this.lblWorkPhone);
            this.gboContactInfo.Controls.Add(this.lblHomePhone);
            this.gboContactInfo.Controls.Add(this.txtHomePhone);
            this.gboContactInfo.Location = new System.Drawing.Point(10, 265);
            this.gboContactInfo.Name = "gboContactInfo";
            this.gboContactInfo.Size = new System.Drawing.Size(655, 86);
            this.gboContactInfo.TabIndex = 33;
            this.gboContactInfo.TabStop = false;
            this.gboContactInfo.Text = "Contact";
            // 
            // txtWorkEmail
            // 
            this.txtWorkEmail.Location = new System.Drawing.Point(281, 57);
            this.txtWorkEmail.Name = "txtWorkEmail";
            this.txtWorkEmail.Size = new System.Drawing.Size(157, 20);
            this.txtWorkEmail.TabIndex = 53;
            this.ttP.SetToolTip(this.txtWorkEmail, "Work Email Address Text Box");
            // 
            // lblWorkEmail
            // 
            this.lblWorkEmail.AutoSize = true;
            this.lblWorkEmail.Location = new System.Drawing.Point(203, 60);
            this.lblWorkEmail.Name = "lblWorkEmail";
            this.lblWorkEmail.Size = new System.Drawing.Size(64, 13);
            this.lblWorkEmail.TabIndex = 19;
            this.lblWorkEmail.Text = "Work Email:";
            // 
            // lblHomeEmail
            // 
            this.lblHomeEmail.AutoSize = true;
            this.lblHomeEmail.Location = new System.Drawing.Point(203, 25);
            this.lblHomeEmail.Name = "lblHomeEmail";
            this.lblHomeEmail.Size = new System.Drawing.Size(66, 13);
            this.lblHomeEmail.TabIndex = 18;
            this.lblHomeEmail.Text = "Home Email:";
            // 
            // txtHomeEmail
            // 
            this.txtHomeEmail.Location = new System.Drawing.Point(281, 22);
            this.txtHomeEmail.Name = "txtHomeEmail";
            this.txtHomeEmail.Size = new System.Drawing.Size(157, 20);
            this.txtHomeEmail.TabIndex = 52;
            this.ttP.SetToolTip(this.txtHomeEmail, "Home Email Text Box");
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(91, 57);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(100, 20);
            this.txtWorkPhone.TabIndex = 51;
            this.ttP.SetToolTip(this.txtWorkPhone, "Work Phone Number Text Box");
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(13, 60);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(70, 13);
            this.lblWorkPhone.TabIndex = 15;
            this.lblWorkPhone.Text = "Work Phone:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(13, 25);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(72, 13);
            this.lblHomePhone.TabIndex = 14;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(91, 22);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(100, 20);
            this.txtHomePhone.TabIndex = 50;
            this.ttP.SetToolTip(this.txtHomePhone, "Home Phone Number Text Box");
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 39;
            this.ttP.SetToolTip(this.txtFirstName, "First Name Text Box");
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // cboSearchForPharmacistID
            // 
            this.cboSearchForPharmacistID.FormattingEnabled = true;
            this.cboSearchForPharmacistID.Location = new System.Drawing.Point(108, 8);
            this.cboSearchForPharmacistID.Name = "cboSearchForPharmacistID";
            this.cboSearchForPharmacistID.Size = new System.Drawing.Size(118, 21);
            this.cboSearchForPharmacistID.TabIndex = 38;
            this.ttP.SetToolTip(this.cboSearchForPharmacistID, "Please Select/Insert Pharmacist ID");
            this.cboSearchForPharmacistID.TextUpdate += new System.EventHandler(this.cboSearchForPharmacistID_TextUpdate);
            // 
            // btnDeletePharmacist
            // 
            this.btnDeletePharmacist.Location = new System.Drawing.Point(545, 357);
            this.btnDeletePharmacist.Name = "btnDeletePharmacist";
            this.btnDeletePharmacist.Size = new System.Drawing.Size(120, 23);
            this.btnDeletePharmacist.TabIndex = 57;
            this.btnDeletePharmacist.Text = "Delete Pharmacist";
            this.ttP.SetToolTip(this.btnDeletePharmacist, "Delete Existing Pharmacist");
            this.btnDeletePharmacist.UseVisualStyleBackColor = true;
            this.btnDeletePharmacist.Click += new System.EventHandler(this.btnDeletePharmacist_Click);
            // 
            // btnUpdatePharmacist
            // 
            this.btnUpdatePharmacist.Location = new System.Drawing.Point(365, 357);
            this.btnUpdatePharmacist.Name = "btnUpdatePharmacist";
            this.btnUpdatePharmacist.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePharmacist.TabIndex = 56;
            this.btnUpdatePharmacist.Text = "Update Pharmacist";
            this.ttP.SetToolTip(this.btnUpdatePharmacist, "Updates an Existing Pharmacist");
            this.btnUpdatePharmacist.UseVisualStyleBackColor = true;
            this.btnUpdatePharmacist.Click += new System.EventHandler(this.btnUpdatePharmacist_Click);
            // 
            // btnAddPharmacist
            // 
            this.btnAddPharmacist.Location = new System.Drawing.Point(10, 357);
            this.btnAddPharmacist.Name = "btnAddPharmacist";
            this.btnAddPharmacist.Size = new System.Drawing.Size(120, 23);
            this.btnAddPharmacist.TabIndex = 54;
            this.btnAddPharmacist.Text = "Add Pharmacist";
            this.ttP.SetToolTip(this.btnAddPharmacist, "Adds New Pharmacist to Database");
            this.btnAddPharmacist.UseVisualStyleBackColor = true;
            this.btnAddPharmacist.Click += new System.EventHandler(this.btnAddPharmacist_Click);
            // 
            // gboNameGender
            // 
            this.gboNameGender.Controls.Add(this.cboGender);
            this.gboNameGender.Controls.Add(this.lblMiddleInitial);
            this.gboNameGender.Controls.Add(this.lblFirstName);
            this.gboNameGender.Controls.Add(this.lblGender);
            this.gboNameGender.Controls.Add(this.txtLastName);
            this.gboNameGender.Controls.Add(this.txtMi);
            this.gboNameGender.Controls.Add(this.lblLastName);
            this.gboNameGender.Location = new System.Drawing.Point(10, 32);
            this.gboNameGender.Name = "gboNameGender";
            this.gboNameGender.Size = new System.Drawing.Size(200, 140);
            this.gboNameGender.TabIndex = 30;
            this.gboNameGender.TabStop = false;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(82, 104);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 42;
            this.ttP.SetToolTip(this.cboGender, "Please Select Gender");
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Location = new System.Drawing.Point(13, 47);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(22, 13);
            this.lblMiddleInitial.TabIndex = 13;
            this.lblMiddleInitial.Text = "MI:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 104);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(82, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 41;
            this.ttP.SetToolTip(this.txtLastName, "Last Name Text Box");
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtMi
            // 
            this.txtMi.Location = new System.Drawing.Point(82, 47);
            this.txtMi.Name = "txtMi";
            this.txtMi.Size = new System.Drawing.Size(100, 20);
            this.txtMi.TabIndex = 40;
            this.ttP.SetToolTip(this.txtMi, "Middle Initial Text Box");
            this.txtMi.TextChanged += new System.EventHandler(this.txtMi_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // gboMiscellaneousInfo
            // 
            this.gboMiscellaneousInfo.Controls.Add(this.txtYearlySalary);
            this.gboMiscellaneousInfo.Controls.Add(this.label1);
            this.gboMiscellaneousInfo.Controls.Add(this.dtpHireDate);
            this.gboMiscellaneousInfo.Controls.Add(this.lblDateOfBirth);
            this.gboMiscellaneousInfo.Controls.Add(this.dtpDOB);
            this.gboMiscellaneousInfo.Controls.Add(this.lblHireDate);
            this.gboMiscellaneousInfo.Location = new System.Drawing.Point(10, 178);
            this.gboMiscellaneousInfo.Name = "gboMiscellaneousInfo";
            this.gboMiscellaneousInfo.Size = new System.Drawing.Size(655, 81);
            this.gboMiscellaneousInfo.TabIndex = 32;
            this.gboMiscellaneousInfo.TabStop = false;
            // 
            // txtYearlySalary
            // 
            this.txtYearlySalary.Location = new System.Drawing.Point(391, 16);
            this.txtYearlySalary.Name = "txtYearlySalary";
            this.txtYearlySalary.Size = new System.Drawing.Size(142, 20);
            this.txtYearlySalary.TabIndex = 49;
            this.txtYearlySalary.Text = "0.0";
            this.ttP.SetToolTip(this.txtYearlySalary, "Yearly Salary Text Box");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Yearly Salary:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(91, 51);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 48;
            this.ttP.SetToolTip(this.dtpHireDate, "Please Select Hired Date");
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(13, 51);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(58, 13);
            this.lblHireDate.TabIndex = 24;
            this.lblHireDate.Text = "Hire Date: ";
            // 
            // btnSearchPharmacist
            // 
            this.btnSearchPharmacist.Location = new System.Drawing.Point(206, 357);
            this.btnSearchPharmacist.Name = "btnSearchPharmacist";
            this.btnSearchPharmacist.Size = new System.Drawing.Size(120, 23);
            this.btnSearchPharmacist.TabIndex = 55;
            this.btnSearchPharmacist.Text = "Search Pharmacist";
            this.ttP.SetToolTip(this.btnSearchPharmacist, "Search for Existing Pharmacist In Database");
            this.btnSearchPharmacist.UseVisualStyleBackColor = true;
            this.btnSearchPharmacist.Click += new System.EventHandler(this.btnSearchPharmacist_Click);
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 386);
            this.Controls.Add(this.gboAddressInfo);
            this.Controls.Add(this.lblPharmacistID);
            this.Controls.Add(this.gboContactInfo);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cboSearchForPharmacistID);
            this.Controls.Add(this.btnDeletePharmacist);
            this.Controls.Add(this.btnUpdatePharmacist);
            this.Controls.Add(this.btnSearchPharmacist);
            this.Controls.Add(this.btnAddPharmacist);
            this.Controls.Add(this.gboNameGender);
            this.Controls.Add(this.gboMiscellaneousInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 425);
            this.MinimumSize = new System.Drawing.Size(690, 425);
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.gboAddressInfo.ResumeLayout(false);
            this.gboAddressInfo.PerformLayout();
            this.gboContactInfo.ResumeLayout(false);
            this.gboContactInfo.PerformLayout();
            this.gboNameGender.ResumeLayout(false);
            this.gboNameGender.PerformLayout();
            this.gboMiscellaneousInfo.ResumeLayout(false);
            this.gboMiscellaneousInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboAddressInfo;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblPharmacistID;
        private System.Windows.Forms.GroupBox gboContactInfo;
        private System.Windows.Forms.TextBox txtWorkEmail;
        private System.Windows.Forms.Label lblWorkEmail;
        private System.Windows.Forms.Label lblHomeEmail;
        private System.Windows.Forms.TextBox txtHomeEmail;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboSearchForPharmacistID;
        private System.Windows.Forms.Button btnDeletePharmacist;
        private System.Windows.Forms.Button btnUpdatePharmacist;
        private System.Windows.Forms.Button btnAddPharmacist;
        private System.Windows.Forms.GroupBox gboNameGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMi;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gboMiscellaneousInfo;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnSearchPharmacist;
        private System.Windows.Forms.TextBox txtYearlySalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttP;
    }
}