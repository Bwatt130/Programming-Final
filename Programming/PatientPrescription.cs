using System;
using System.Data;
using System.Windows.Forms;
using ProjectName;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;


namespace Programming
{
    public partial class frmPatientPrescription : Form
    {
        /*
        public static string patientID = "";
        public static int prescriptionID = 0;
        public static string pharmacistID = "";
        public static bool addingPreExistingPrescriptionToPatient = false;
        public static bool decrementFillCount = false;
        */

        private PrescriptionDataTier dataTier = new PrescriptionDataTier();

        public frmPatientPrescription()
        {
            InitializeComponent();
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = "";
                int fillCount = 0;
                string description = "";
                string pharmacistID = "";
                try
                {
                    patientID = cboPatientID.Text.ToString().Trim();
                    fillCount = Convert.ToInt32(txtFillCount.Text);
                    description = txtDescription.Text.ToString().Trim();
                    pharmacistID = cboPharmacistID.Text.ToString().Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Please Enter the Correct values" + ex.Message);
                }

                dataTier.InsertPrescription(patientID, fillCount, description, pharmacistID);
                MessageBox.Show("Prescription added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrescriptions.SelectedRows.Count > 0)
                {
                    int prescriptionID = Convert.ToInt32(dgvPrescriptions.SelectedRows[0].Cells["Prescription_ID"].Value);
                    int fillCount = Convert.ToInt32(txtFillCount.Text);
                    string description = txtDescription.Text;
                    string pharmacistID = cboPharmacistID.Text.ToString().Trim();
                    string patientID = cboPatientID.Text.ToString().Trim();

                    dataTier.UpdatePrescription(prescriptionID, fillCount, description);
                    MessageBox.Show("Prescription updated successfully.");
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            PrescriptionDataTier pds = new PrescriptionDataTier();
            DataSet prescriptions = new DataSet();

            try
            {
                string patientID = cboPatientID.SelectedValue != null ? cboPatientID.Text.ToString().Trim() : null;
                string prescriptionID = cboPrescriptionID.SelectedValue != null ? cboPrescriptionID.Text.ToString().Trim() : null;

                if (cboPatientID.SelectedItem != null)
                {
                    patientID = cboPatientID.Text.ToString().Trim();
                }
                else
                {
                    patientID = null;
                }

                if (cboPrescriptionID.Text != "")
                {
                    prescriptionID = cboPrescriptionID.Text.ToString().Trim();
                }
                else
                {
                    prescriptionID = null;
                }

                // Refresh based on existing data if grid is already populated


                if (dgvPrescriptions.DataSource != null)
                {
                    prescriptions = pds.SearchPrescriptions(/*patientID,*/ prescriptionID);
                }
                else
                {
                    // If both combo boxes are null, fetch all prescriptions
                    prescriptions = pds.GetAllPrescriptions();
                }

                // Check if any rows were returned and refresh the grid
                if (prescriptions.Tables[0].Rows.Count > 0)
                {
                    dgvPrescriptions.Visible = true;
                    dgvPrescriptions.DataSource = prescriptions.Tables[0];
                    dgvPrescriptions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                    dgvPrescriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPrescriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("No prescriptions found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data grid: " + ex.Message);
            }
        }

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            DataSet dsPatients = new DataSet();
            DataSet dsPharmacists = new DataSet();
            DataSet dsPrescriptions = new DataSet();

            PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();


            dsPatients = prescriptionDT.GetAllPatientIDs();
            cboPatientID.Items.Clear();
            foreach (DataRow row in dsPatients.Tables[0].Rows)
            {
                string patientDisplayText = row["Patient_ID"].ToString();
                cboPatientID.Items.Add(patientDisplayText);
            }

            dsPharmacists = prescriptionDT.GetAllPharmacistIDs();
            cboPharmacistID.Items.Clear();
            foreach (DataRow row in dsPharmacists.Tables[0].Rows)
            {
                string pharmacistDisplayText = row["Pharmacist_ID"].ToString();
                cboPharmacistID.Items.Add(pharmacistDisplayText);
            }

            dsPrescriptions = prescriptionDT.GetAllPrescriptionIDs();
            cboPrescriptionID.Items.Clear();
            foreach (DataRow row in dsPrescriptions.Tables[0].Rows)
            {
                string prescriptionDisplayText = row["Prescription_ID"].ToString();
                cboPrescriptionID.Items.Add(prescriptionDisplayText);
            }

       
            DataSet prescriptions = prescriptionDT.GetAllPrescriptions();

            if (prescriptions.Tables[0].Rows.Count > 0)
            {
                dgvPrescriptions.Visible = true;
                dgvPrescriptions.DataSource = prescriptions.Tables[0];
                dgvPrescriptions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                dgvPrescriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPrescriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            try
            {
                PrescriptionDataTier psd = new PrescriptionDataTier();
                DataSet filteredPrescriptions = new DataSet();

                string patientID = null;
                string prescriptionID = null;

                if (string.IsNullOrEmpty(cboPrescriptionID.Text))
                {


                    filteredPrescriptions = psd.GetAllPrescriptions();


                    if (filteredPrescriptions.Tables[0].Rows.Count > 0)
                    {
                        dgvPrescriptions.Visible = true;
                        dgvPrescriptions.DataSource = filteredPrescriptions.Tables[0];
                        dgvPrescriptions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                        dgvPrescriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvPrescriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                    }
                }
                else
                {
                    if (cboPatientID.SelectedItem != null)
                    {
                        patientID = cboPatientID.Text.ToString().Trim();
                    }
                    else
                    {
                        patientID = null;
                    }

                    if (cboPrescriptionID.Text != null)
                    {
                        prescriptionID = cboPrescriptionID.Text.ToString().Trim();
                    }
                    else
                    {
                        prescriptionID = null;
                    }

                    filteredPrescriptions = psd.SearchPrescriptions(/*patientID, */prescriptionID);


                    if (filteredPrescriptions.Tables[0].Rows.Count > 0)
                    {
                        dgvPrescriptions.Visible = true;
                        dgvPrescriptions.DataSource = filteredPrescriptions.Tables[0];
                        dgvPrescriptions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                        dgvPrescriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvPrescriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateFields(DataRow row)
        {
            txtDescription.Text = row["prescriptionDesc"].ToString().Trim();
            txtFillCount.Text = row["fillCount"].ToString().Trim();
            cboPatientID.Text = row["PATIENT_ID"].ToString().Trim();
            cboPharmacistID.Text = row["PHARMACIST_ID"].ToString().Trim();
            cboPrescriptionID.Text = row["PRESCRIPTION_ID"].ToString().Trim();
        }

        private void btnDeletePrescription_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrescriptions.SelectedRows.Count > 0)
                {
                    string prescriptionID;

                    if (cboPrescriptionID.Text != "")
                    {
                        prescriptionID = cboPrescriptionID.Text.ToString().Trim();
                    }
                    else
                    {
                        prescriptionID = null;
                    }


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this prescription?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataTier.DeletePrescription(prescriptionID);
                        MessageBox.Show("Prescription deleted successfully.");
                        cboPrescriptionID.Items.Remove(cboPrescriptionID.SelectedItem);
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvPrescriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dgvPrescriptions.SelectedRows[0].DataBoundItem).Row;
                PopulateFields(row);
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

/*
        public frmPatientPrescription()
        {
            InitializeComponent();
        }

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            SetFormMode(LandingPage.patID);
            btnSearchPrescription_Click(sender, e);
        }

        private void SetFormMode(string mode)
        {
            bool isSearchMode = mode == "PrescriptionSearch";
            bool isAddMode = mode == "PrescriptionAdd";
            bool isAddToPatientMode = mode == "AddPrescriptionToPatient" || decrementFillCount;

            btnAddPrescriptionToPatient.Enabled = isAddToPatientMode;
            btnNewPrescription.Enabled = isAddMode;
            btnSearchPrescription.Enabled = isSearchMode;
            btnUpdatePrescription.Enabled = isSearchMode;
            btnDeletePrescription.Enabled = isSearchMode;

            txtDescription.Enabled = isSearchMode || isAddMode;
            txtFillCount.Enabled = isSearchMode || isAddMode;
            cboPatientID.Enabled = isSearchMode || isAddToPatientMode;
            cboPharmacistID.Enabled = isSearchMode || isAddToPatientMode;
            cboPrescriptionID.Enabled = isSearchMode || isAddToPatientMode;
            dgvPrescriptions.Visible = isSearchMode || isAddToPatientMode;

            addingPreExistingPrescriptionToPatient = isAddToPatientMode;
        }

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboPrescriptionID.Text.Trim(), out int prescriptionID))
            {
                MessageBox.Show("Please enter a valid prescription ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadPrescriptionDetails(prescriptionID);
        }

        private void LoadPrescriptionDetails(int prescriptionID)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                DataSet dsPrescription = prescriptionDT.GetPrescriptionByID(prescriptionID);

                if (dsPrescription.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsPrescription.Tables[0].Rows[0];
                    PopulateFields(row);
                    dgvPrescriptions.DataSource = dsPrescription.Tables[0];
                    dgvPrescriptions.Visible = true;
                }
                else
                {
                    MessageBox.Show("No prescription found with the selected ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields(DataRow row)
        {
            txtDescription.Text = row["Description"].ToString().Trim();
            txtFillCount.Text = row["FillCount"].ToString().Trim();
            cboPatientID.Text = row["Patient_ID"].ToString().Trim();
            cboPharmacistID.Text = row["Pharmacist_ID"].ToString().Trim();
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            string patientID = cboPatientID.Text.Trim();
            string pharmacistID = cboPharmacistID.Text.Trim();

            if (string.IsNullOrEmpty(patientID) || string.IsNullOrEmpty(pharmacistID))
            {
                MessageBox.Show("Please select both a patient and a pharmacist.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(cboPrescriptionID.Text, out int prescriptionID))
            {
                UpdatePrescription(prescriptionID, patientID, pharmacistID);
            }
            else
            {
                MessageBox.Show("Please select a valid prescription ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdatePrescription(int prescriptionID, string patientID, string pharmacistID)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                if (prescriptionDT.AddOrUpdatePrescription(prescriptionID, patientID, pharmacistID))
                {
                    MessageBox.Show("Prescription successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update the prescription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Modify Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrescriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dgvPrescriptions.SelectedRows[0].DataBoundItem).Row;
                PopulateFields(row);
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboPrescriptionID.Text))
            {
                MessageBox.Show("Please enter a valid Prescription ID.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int fillCount = int.TryParse(txtFillCount.Text.Trim(), out int fc) ? fc : 0;
            UpdatePrescriptionDetails(cboPrescriptionID.Text, fillCount, txtDescription.Text.Trim(), cboPatientID.Text.Trim(), cboPharmacistID.Text.Trim());
        }

        private void UpdatePrescriptionDetails(string prescriptionId, int fillCount, string description, string patientId, string pharmacistId)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                prescriptionDT.ModifyPrescription(prescriptionId, fillCount, description, patientId, pharmacistId);
                MessageBox.Show("Prescription updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSearchPrescription_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating prescription: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFillCount.Text, out int fillCount) || fillCount <= 0)
            {
                MessageBox.Show("Please enter a valid fill count greater than zero.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Please enter a prescription description.");
                return;
            }

            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                prescriptionDT.NewPrescription(fillCount, txtDescription.Text.Trim());
                MessageBox.Show("Prescription added successfully.");
                dgvPrescriptions.Visible = true;
                btnSearchPrescription_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding prescription: " + ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/*
 * using System;
using System.Data;
using System.Windows.Forms;

namespace Programming
{
    public partial class frmPatientPrescription : Form
    {
        public static string patientID = "";
        public static int prescriptionID = 0;
        public static string pharmacistID = "";
        public static bool addingPreExistingPrescriptionToPatient = false;
        public static bool decrementFillCount = false;

        public frmPatientPrescription()
        {
            InitializeComponent();
        }

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            SetFormMode(LandingPage.patID);
            btnSearchPrescription_Click(sender, e);
        }

        private void SetFormMode(string mode)
        {
            bool isSearchMode = mode == "PrescriptionSearch";
            bool isAddMode = mode == "PrescriptionAdd";
            bool isAddToPatientMode = mode == "AddPrescriptionToPatient" || decrementFillCount;

            btnAddPrescriptionToPatient.Enabled = isAddToPatientMode;
            btnNewPrescription.Enabled = isAddMode;
            btnSearchPrescription.Enabled = isSearchMode;
            btnUpdatePrescription.Enabled = isSearchMode;
            btnDeletePrescription.Enabled = isSearchMode;

            txtDescription.Enabled = isSearchMode || isAddMode;
            txtFillCount.Enabled = isSearchMode || isAddMode;
            cboPatientID.Enabled = isSearchMode || isAddToPatientMode;
            cboPharmacistID.Enabled = isSearchMode || isAddToPatientMode;
            cboPrescriptionID.Enabled = isSearchMode || isAddToPatientMode;
            dgvPrescriptions.Visible = isSearchMode || isAddToPatientMode;

            addingPreExistingPrescriptionToPatient = isAddToPatientMode;
        }

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboPrescriptionID.Text.Trim(), out int prescriptionID))
            {
                MessageBox.Show("Please enter a valid prescription ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadPrescriptionDetails(prescriptionID);
        }

        private void LoadPrescriptionDetails(int prescriptionID)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                DataSet dsPrescription = prescriptionDT.GetPrescriptionByID(prescriptionID);

                if (dsPrescription.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsPrescription.Tables[0].Rows[0];
                    PopulateFields(row);
                    dgvPrescriptions.DataSource = dsPrescription.Tables[0];
                    dgvPrescriptions.Visible = true;
                }
                else
                {
                    MessageBox.Show("No prescription found with the selected ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields(DataRow row)
        {
            txtDescription.Text = row["Description"].ToString().Trim();
            txtFillCount.Text = row["FillCount"].ToString().Trim();
            cboPatientID.Text = row["Patient_ID"].ToString().Trim();
            cboPharmacistID.Text = row["Pharmacist_ID"].ToString().Trim();
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            string patientID = cboPatientID.Text.Trim();
            string pharmacistID = cboPharmacistID.Text.Trim();

            if (string.IsNullOrEmpty(patientID) || string.IsNullOrEmpty(pharmacistID))
            {
                MessageBox.Show("Please select both a patient and a pharmacist.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(cboPrescriptionID.Text, out int prescriptionID))
            {
                UpdatePrescription(prescriptionID, patientID, pharmacistID);
            }
            else
            {
                MessageBox.Show("Please select a valid prescription ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdatePrescription(int prescriptionID, string patientID, string pharmacistID)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                if (prescriptionDT.AddOrUpdatePrescription(prescriptionID, patientID, pharmacistID))
                {
                    MessageBox.Show("Prescription successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update the prescription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Modify Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrescriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dgvPrescriptions.SelectedRows[0].DataBoundItem).Row;
                PopulateFields(row);
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboPrescriptionID.Text))
            {
                MessageBox.Show("Please enter a valid Prescription ID.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int fillCount = int.TryParse(txtFillCount.Text.Trim(), out int fc) ? fc : 0;
            UpdatePrescriptionDetails(cboPrescriptionID.Text, fillCount, txtDescription.Text.Trim(), cboPatientID.Text.Trim(), cboPharmacistID.Text.Trim());
        }

        private void UpdatePrescriptionDetails(string prescriptionId, int fillCount, string description, string patientId, string pharmacistId)
        {
            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                prescriptionDT.ModifyPrescription(prescriptionId, fillCount, description, patientId, pharmacistId);
                MessageBox.Show("Prescription updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSearchPrescription_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating prescription: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFillCount.Text, out int fillCount) || fillCount <= 0)
            {
                MessageBox.Show("Please enter a valid fill count greater than zero.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Please enter a prescription description.");
                return;
            }

            try
            {
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
                prescriptionDT.NewPrescription(fillCount, txtDescription.Text.Trim());
                MessageBox.Show("Prescription added successfully.");
                dgvPrescriptions.Visible = true;
                btnSearchPrescription_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding prescription: " + ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

 */

/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Programming
{
    //Get rid of the whole damn function
    public partial class Prescription : Form
    {
        public static string patientID = "";
        public static string prescriptionID = "";
        public static string pharmacistID = "";

        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            btnSearchPrescription_Click(sender, e);

            DataSet ds = new DataSet();
            PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();

            patientID = cboSearchForPrescriptionID.Text.ToString().Trim();
            ds = prescriptionDT.GetAllPrescriptions();
            cboSearchForPrescriptionID.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string patientDisplayText = row["Prescription_ID"].ToString();
                cboSearchForPrescriptionID.Items.Add(patientDisplayText);
            }

        }

        private void cboSearchForPrescriptionID_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            PrescriptionDataTier patientDT = new PrescriptionDataTier();

            patientID = cboSearchForPrescriptionID.Text.ToString().Trim();
            ds = patientDT.GetAllPrescriptions();
            cboSearchForPrescriptionID.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string patientDisplayText = row["Prescription_ID"].ToString();
                cboSearchForPrescriptionID.Items.Add(patientDisplayText);
            }

        }

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            string prescriptionID = "";

            try
            {
                DataSet ds = new DataSet();
                PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();

                prescriptionID = cboSearchForPrescriptionID.Text.ToString().Trim();

                if (prescriptionID == "")
                {
                    ds = prescriptionDT.GetAllPrescriptions();
                }
                else
                {
                    ds = prescriptionDT.GetPrescriptionByID(int.Parse(prescriptionID));
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvPrescriptionList.Visible = true;
                    dgvPrescriptionList.DataSource = ds.Tables[0];
                    dgvPrescriptionList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                    dgvPrescriptionList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPrescriptionList.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
            string patientID = cboSearchForPrescriptionID.Text.Trim();
            string description = txtDescription.Text.Trim();
            string prescriptionDesc = txtDescription.Text.Trim();
            int fillCount;

            if (int.TryParse(txtFillCount.Text.Trim(), out fillCount) && !string.IsNullOrEmpty(patientID) && !string.IsNullOrEmpty(pharmacistID) && !string.IsNullOrEmpty(prescriptionDesc))
            {
                try
                {
                    // Call method to add a new prescription with the specified details
                    prescriptionDT.NewPrescription(fillCount, prescriptionDesc);
                    MessageBox.Show("New prescription successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();  // Optionally close the form after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid details for the prescription.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            string prescriptionID = "";

            DataSet ds = new DataSet();
            PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();

            prescriptionID = cboSearchForPrescriptionID.Text.ToString().Trim();

            ds = prescriptionDT.GetPrescriptionByID(int.Parse(prescriptionID));
            //prescriptionDT.ModifyPrescription(int.Parse(cboSearchForPrescriptionID.Text.ToString().Trim()), int.Parse(txtFillCount.Text.ToString().Trim()), txtDescription.Text.ToString().Trim());
            btnSearchPrescription_Click(sender, e);
        }


        private void dgvPrescriptionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


*/