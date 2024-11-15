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
    public partial class Refills : Form
    {
        public Refills()
        {
            InitializeComponent();
        }

        private void Refills_Load(object sender, EventArgs e)
        {
            DataSet dsPrescriptions = new DataSet();
            DataSet dsRefills = new DataSet();

            PrescriptionDataTier prescriptionDT = new PrescriptionDataTier();
            RefillDataTier refillDT = new RefillDataTier();

            dsPrescriptions = refillDT.GetAllPrescriptionIDs();
            cboPrescriptionID.Items.Clear();
            foreach (DataRow row in dsPrescriptions.Tables[0].Rows)
            {
                string prescriptionDisplayText = row["Prescription_ID"].ToString();
                cboPrescriptionID.Items.Add(prescriptionDisplayText);
            }

            dsRefills = refillDT.GetAllRefillIDs();  
            cboRefillID.Items.Clear();
            foreach (DataRow row in dsRefills.Tables[0].Rows)
            {
                string refillDisplayText = row["Refill_ID"].ToString();
                cboRefillID.Items.Add(refillDisplayText);
            }

            DataSet refills = refillDT.GetAllRefills();  

            if (refills.Tables[0].Rows.Count > 0)
            {
                dgvRefills.Visible = true;
                dgvRefills.DataSource = refills.Tables[0];
                dgvRefills.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                dgvRefills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvRefills.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            }
        }

        private RefillDataTier dataTier = new RefillDataTier();

        private void btnAddRefill_Click(object sender, EventArgs e)
        {
            try
            {
                int refillCount = 0;
                int refillsRemaining = 0;
                string prescriptionID = "";
                try
                {
                    refillCount = int.Parse(txtFillCount.Text);
                    refillsRemaining = refillCount;
                    prescriptionID = cboPrescriptionID.Text.ToString().Trim();

                    dataTier.AddRefill(refillCount, refillsRemaining, prescriptionID);
                    MessageBox.Show("Refill added successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            RefillDataTier pds = new RefillDataTier();
            DataSet refills = new DataSet();

            try
            {
                string refillID = null;
                string prescriptionID = null;
                if (cboRefillID.SelectedItem != null)
                {
                    refillID = cboRefillID.Text.ToString().Trim();
                }
                else
                {
                    refillID = null;
                }

                if (cboPrescriptionID.Text != "")
                {
                    prescriptionID = cboPrescriptionID.Text.ToString().Trim();
                }
                else
                {
                    prescriptionID = null;
                }


                if (dgvRefills.DataSource != null)
                {
                    refills = pds.SearchRefills(prescriptionID, refillID);
                }
                else
                {
                    refills = pds.GetAllRefills();
                }

                if (refills.Tables[0].Rows.Count > 0)
                {
                    dgvRefills.Visible = true;
                    dgvRefills.DataSource = refills.Tables[0];
                    dgvRefills.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                    dgvRefills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvRefills.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("No refills found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data grid: " + ex.Message);
            }
        }

        private void PopulateFields(DataRow row)
        {
            //txtRefillsRemaining.Text = row["refill_remaining"].ToString().Trim();
            txtFillCount.Text = row["fillCount"].ToString().Trim();
            cboRefillID.Text = row["refill_ID"].ToString().Trim();
            cboPrescriptionID.Text = row["PRESCRIPTION_ID"].ToString().Trim();
        }

        private void btnSearchRefill_Click(object sender, EventArgs e)
        {
            try
            {
                RefillDataTier psd = new RefillDataTier();
                DataSet filteredRefills = new DataSet();

                string refillID = null;
                string prescriptionID = null;

                if (string.IsNullOrEmpty(cboPrescriptionID.Text))
                {


                    filteredRefills = psd.GetAllRefills();


                    if (filteredRefills.Tables[0].Rows.Count > 0)
                    {
                        dgvRefills.Visible = true;
                        dgvRefills.DataSource = filteredRefills.Tables[0];
                        dgvRefills.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                        dgvRefills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvRefills.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                    }
                }
                else
                {
                    if (cboRefillID.SelectedItem != null)
                    {
                        refillID = cboRefillID.Text.ToString().Trim();
                    }
                    else
                    {
                        refillID = null;
                    }

                    if (cboPrescriptionID.Text != null)
                    {
                        prescriptionID = cboPrescriptionID.Text.ToString().Trim();
                    }
                    else
                    {
                        prescriptionID = null;
                    }

                    filteredRefills = psd.SearchRefills(prescriptionID, refillID);


                    if (filteredRefills.Tables[0].Rows.Count > 0)
                    {
                        dgvRefills.Visible = true;
                        dgvRefills.DataSource = filteredRefills.Tables[0];
                        dgvRefills.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                        dgvRefills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvRefills.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteRefill_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRefills.SelectedRows.Count > 0)
                {
                    string refillID;

                    if (cboRefillID.Text != "")
                    {
                        refillID = cboRefillID.Text.ToString().Trim();
                    }
                    else
                    {
                        refillID = null;
                    }


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this refill?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataTier.DeleteRefill(refillID);
                        MessageBox.Show("Refill deleted successfully.");
                        cboRefillID.Items.Remove(cboRefillID.SelectedItem);
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvRefills_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefills.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dgvRefills.SelectedRows[0].DataBoundItem).Row;
                PopulateFields(row);
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditRefill_Click(object sender, EventArgs e)
        {
            try
            {
                string refillID = "";
                int refillCount = 0;
                int refillsRemaining = 0;
                string prescriptionID = "";
                if (dgvRefills.SelectedRows.Count > 0)
                {
                    refillID = cboRefillID.Text.Trim();
                    refillCount = Convert.ToInt32(txtFillCount.Text);
                    refillsRemaining = Convert.ToInt32(txtRefillsRemaining.Text);
                    prescriptionID = cboPrescriptionID.Text.ToString().Trim();

                    dataTier.UpdatePrescription(refillID, refillsRemaining, prescriptionID);
                    MessageBox.Show("Refill updated successfully.");
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDecrementRefill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cboPrescriptionID.Text.ToString().Trim(), out int prescriptionId))
            {
                dataTier.DecrementRefill(prescriptionId);
                MessageBox.Show("Remaining refill decremented by 1.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Prescription ID.");
            }
        }

        private void btnIncrementRefill_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(cboPrescriptionID.Text, out int prescriptionId))
            {
                dataTier.IncrementRefill(prescriptionId);
                MessageBox.Show("Remaining refill incremented by 1.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Prescription ID.");
            }
        }
    }
}