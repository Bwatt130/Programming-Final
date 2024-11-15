using ProjectName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class Patient : Form
    {
        public static string patientID = "";

        public Patient()
        {
            InitializeComponent();
            cboGender.SelectedIndex = 0;
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            PatientDataTier patientDT = new PatientDataTier();

            patientID = cboSearchForPatientID.Text.ToString().Trim();
            ds = patientDT.GetAllPatientIDs();
            cboSearchForPatientID.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string patientDisplayText = row["Patient_ID"].ToString();
                cboSearchForPatientID.Items.Add(patientDisplayText);
            }

            if (LandingPage.patID == "Add")
            {
                btnAddPatient.Enabled = false;
                btnSearchPatient.Enabled = false;
                btnDeletePatient.Enabled = false;
                btnUpdatePatient.Enabled = false;
            }
            else if (LandingPage.patID == "Search")
            {
                btnSearchPatient.Enabled = true;
                btnAddPatient.Enabled = false;
                btnDeletePatient.Enabled = false;
                btnUpdatePatient.Enabled = false;
                MessageBox.Show("Search a patient's information by selecting one of the existing patient IDs in the patient dropdown!", "Search Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LandingPage.patID == "Delete")
            {
                btnSearchPatient.Enabled = true;
                btnAddPatient.Enabled = false;
                btnDeletePatient.Enabled = true;
                btnUpdatePatient.Enabled = false;
                MessageBox.Show("Delete a patient by selecting one of the existing patient IDs in the patient dropdown!", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {


            try
            {
                DataSet ds = new DataSet();
                PatientDataTier patientDT = new PatientDataTier();
                

                string patientId = "";
                string fname = "";
                string lname = "";
                string middleName = "";
                DateTime dateOfBirth = DateTime.MinValue;
                string sex = "";
                string currentDoctor = "";
                string insuranceCompanyOne = "";
                int policyNumberOne = 0;
                string insuranceCompanyTwo = "";
                int policyNumberTwo = 0;
                string insuranceCompanyThree = "";
                int policyNumberThree = 0;
                string homePhone = "";
                string workPhone = "";
                string workEmail = "";
                string personalEmail = "";
                string street = "";
                string city = "";
                string addressState = "";
                string zip = "";
                decimal accountBalance = 0.0m;

                patientId = cboSearchForPatientID.Text.Trim();
                fname = txtFirstName.Text.Trim();
                lname = txtLastName.Text.Trim();
                middleName = txtMi.Text.Trim();

                if (DateTime.TryParse(dtpDOB.Text.Trim(), out DateTime parsedDOB))
                {
                    dateOfBirth = parsedDOB;
                }
                else
                {
                    dateOfBirth = DateTime.MinValue;
                }

                sex = cboGender.Text.Trim();
                currentDoctor = txtCurrentDoctor.Text.Trim();
                insuranceCompanyOne = txtInsuranceOne.Text.Trim();
                policyNumberOne = string.IsNullOrEmpty(txtPolicyOne.Text) ? 0 : int.Parse(txtPolicyOne.Text.Trim());
                insuranceCompanyTwo = txtInsuranceTwo.Text.Trim();
                policyNumberTwo = string.IsNullOrEmpty(txtPolicyTwo.Text) ? 0 : int.Parse(txtPolicyTwo.Text.Trim());
                insuranceCompanyThree = txtInsuranceThree.Text.Trim();
                policyNumberThree = string.IsNullOrEmpty(txtPolicyThree.Text) ? 0 : int.Parse(txtPolicyThree.Text.Trim());
                homePhone = txtHomePhone.Text.Trim();
                workPhone = txtWorkPhone.Text.Trim();
                workEmail = txtWorkEmail.Text.Trim();
                personalEmail = txtPersonalEmail.Text.Trim();
                street = txtAddress.Text.Trim();
                city = txtCity.Text.Trim();
                addressState = cboState.Text.Trim();
                zip = txtZip.Text.Trim();
                accountBalance = string.IsNullOrEmpty(txtAccBalance.Text) ? 0.0m : decimal.Parse(txtAccBalance.Text.Trim());


                ds = patientDT.GetPatientsByPatID(patientId);

                try{
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btnDeletePatient.Enabled = true;
                        btnUpdatePatient.Enabled = true;
                        btnSearchPatient.Enabled = true;
                        btnAddPatient.Enabled = false;

                        DataRow row = ds.Tables[0].Rows[0];

                        try
                        {
                            if (row["PATIENT_ID"].ToString().Trim().Contains("PAT"))
                            {
                                cboSearchForPatientID.Text = row["PATIENT_ID"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + "", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnSearchPatient.Enabled = true;
                            btnAddPatient.Enabled = false;
                        }

                        cboSearchForPatientID.Text = row["PATIENT_ID"].ToString();
                        txtFirstName.Text = row["fName"].ToString();
                        txtLastName.Text = row["lName"].ToString();
                        txtMi.Text = row["middleName"].ToString();
                        txtCurrentDoctor.Text = row["currentDoctor"].ToString();
                        txtInsuranceOne.Text = row["insuranceCompanyOne"].ToString();
                        txtPolicyOne.Text = row["policyNumberOne"].ToString();
                        txtInsuranceTwo.Text = row["insuranceCompanyTwo"].ToString();
                        txtPolicyTwo.Text = row["policyNumberTwo"].ToString();
                        txtInsuranceOne.Text = row["insuranceCompanyThree"].ToString();
                        txtPolicyThree.Text = row["policyNumberThree"].ToString();
                        txtHomePhone.Text = row["homePhone"].ToString();
                        txtWorkPhone.Text = row["workPhone"].ToString();
                        txtWorkEmail.Text = row["workEmail"].ToString();
                        txtPersonalEmail.Text = row["personalEmail"].ToString();
                        txtAddress.Text = row["street"].ToString();
                        txtCity.Text = row["city"].ToString();

                        cboState.DataSource = StateManager.getStates();
                        cboState.DisplayMember = "Name";
                        //cboState.ValueMember = "appreviation";

                        txtZip.Text = row["zip"].ToString();
                        txtAccBalance.Text = row["account_Balance"].ToString();


                        if (DateTime.TryParse(row["dateOfBirth"].ToString(), out DateTime dob))
                        {
                            dtpDOB.Value = dob;
                        }
                        else
                        {
                            dtpDOB.Value = DateTime.MinValue;
                        }

                        if (row["sex"].ToString().Trim() == "Male")
                        {
                            cboGender.SelectedIndex = cboGender.Items.IndexOf("Male");
                        }
                        else
                        {
                            cboGender.SelectedIndex = cboGender.Items.IndexOf("Female");
                        }
                    }
                    else
                    {
                        ClearFields();
                        /*
                        cboSearchForPatientID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtMi.Text = "";
                        dtpDOB.Value = DateTime.MinValue;
                        cboGender.Text = "";
                        txtCurrentDoctor.Text = "";
                        cboInsuranceOne.Text = "";
                        txtPolicyOne.Text = "";
                        cboInsuranceTwo.Text = "";
                        txtPolicyTwo.Text = "";
                        cboInsuranceThree.Text = "";
                        txtPolicyThree.Text = "";
                        txtHomePhone.Text = "";
                        txtWorkPhone.Text = "";
                        txtWorkEmail.Text = "";
                        txtPersonalEmail.Text = "";
                        txtAddress.Text = "";
                        txtCity.Text = "";
                        cboState.Text = "";
                        txtZip.Text = "";
                        txtAccBalance.Text = "";
                        */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSearchPatient.Enabled = true;
                    btnAddPatient.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Two: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = cboSearchForPatientID.Text.Trim();
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string middleName = txtMi.Text.Trim();
                DateTime dateOfBirth = dtpDOB.Value;
                string gender = cboGender.Text.Trim();
                string currentDoctor = txtCurrentDoctor.Text.Trim();
                string insuranceCompanyOne = txtInsuranceOne.Text.Trim();
                string policyNumberOne = txtPolicyOne.Text.Trim();
                string insuranceCompanyTwo = txtInsuranceTwo.Text.Trim();
                string policyNumberTwo = txtPolicyTwo.Text.Trim();
                string insuranceCompanyThree = txtInsuranceThree.Text.Trim();
                string policyNumberThree = txtPolicyThree.Text.Trim();
                string homePhone = txtHomePhone.Text.Trim();
                string workPhone = txtWorkPhone.Text.Trim();
                string workEmail = txtWorkEmail.Text.Trim();
                string personalEmail = txtPersonalEmail.Text.Trim();
                string address = txtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string state = cboState.Text.Trim();
                string zip = txtZip.Text.Trim();
                decimal accountBalance = string.IsNullOrEmpty(txtAccBalance.Text) ? 0.0m : decimal.Parse(txtAccBalance.Text.Trim());

                int policyNumberOneInt = string.IsNullOrEmpty(policyNumberOne) ? 0 : int.Parse(policyNumberOne);
                int policyNumberTwoInt = string.IsNullOrEmpty(policyNumberTwo) ? 0 : int.Parse(policyNumberTwo);
                int policyNumberThreeInt = string.IsNullOrEmpty(policyNumberThree) ? 0 : int.Parse(policyNumberThree);

                PatientDataTier patientDT = new PatientDataTier();
                patientDT.NewPatient(patientID, firstName, lastName, middleName, dateOfBirth, gender, currentDoctor,
                   insuranceCompanyOne, policyNumberOneInt, insuranceCompanyTwo, policyNumberTwoInt,
                   insuranceCompanyThree, policyNumberThreeInt, homePhone, workPhone, workEmail, personalEmail,
                   address, city, state, zip, accountBalance);

                ClearFields();
                MessageBox.Show("The patient has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                if (cboSearchForPatientID.Text.Contains("PAT") == false)
                {
                    errorProvider1.SetError(cboSearchForPatientID, "Must begin with \"PAT\"");
                }
                //MessageBox.Show("Error: " + ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtFirstName.Text.Trim().Length == 0 )
                {
                    errorProvider1.SetError(txtFirstName, "Enter a First Name");
                }
               

                if (txtLastName.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtLastName, "Enter a Last Name");
                }
                
            }
        }

        private void ClearFields()
        {
            cboSearchForPatientID.Items.Remove(cboSearchForPatientID.SelectedItem);
            cboSearchForPatientID.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMi.Clear();
            dtpDOB.Value = DateTime.Now;
            txtCurrentDoctor.Clear();
            txtInsuranceOne.Text = "";
            txtPolicyOne.Clear();
            txtInsuranceTwo.Text = "";
            txtPolicyTwo.Clear();
            txtInsuranceThree.Text = "";
            txtPolicyThree.Clear();
            txtHomePhone.Clear();
            txtWorkPhone.Clear();
            txtWorkEmail.Clear();
            txtPersonalEmail.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cboState.SelectedIndex = -1;
            txtZip.Clear();
            txtAccBalance.Clear();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = cboSearchForPatientID.Text.Trim();

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Call DeletePatient method from the DataTier to delete the patient
                    PatientDataTier patientDT = new PatientDataTier();
                    patientDT.DeletePatient(patientID);
                    ClearFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                string patientId = cboSearchForPatientID.Text.Trim();
                string fname = txtFirstName.Text.Trim();
                string lname = txtLastName.Text.Trim();
                string middleName = txtMi.Text.Trim();
                DateTime dateOfBirth = dtpDOB.Value;
                string sex = cboGender.Text.Trim();
                string currentDoctor = txtCurrentDoctor.Text.Trim();
                string insuranceCompanyOne = txtInsuranceOne.Text.Trim();
                int policyNumberOne = string.IsNullOrEmpty(txtPolicyOne.Text) ? 0 : int.Parse(txtPolicyOne.Text.Trim());
                string insuranceCompanyTwo = txtInsuranceTwo.Text.Trim();
                int policyNumberTwo = string.IsNullOrEmpty(txtPolicyTwo.Text) ? 0 : int.Parse(txtPolicyTwo.Text.Trim());
                string insuranceCompanyThree = txtInsuranceThree.Text.Trim();
                int policyNumberThree = string.IsNullOrEmpty(txtPolicyThree.Text) ? 0 : int.Parse(txtPolicyThree.Text.Trim());
                string homePhone = txtHomePhone.Text.Trim();
                string workPhone = txtWorkPhone.Text.Trim();
                string workEmail = txtWorkEmail.Text.Trim();
                string personalEmail = txtPersonalEmail.Text.Trim();
                string street = txtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string addressState = cboState.Text.Trim();
                string zip = txtZip.Text.Trim();
                decimal accountBalance = string.IsNullOrEmpty(txtAccBalance.Text) ? 0.0m : decimal.Parse(txtAccBalance.Text.Trim());

                PatientDataTier patientDT = new PatientDataTier();
                patientDT.ModifyPatient(
                    patientId, fname, lname, middleName, dateOfBirth, sex, currentDoctor,
                    insuranceCompanyOne, policyNumberOne, insuranceCompanyTwo, policyNumberTwo,
                    insuranceCompanyThree, policyNumberThree, homePhone, workPhone, workEmail,
                    personalEmail, street, city, addressState, zip, accountBalance
                );

                MessageBox.Show("Patient record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSearchForPatientID_TextUpdate(object sender, EventArgs e)
        {
            if (LandingPage.addPAT == true)
            {

                if ((cboSearchForPatientID.Text.ToString().Trim().Contains("PAT"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPatient.Enabled = true;
                }
                else
                {
                    btnAddPatient.Enabled = false;
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if(LandingPage.addPAT == true)
            {

                if ((cboSearchForPatientID.Text.ToString().Trim().Contains("PAT")) 
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2) 
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPatient.Enabled = true;
                }
                else
                {
                    btnAddPatient.Enabled = false;
                }
            }
        }

        private void txtMi_TextChanged(object sender, EventArgs e)
        {
            if (LandingPage.addPAT == true)
            {

                if ((cboSearchForPatientID.Text.ToString().Trim().Contains("PAT"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPatient.Enabled = true;
                }
                else
                {
                    btnAddPatient.Enabled = false;
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (LandingPage.addPAT == true)
            {

                if ((cboSearchForPatientID.Text.ToString().Trim().Contains("PAT"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPatient.Enabled = true;
                }
                else
                {
                    btnAddPatient.Enabled = false;
                }
            }
        }

        private void cboGender_TextUpdate(object sender, EventArgs e)
        {
            if (LandingPage.addPAT == true)
            {

                if ((cboSearchForPatientID.Text.ToString().Trim().Contains("PAT"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPatient.Enabled = true;
                }
                else
                {
                    btnAddPatient.Enabled = false;
                }
            }
        }
    }
}

