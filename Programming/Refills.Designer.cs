namespace Programming
{
    partial class Refills
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
            this.btnAddRefill = new System.Windows.Forms.Button();
            this.lblFillCount = new System.Windows.Forms.Label();
            this.txtFillCount = new System.Windows.Forms.TextBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.cboRefillID = new System.Windows.Forms.ComboBox();
            this.dgvRefills = new System.Windows.Forms.DataGridView();
            this.btnDeleteRefill = new System.Windows.Forms.Button();
            this.btnDecrementRefill = new System.Windows.Forms.Button();
            this.btnSearchRefill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrescriptionID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefillsRemaining = new System.Windows.Forms.TextBox();
            this.btnIncrementRefill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRefill
            // 
            this.btnAddRefill.Location = new System.Drawing.Point(12, 405);
            this.btnAddRefill.Name = "btnAddRefill";
            this.btnAddRefill.Size = new System.Drawing.Size(136, 42);
            this.btnAddRefill.TabIndex = 73;
            this.btnAddRefill.Text = "Add Refill";
            this.btnAddRefill.UseVisualStyleBackColor = true;
            this.btnAddRefill.Click += new System.EventHandler(this.btnAddRefill_Click);
            // 
            // lblFillCount
            // 
            this.lblFillCount.AutoSize = true;
            this.lblFillCount.Location = new System.Drawing.Point(456, 18);
            this.lblFillCount.Name = "lblFillCount";
            this.lblFillCount.Size = new System.Drawing.Size(56, 13);
            this.lblFillCount.TabIndex = 81;
            this.lblFillCount.Text = "Fill Count: ";
            // 
            // txtFillCount
            // 
            this.txtFillCount.Location = new System.Drawing.Point(518, 12);
            this.txtFillCount.Name = "txtFillCount";
            this.txtFillCount.Size = new System.Drawing.Size(45, 20);
            this.txtFillCount.TabIndex = 71;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.Location = new System.Drawing.Point(20, 11);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(53, 16);
            this.lblPrescription.TabIndex = 80;
            this.lblPrescription.Text = "Refill ID";
            // 
            // cboRefillID
            // 
            this.cboRefillID.FormattingEnabled = true;
            this.cboRefillID.Location = new System.Drawing.Point(82, 10);
            this.cboRefillID.Name = "cboRefillID";
            this.cboRefillID.Size = new System.Drawing.Size(118, 21);
            this.cboRefillID.TabIndex = 70;
            // 
            // dgvRefills
            // 
            this.dgvRefills.AllowUserToAddRows = false;
            this.dgvRefills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefills.Location = new System.Drawing.Point(15, 39);
            this.dgvRefills.Name = "dgvRefills";
            this.dgvRefills.ReadOnly = true;
            this.dgvRefills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefills.Size = new System.Drawing.Size(695, 360);
            this.dgvRefills.TabIndex = 78;
            this.dgvRefills.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefills_CellContentDoubleClick);
            // 
            // btnDeleteRefill
            // 
            this.btnDeleteRefill.Location = new System.Drawing.Point(580, 405);
            this.btnDeleteRefill.Name = "btnDeleteRefill";
            this.btnDeleteRefill.Size = new System.Drawing.Size(136, 42);
            this.btnDeleteRefill.TabIndex = 76;
            this.btnDeleteRefill.Text = "Delete Refill";
            this.btnDeleteRefill.UseVisualStyleBackColor = true;
            this.btnDeleteRefill.Click += new System.EventHandler(this.btnDeleteRefill_Click);
            // 
            // btnDecrementRefill
            // 
            this.btnDecrementRefill.Location = new System.Drawing.Point(296, 405);
            this.btnDecrementRefill.Name = "btnDecrementRefill";
            this.btnDecrementRefill.Size = new System.Drawing.Size(136, 42);
            this.btnDecrementRefill.TabIndex = 75;
            this.btnDecrementRefill.Text = "Decrement Refill";
            this.btnDecrementRefill.UseVisualStyleBackColor = true;
            this.btnDecrementRefill.Click += new System.EventHandler(this.btnDecrementRefill_Click);
            // 
            // btnSearchRefill
            // 
            this.btnSearchRefill.Location = new System.Drawing.Point(438, 405);
            this.btnSearchRefill.Name = "btnSearchRefill";
            this.btnSearchRefill.Size = new System.Drawing.Size(136, 42);
            this.btnSearchRefill.TabIndex = 74;
            this.btnSearchRefill.Text = "Search Refill";
            this.btnSearchRefill.UseVisualStyleBackColor = true;
            this.btnSearchRefill.Click += new System.EventHandler(this.btnSearchRefill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Prescription ID";
            // 
            // cboPrescriptionID
            // 
            this.cboPrescriptionID.FormattingEnabled = true;
            this.cboPrescriptionID.Location = new System.Drawing.Point(320, 12);
            this.cboPrescriptionID.Name = "cboPrescriptionID";
            this.cboPrescriptionID.Size = new System.Drawing.Size(118, 21);
            this.cboPrescriptionID.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Refills Remaining: ";
            // 
            // txtRefillsRemaining
            // 
            this.txtRefillsRemaining.Location = new System.Drawing.Point(665, 15);
            this.txtRefillsRemaining.Name = "txtRefillsRemaining";
            this.txtRefillsRemaining.Size = new System.Drawing.Size(45, 20);
            this.txtRefillsRemaining.TabIndex = 85;
            // 
            // btnIncrementRefill
            // 
            this.btnIncrementRefill.Location = new System.Drawing.Point(154, 405);
            this.btnIncrementRefill.Name = "btnIncrementRefill";
            this.btnIncrementRefill.Size = new System.Drawing.Size(136, 42);
            this.btnIncrementRefill.TabIndex = 87;
            this.btnIncrementRefill.Text = "Increment Refill";
            this.btnIncrementRefill.UseVisualStyleBackColor = true;
            this.btnIncrementRefill.Click += new System.EventHandler(this.btnIncrementRefill_Click_1);
            // 
            // Refills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 459);
            this.Controls.Add(this.btnIncrementRefill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRefillsRemaining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPrescriptionID);
            this.Controls.Add(this.btnAddRefill);
            this.Controls.Add(this.lblFillCount);
            this.Controls.Add(this.txtFillCount);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.cboRefillID);
            this.Controls.Add(this.dgvRefills);
            this.Controls.Add(this.btnDeleteRefill);
            this.Controls.Add(this.btnDecrementRefill);
            this.Controls.Add(this.btnSearchRefill);
            this.Name = "Refills";
            this.Text = "Refills";
            this.Load += new System.EventHandler(this.Refills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRefill;
        private System.Windows.Forms.Label lblFillCount;
        private System.Windows.Forms.TextBox txtFillCount;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.ComboBox cboRefillID;
        private System.Windows.Forms.DataGridView dgvRefills;
        private System.Windows.Forms.Button btnDeleteRefill;
        private System.Windows.Forms.Button btnDecrementRefill;
        private System.Windows.Forms.Button btnSearchRefill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPrescriptionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefillsRemaining;
        private System.Windows.Forms.Button btnIncrementRefill;
    }
}