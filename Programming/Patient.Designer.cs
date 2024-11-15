using System;

namespace Programming
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.gboContactInfo = new System.Windows.Forms.GroupBox();
            this.txtWorkEmail = new System.Windows.Forms.TextBox();
            this.lblWorkEmail = new System.Windows.Forms.Label();
            this.lblPersonalEmail = new System.Windows.Forms.Label();
            this.txtPersonalEmail = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.cboSearchForPatientID = new System.Windows.Forms.ComboBox();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.gboNameGender = new System.Windows.Forms.GroupBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMi = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gboMiscellaneousInfo = new System.Windows.Forms.GroupBox();
            this.txtInsuranceThree = new System.Windows.Forms.TextBox();
            this.txtInsuranceTwo = new System.Windows.Forms.TextBox();
            this.txtInsuranceOne = new System.Windows.Forms.TextBox();
            this.txtPolicyThree = new System.Windows.Forms.TextBox();
            this.txtPolicyTwo = new System.Windows.Forms.TextBox();
            this.txtPolicyOne = new System.Windows.Forms.TextBox();
            this.lblPolicyNumber = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.lblCurrentDoctor = new System.Windows.Forms.Label();
            this.txtCurrentDoctor = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gboAddressInfo.SuspendLayout();
            this.gboContactInfo.SuspendLayout();
            this.gboNameGender.SuspendLayout();
            this.gboMiscellaneousInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.gboAddressInfo.Location = new System.Drawing.Point(239, 37);
            this.gboAddressInfo.Name = "gboAddressInfo";
            this.gboAddressInfo.Size = new System.Drawing.Size(435, 140);
            this.gboAddressInfo.TabIndex = 49;
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
            "Georgia",
            "Guam",
            "Hawaii",
            "Idaho",
            "Illinois",
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
            "New Jersey",
            "New Mexico",
            "New York",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Puerto Rico",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cboState.Location = new System.Drawing.Point(271, 54);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cboState, "State Dropdown");
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
            this.txtCity.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtCity, "City Text Box");
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
            this.txtZip.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtZip, "Zip Code Text Box");
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
            this.txtAddress.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtAddress, "Address Text Box");
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
            this.lblDateOfBirth.Location = new System.Drawing.Point(16, 196);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(33, 13);
            this.lblDateOfBirth.TabIndex = 48;
            this.lblDateOfBirth.Text = "DOB:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Checked = false;
            this.dtpDOB.Location = new System.Drawing.Point(55, 193);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(203, 20);
            this.dtpDOB.TabIndex = 21;
            this.toolTip1.SetToolTip(this.dtpDOB, "Please Select Date");
            this.dtpDOB.Value = new System.DateTime(2024, 11, 9, 0, 0, 0, 0);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(11, 11);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(64, 16);
            this.lblPatientID.TabIndex = 46;
            this.lblPatientID.Text = "Patient ID";
            // 
            // gboContactInfo
            // 
            this.gboContactInfo.Controls.Add(this.txtWorkEmail);
            this.gboContactInfo.Controls.Add(this.lblWorkEmail);
            this.gboContactInfo.Controls.Add(this.lblPersonalEmail);
            this.gboContactInfo.Controls.Add(this.txtPersonalEmail);
            this.gboContactInfo.Controls.Add(this.txtWorkPhone);
            this.gboContactInfo.Controls.Add(this.lblWorkPhone);
            this.gboContactInfo.Controls.Add(this.lblHomePhone);
            this.gboContactInfo.Controls.Add(this.txtHomePhone);
            this.gboContactInfo.Location = new System.Drawing.Point(14, 306);
            this.gboContactInfo.Name = "gboContactInfo";
            this.gboContactInfo.Size = new System.Drawing.Size(660, 86);
            this.gboContactInfo.TabIndex = 51;
            this.gboContactInfo.TabStop = false;
            this.gboContactInfo.Text = "Contact";
            // 
            // txtWorkEmail
            // 
            this.txtWorkEmail.Location = new System.Drawing.Point(288, 57);
            this.txtWorkEmail.Name = "txtWorkEmail";
            this.txtWorkEmail.Size = new System.Drawing.Size(157, 20);
            this.txtWorkEmail.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtWorkEmail, "Work Email Text Box");
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
            // lblPersonalEmail
            // 
            this.lblPersonalEmail.AutoSize = true;
            this.lblPersonalEmail.Location = new System.Drawing.Point(203, 25);
            this.lblPersonalEmail.Name = "lblPersonalEmail";
            this.lblPersonalEmail.Size = new System.Drawing.Size(79, 13);
            this.lblPersonalEmail.TabIndex = 18;
            this.lblPersonalEmail.Text = "Personal Email:";
            // 
            // txtPersonalEmail
            // 
            this.txtPersonalEmail.Location = new System.Drawing.Point(288, 22);
            this.txtPersonalEmail.Name = "txtPersonalEmail";
            this.txtPersonalEmail.Size = new System.Drawing.Size(157, 20);
            this.txtPersonalEmail.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtPersonalEmail, "Personal Email Text Box");
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(91, 57);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(100, 20);
            this.txtWorkPhone.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtWorkPhone, "Work Phone Text Box");
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
            this.txtHomePhone.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txtHomePhone, "Home Phone Text Box");
            // 
            // cboSearchForPatientID
            // 
            this.cboSearchForPatientID.FormattingEnabled = true;
            this.cboSearchForPatientID.Location = new System.Drawing.Point(96, 10);
            this.cboSearchForPatientID.Name = "cboSearchForPatientID";
            this.cboSearchForPatientID.Size = new System.Drawing.Size(118, 21);
            this.cboSearchForPatientID.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboSearchForPatientID, "Please select/enter patient ID");
            this.cboSearchForPatientID.TextUpdate += new System.EventHandler(this.cboSearchForPatientID_TextUpdate);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(554, 398);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(120, 23);
            this.btnDeletePatient.TabIndex = 37;
            this.btnDeletePatient.Text = "Delete Patient";
            this.toolTip1.SetToolTip(this.btnDeletePatient, "Deletes Selected Patient from Database");
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(379, 398);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePatient.TabIndex = 36;
            this.btnUpdatePatient.Text = "Update Patient";
            this.toolTip1.SetToolTip(this.btnUpdatePatient, "Update an already existing patient");
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(194, 398);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(120, 23);
            this.btnSearchPatient.TabIndex = 35;
            this.btnSearchPatient.Text = "Search Patient";
            this.toolTip1.SetToolTip(this.btnSearchPatient, "Retrieves Patient Information");
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(14, 398);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(120, 23);
            this.btnAddPatient.TabIndex = 34;
            this.btnAddPatient.Text = "Add Patient";
            this.toolTip1.SetToolTip(this.btnAddPatient, "Adds Patient to Database");
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // gboNameGender
            // 
            this.gboNameGender.Controls.Add(this.cboGender);
            this.gboNameGender.Controls.Add(this.lblMiddleInitial);
            this.gboNameGender.Controls.Add(this.lblFirstName);
            this.gboNameGender.Controls.Add(this.lblGender);
            this.gboNameGender.Controls.Add(this.txtLastName);
            this.gboNameGender.Controls.Add(this.txtFirstName);
            this.gboNameGender.Controls.Add(this.txtMi);
            this.gboNameGender.Controls.Add(this.lblLastName);
            this.gboNameGender.Location = new System.Drawing.Point(14, 37);
            this.gboNameGender.Name = "gboNameGender";
            this.gboNameGender.Size = new System.Drawing.Size(219, 140);
            this.gboNameGender.TabIndex = 48;
            this.gboNameGender.TabStop = false;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(91, 105);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cboGender, "Pleas Select Gender");
            this.cboGender.TextUpdate += new System.EventHandler(this.cboGender_TextUpdate);
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
            this.txtLastName.Location = new System.Drawing.Point(91, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtLastName, "Last Name Text Box");
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtFirstName, "First Name Text Box");
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtMi
            // 
            this.txtMi.Location = new System.Drawing.Point(91, 48);
            this.txtMi.Name = "txtMi";
            this.txtMi.Size = new System.Drawing.Size(100, 20);
            this.txtMi.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtMi, "Middle Inital Text Box");
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
            this.gboMiscellaneousInfo.Controls.Add(this.txtInsuranceThree);
            this.gboMiscellaneousInfo.Controls.Add(this.txtInsuranceTwo);
            this.gboMiscellaneousInfo.Controls.Add(this.txtInsuranceOne);
            this.gboMiscellaneousInfo.Controls.Add(this.txtPolicyThree);
            this.gboMiscellaneousInfo.Controls.Add(this.txtPolicyTwo);
            this.gboMiscellaneousInfo.Controls.Add(this.txtPolicyOne);
            this.gboMiscellaneousInfo.Controls.Add(this.lblPolicyNumber);
            this.gboMiscellaneousInfo.Controls.Add(this.lblInsurance);
            this.gboMiscellaneousInfo.Controls.Add(this.lblAccountBalance);
            this.gboMiscellaneousInfo.Controls.Add(this.txtAccBalance);
            this.gboMiscellaneousInfo.Controls.Add(this.lblCurrentDoctor);
            this.gboMiscellaneousInfo.Controls.Add(this.txtCurrentDoctor);
            this.gboMiscellaneousInfo.Location = new System.Drawing.Point(14, 219);
            this.gboMiscellaneousInfo.Name = "gboMiscellaneousInfo";
            this.gboMiscellaneousInfo.Size = new System.Drawing.Size(660, 81);
            this.gboMiscellaneousInfo.TabIndex = 50;
            this.gboMiscellaneousInfo.TabStop = false;
            // 
            // txtInsuranceThree
            // 
            this.txtInsuranceThree.Location = new System.Drawing.Point(517, 20);
            this.txtInsuranceThree.Name = "txtInsuranceThree";
            this.txtInsuranceThree.Size = new System.Drawing.Size(121, 20);
            this.txtInsuranceThree.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtInsuranceThree, "Insurance 3 Text Box");
            // 
            // txtInsuranceTwo
            // 
            this.txtInsuranceTwo.Location = new System.Drawing.Point(390, 20);
            this.txtInsuranceTwo.Name = "txtInsuranceTwo";
            this.txtInsuranceTwo.Size = new System.Drawing.Size(121, 20);
            this.txtInsuranceTwo.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtInsuranceTwo, "Insurance 2 Text Box");
            // 
            // txtInsuranceOne
            // 
            this.txtInsuranceOne.Location = new System.Drawing.Point(263, 20);
            this.txtInsuranceOne.Name = "txtInsuranceOne";
            this.txtInsuranceOne.Size = new System.Drawing.Size(121, 20);
            this.txtInsuranceOne.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtInsuranceOne, "Insurance 1 Text Box");
            // 
            // txtPolicyThree
            // 
            this.txtPolicyThree.Location = new System.Drawing.Point(517, 55);
            this.txtPolicyThree.Name = "txtPolicyThree";
            this.txtPolicyThree.Size = new System.Drawing.Size(121, 20);
            this.txtPolicyThree.TabIndex = 29;
            this.toolTip1.SetToolTip(this.txtPolicyThree, "Policy 3 Text Box");
            // 
            // txtPolicyTwo
            // 
            this.txtPolicyTwo.Location = new System.Drawing.Point(390, 55);
            this.txtPolicyTwo.Name = "txtPolicyTwo";
            this.txtPolicyTwo.Size = new System.Drawing.Size(121, 20);
            this.txtPolicyTwo.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txtPolicyTwo, "Policy 2 Text Box");
            // 
            // txtPolicyOne
            // 
            this.txtPolicyOne.Location = new System.Drawing.Point(263, 55);
            this.txtPolicyOne.Name = "txtPolicyOne";
            this.txtPolicyOne.Size = new System.Drawing.Size(121, 20);
            this.txtPolicyOne.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtPolicyOne, "Policy 1 Text Box");
            // 
            // lblPolicyNumber
            // 
            this.lblPolicyNumber.AutoSize = true;
            this.lblPolicyNumber.Location = new System.Drawing.Point(203, 57);
            this.lblPolicyNumber.Name = "lblPolicyNumber";
            this.lblPolicyNumber.Size = new System.Drawing.Size(45, 13);
            this.lblPolicyNumber.TabIndex = 27;
            this.lblPolicyNumber.Text = "Policy #";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(203, 23);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(57, 13);
            this.lblInsurance.TabIndex = 26;
            this.lblInsurance.Text = "Insurance:";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(24, 42);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(49, 26);
            this.lblAccountBalance.TabIndex = 24;
            this.lblAccountBalance.Text = "Account\r\nBalance:";
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.Location = new System.Drawing.Point(91, 48);
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.Size = new System.Drawing.Size(100, 20);
            this.txtAccBalance.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtAccBalance, "Account Balace Text Box");
            // 
            // lblCurrentDoctor
            // 
            this.lblCurrentDoctor.AutoSize = true;
            this.lblCurrentDoctor.Location = new System.Drawing.Point(21, 10);
            this.lblCurrentDoctor.Name = "lblCurrentDoctor";
            this.lblCurrentDoctor.Size = new System.Drawing.Size(62, 26);
            this.lblCurrentDoctor.TabIndex = 22;
            this.lblCurrentDoctor.Text = "Current \r\nPharmacist:";
            // 
            // txtCurrentDoctor
            // 
            this.txtCurrentDoctor.Location = new System.Drawing.Point(91, 19);
            this.txtCurrentDoctor.Name = "txtCurrentDoctor";
            this.txtCurrentDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentDoctor.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtCurrentDoctor, "Pharmacist Text Box");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.gboAddressInfo);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.gboContactInfo);
            this.Controls.Add(this.cboSearchForPatientID);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.gboNameGender);
            this.Controls.Add(this.gboMiscellaneousInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 470);
            this.MinimumSize = new System.Drawing.Size(700, 470);
            this.Name = "Patient";
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.gboAddressInfo.ResumeLayout(false);
            this.gboAddressInfo.PerformLayout();
            this.gboContactInfo.ResumeLayout(false);
            this.gboContactInfo.PerformLayout();
            this.gboNameGender.ResumeLayout(false);
            this.gboNameGender.PerformLayout();
            this.gboMiscellaneousInfo.ResumeLayout(false);
            this.gboMiscellaneousInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboSearchForPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.GroupBox gboContactInfo;
        private System.Windows.Forms.TextBox txtWorkEmail;
        private System.Windows.Forms.Label lblWorkEmail;
        private System.Windows.Forms.Label lblPersonalEmail;
        private System.Windows.Forms.TextBox txtPersonalEmail;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.ComboBox cboSearchForPatientID;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.GroupBox gboNameGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMi;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gboMiscellaneousInfo;
        private System.Windows.Forms.Label lblPolicyNumber;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.Label lblCurrentDoctor;
        private System.Windows.Forms.TextBox txtCurrentDoctor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPolicyOne;
        private System.Windows.Forms.TextBox txtPolicyThree;
        private System.Windows.Forms.TextBox txtPolicyTwo;
        private System.Windows.Forms.TextBox txtInsuranceThree;
        private System.Windows.Forms.TextBox txtInsuranceTwo;
        private System.Windows.Forms.TextBox txtInsuranceOne;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}