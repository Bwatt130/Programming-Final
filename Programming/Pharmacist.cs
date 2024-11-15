using Programming;
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
    public partial class Pharmacist : Form
    {
        public static string pharmacistID = "";
        public static bool addPharmacist = false;

        public Pharmacist()
        {
            InitializeComponent();
            cboGender.SelectedIndex = 0;
            cboState.DataSource = StateManager.getStates();
            cboState.DisplayMember = "Name";
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            PharmacistDataTier pharmacistDT = new PharmacistDataTier();
            DataSet ds = new DataSet();

            pharmacistID = cboSearchForPharmacistID.Text.ToString().Trim();
            ds = pharmacistDT.GetAllPharmacistIDs();
            cboSearchForPharmacistID.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string pharmacistDisplayText = row["Pharmacist_ID"].ToString();
                cboSearchForPharmacistID.Items.Add(pharmacistDisplayText);
            }

            if (LandingPage.pharmID == "Add")
            {
                btnAddPharmacist.Enabled = false;
                btnSearchPharmacist.Enabled = false;
                btnDeletePharmacist.Enabled = false;
                btnUpdatePharmacist.Enabled = false;
                addPharmacist = true;

            }
            else if (LandingPage.pharmID == "Search")
            {
                btnSearchPharmacist.Enabled = true;
                btnAddPharmacist.Enabled = false;
                btnDeletePharmacist.Enabled = false;
                btnUpdatePharmacist.Enabled = false;
                addPharmacist = false;
            }
        }

        private void btnSearchPharmacist_Click(object sender, EventArgs e)
        {
            try
            {
                string pharmacistId = cboSearchForPharmacistID.Text.Trim();
                PharmacistDataTier pharmacistDT = new PharmacistDataTier();


                pharmacistID = cboSearchForPharmacistID.Text.ToString().Trim();
                DataSet ds = pharmacistDT.GetPharmacistsByPharmacistID(pharmacistId);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    btnDeletePharmacist.Enabled = true;
                    btnUpdatePharmacist.Enabled = true;

                    DataRow row = ds.Tables[0].Rows[0];
                    cboSearchForPharmacistID.Text = row["Pharmacist_ID"].ToString();
                    txtFirstName.Text = row["fName"].ToString();
                    txtLastName.Text = row["lName"].ToString();
                    txtMi.Text = row["middleName"].ToString();
                    txtHomePhone.Text = row["homePhone"].ToString();
                    txtHomeEmail.Text = row["personalEmail"].ToString();
                    txtWorkPhone.Text = row["workPhone"].ToString();
                    txtWorkEmail.Text = row["workEmail"].ToString();
                    txtAddress.Text = row["street"].ToString();
                    txtZip.Text = row["zip"].ToString();
                    txtCity.Text = row["city"].ToString();
                    cboState.Text = row["address_state"].ToString();
                    txtYearlySalary.Text = row["yearlySalary"].ToString();

                    if (DateTime.TryParse(row["dateOfBirth"].ToString(), out DateTime dob))
                    {
                        dtpDOB.Value = dob;
                    }

                    if (DateTime.TryParse(row["hireDate"].ToString(), out DateTime hireDate))
                    {
                        dtpHireDate.Value = hireDate;
                    }

                    cboGender.SelectedItem = row["sex"].ToString();
                }
                else
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPharmacist_Click(object sender, EventArgs e)
        {
            try
            {
                PharmacistDataTier pharmacistDT = new PharmacistDataTier();
                pharmacistDT.AddPharmacist(
                    cboSearchForPharmacistID.Text.Trim(),
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtMi.Text.Trim(),
                    cboGender.Text.Trim(),
                    decimal.Parse(txtYearlySalary.Text.Trim()),
                    dtpDOB.Value,
                    dtpHireDate.Value,
                    txtHomePhone.Text.Trim(),
                    txtHomeEmail.Text.Trim(),
                    txtWorkPhone.Text.Trim(),
                    txtWorkEmail.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtCity.Text.Trim(),
                    cboState.Text.Trim(),
                    txtZip.Text.Trim()
                );

                ClearFields();
                MessageBox.Show("Pharmacist added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePharmacist_Click(object sender, EventArgs e)
        {
            try
            {
                PharmacistDataTier pharmacistDT = new PharmacistDataTier();
                pharmacistDT.UpdatePharmacist(
                    cboSearchForPharmacistID.Text.Trim(),
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtMi.Text.Trim(),
                    cboGender.Text.Trim(),
                    decimal.Parse(txtYearlySalary.Text.Trim()),
                    dtpDOB.Value,
                    dtpHireDate.Value,
                    txtHomePhone.Text.Trim(),
                    txtHomeEmail.Text.Trim(),
                    txtWorkPhone.Text.Trim(),
                    txtWorkEmail.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtCity.Text.Trim(),
                    cboState.Text.Trim(),
                    txtZip.Text.Trim()
                );

                MessageBox.Show("Pharmacist updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePharmacist_Click(object sender, EventArgs e)
        {
            try
            {
                string pharmacistId = cboSearchForPharmacistID.Text.Trim();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this pharmacist?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PharmacistDataTier pharmacistDT = new PharmacistDataTier();
                    pharmacistDT.DeletePharmacist(pharmacistId);
                    ClearFields();
                    MessageBox.Show("Pharmacist deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            cboSearchForPharmacistID.Items.Remove(cboSearchForPharmacistID.SelectedItem);
            cboSearchForPharmacistID.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMi.Clear();
            dtpDOB.Value = DateTime.Now;
            dtpHireDate.Value = DateTime.Now;
            txtHomePhone.Clear();
            txtHomeEmail.Clear();
            txtWorkPhone.Clear();
            txtWorkEmail.Clear();
            txtAddress.Clear();
            txtZip.Clear();
            txtCity.Clear();
            cboState.SelectedIndex = -1;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (addPharmacist == true)
            {

                if ((cboSearchForPharmacistID.Text.ToString().Trim().Contains("PHA"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPharmacist.Enabled = true;
                }
                else
                {
                    btnAddPharmacist.Enabled = false;
                }
            }
        }

        private void txtMi_TextChanged(object sender, EventArgs e)
        {
            if (addPharmacist == true)
            {

                if ((cboSearchForPharmacistID.Text.ToString().Trim().Contains("PHA"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPharmacist.Enabled = true;
                }
                else
                {
                    btnAddPharmacist.Enabled = false;
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (addPharmacist == true)
            {

                if ((cboSearchForPharmacistID.Text.ToString().Trim().Contains("PHA"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPharmacist.Enabled = true;
                }
                else
                {
                    btnAddPharmacist.Enabled = false;
                }
            }
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addPharmacist == true)
            {

                if ((cboSearchForPharmacistID.Text.ToString().Trim().Contains("PHA"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPharmacist.Enabled = true;
                }
                else
                {
                    btnAddPharmacist.Enabled = false;
                }
            }
        }

        private void cboSearchForPharmacistID_TextUpdate(object sender, EventArgs e)
        {
            if (addPharmacist == true)
            {

                if ((cboSearchForPharmacistID.Text.ToString().Trim().Contains("PHA"))
                    && (txtFirstName.Text.ToString().Trim().Length > 0)
                    && (txtLastName.Text.ToString().Trim().Length > 0)
                    && (txtMi.Text.ToString().Trim().Length < 2)
                    && ((cboGender.SelectedItem.ToString().Trim() == "Male") || (cboGender.SelectedItem.ToString().Trim() == "Female")))
                {
                    btnAddPharmacist.Enabled = true;
                }
                else
                {
                    btnAddPharmacist.Enabled = false;
                }
            }
        }
    }
}
