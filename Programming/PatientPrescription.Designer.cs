namespace Programming
{
    partial class frmPatientPrescription
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.cboPatientID = new System.Windows.Forms.ComboBox();
            this.btnDeletePrescription = new System.Windows.Forms.Button();
            this.btnUpdatePrescription = new System.Windows.Forms.Button();
            this.btnSearchPrescription = new System.Windows.Forms.Button();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.lblPharmacist = new System.Windows.Forms.Label();
            this.cboPharmacistID = new System.Windows.Forms.ComboBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.cboPrescriptionID = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFillCount = new System.Windows.Forms.Label();
            this.txtFillCount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnNewPrescription = new System.Windows.Forms.Button();
            this.ttPP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(19, 13);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(64, 16);
            this.lblPatientID.TabIndex = 59;
            this.lblPatientID.Text = "Patient ID";
            // 
            // cboPatientID
            // 
            this.cboPatientID.FormattingEnabled = true;
            this.cboPatientID.Location = new System.Drawing.Point(104, 10);
            this.cboPatientID.Name = "cboPatientID";
            this.cboPatientID.Size = new System.Drawing.Size(118, 21);
            this.cboPatientID.TabIndex = 1;
            this.ttPP.SetToolTip(this.cboPatientID, "Please Enter/Select a Patient ID");
            // 
            // btnDeletePrescription
            // 
            this.btnDeletePrescription.Location = new System.Drawing.Point(590, 382);
            this.btnDeletePrescription.Name = "btnDeletePrescription";
            this.btnDeletePrescription.Size = new System.Drawing.Size(92, 42);
            this.btnDeletePrescription.TabIndex = 9;
            this.btnDeletePrescription.Text = "Delete Prescription";
            this.ttPP.SetToolTip(this.btnDeletePrescription, "Delete Existing Prescription");
            this.btnDeletePrescription.UseVisualStyleBackColor = true;
            this.btnDeletePrescription.Click += new System.EventHandler(this.btnDeletePrescription_Click_1);
            // 
            // btnUpdatePrescription
            // 
            this.btnUpdatePrescription.Location = new System.Drawing.Point(392, 382);
            this.btnUpdatePrescription.Name = "btnUpdatePrescription";
            this.btnUpdatePrescription.Size = new System.Drawing.Size(94, 42);
            this.btnUpdatePrescription.TabIndex = 8;
            this.btnUpdatePrescription.Text = "Update Prescription";
            this.ttPP.SetToolTip(this.btnUpdatePrescription, "Update Existing Prescription");
            this.btnUpdatePrescription.UseVisualStyleBackColor = true;
            this.btnUpdatePrescription.Click += new System.EventHandler(this.btnUpdatePrescription_Click);
            // 
            // btnSearchPrescription
            // 
            this.btnSearchPrescription.Location = new System.Drawing.Point(197, 382);
            this.btnSearchPrescription.Name = "btnSearchPrescription";
            this.btnSearchPrescription.Size = new System.Drawing.Size(94, 42);
            this.btnSearchPrescription.TabIndex = 7;
            this.btnSearchPrescription.Text = "Search Prescription";
            this.ttPP.SetToolTip(this.btnSearchPrescription, "Searches for an Existing Prescription");
            this.btnSearchPrescription.UseVisualStyleBackColor = true;
            this.btnSearchPrescription.Click += new System.EventHandler(this.btnSearchPrescription_Click);
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(22, 78);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.ReadOnly = true;
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(660, 298);
            this.dgvPrescriptions.TabIndex = 60;
            this.dgvPrescriptions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescriptions_CellContentDoubleClick);
            // 
            // lblPharmacist
            // 
            this.lblPharmacist.AutoSize = true;
            this.lblPharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacist.Location = new System.Drawing.Point(234, 13);
            this.lblPharmacist.Name = "lblPharmacist";
            this.lblPharmacist.Size = new System.Drawing.Size(90, 16);
            this.lblPharmacist.TabIndex = 62;
            this.lblPharmacist.Text = "Pharmacist ID";
            // 
            // cboPharmacistID
            // 
            this.cboPharmacistID.FormattingEnabled = true;
            this.cboPharmacistID.Location = new System.Drawing.Point(329, 12);
            this.cboPharmacistID.Name = "cboPharmacistID";
            this.cboPharmacistID.Size = new System.Drawing.Size(118, 21);
            this.cboPharmacistID.TabIndex = 2;
            this.ttPP.SetToolTip(this.cboPharmacistID, "Please Select/Enter Pharmacist ID");
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.Location = new System.Drawing.Point(453, 13);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(94, 16);
            this.lblPrescription.TabIndex = 64;
            this.lblPrescription.Text = "Prescription ID";
            // 
            // cboPrescriptionID
            // 
            this.cboPrescriptionID.FormattingEnabled = true;
            this.cboPrescriptionID.Location = new System.Drawing.Point(552, 10);
            this.cboPrescriptionID.Name = "cboPrescriptionID";
            this.cboPrescriptionID.Size = new System.Drawing.Size(118, 21);
            this.cboPrescriptionID.TabIndex = 3;
            this.ttPP.SetToolTip(this.cboPrescriptionID, "Please Enter/Select Prescription ID");
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(140, 47);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Text = "Description: ";
            // 
            // lblFillCount
            // 
            this.lblFillCount.AutoSize = true;
            this.lblFillCount.Location = new System.Drawing.Point(27, 46);
            this.lblFillCount.Name = "lblFillCount";
            this.lblFillCount.Size = new System.Drawing.Size(56, 13);
            this.lblFillCount.TabIndex = 65;
            this.lblFillCount.Text = "Fill Count: ";
            // 
            // txtFillCount
            // 
            this.txtFillCount.Location = new System.Drawing.Point(89, 44);
            this.txtFillCount.Name = "txtFillCount";
            this.txtFillCount.Size = new System.Drawing.Size(45, 20);
            this.txtFillCount.TabIndex = 4;
            this.ttPP.SetToolTip(this.txtFillCount, "Fill Count Text Box");
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(212, 43);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(458, 20);
            this.txtDescription.TabIndex = 5;
            this.ttPP.SetToolTip(this.txtDescription, "Description Text Box");
            // 
            // btnNewPrescription
            // 
            this.btnNewPrescription.Location = new System.Drawing.Point(22, 382);
            this.btnNewPrescription.Name = "btnNewPrescription";
            this.btnNewPrescription.Size = new System.Drawing.Size(92, 42);
            this.btnNewPrescription.TabIndex = 6;
            this.btnNewPrescription.Text = "New Prescription";
            this.ttPP.SetToolTip(this.btnNewPrescription, "Creates a New Prescription");
            this.btnNewPrescription.UseVisualStyleBackColor = true;
            this.btnNewPrescription.Click += new System.EventHandler(this.btnNewPrescription_Click);
            // 
            // frmPatientPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 436);
            this.Controls.Add(this.btnNewPrescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFillCount);
            this.Controls.Add(this.txtFillCount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.cboPrescriptionID);
            this.Controls.Add(this.lblPharmacist);
            this.Controls.Add(this.cboPharmacistID);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.cboPatientID);
            this.Controls.Add(this.btnDeletePrescription);
            this.Controls.Add(this.btnUpdatePrescription);
            this.Controls.Add(this.btnSearchPrescription);
            this.MaximizeBox = false;
            this.Name = "frmPatientPrescription";
            this.Text = "Patient Prescription";
            this.Load += new System.EventHandler(this.frmPatientPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.ComboBox cboPatientID;
        private System.Windows.Forms.Button btnDeletePrescription;
        private System.Windows.Forms.Button btnUpdatePrescription;
        private System.Windows.Forms.Button btnSearchPrescription;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Label lblPharmacist;
        private System.Windows.Forms.ComboBox cboPharmacistID;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.ComboBox cboPrescriptionID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFillCount;
        private System.Windows.Forms.TextBox txtFillCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnNewPrescription;
        private System.Windows.Forms.ToolTip ttPP;
    }
}