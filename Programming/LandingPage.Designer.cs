namespace Programming
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPatientAddPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPatientSearchPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavDelPat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPharmacist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPharmacistAddPharmacist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPharmacistSearchPharmacist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPrescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPrescriptionAddPrescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigationPrescriptionSearchPrescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefillsRefill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuNavigation,
            this.mnuHelp,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNavigationPatient,
            this.mnuNavigationPharmacist,
            this.mnuNavigationPrescription,
            this.mnuRefill});
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(77, 20);
            this.mnuNavigation.Tag = "MenuButton";
            this.mnuNavigation.Text = "Navigation";
            // 
            // mnuNavigationPatient
            // 
            this.mnuNavigationPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNavigationPatientAddPatient,
            this.mnuNavigationPatientSearchPatient,
            this.mnuNavDelPat});
            this.mnuNavigationPatient.Name = "mnuNavigationPatient";
            this.mnuNavigationPatient.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPatient.Text = "Patient";
            // 
            // mnuNavigationPatientAddPatient
            // 
            this.mnuNavigationPatientAddPatient.Name = "mnuNavigationPatientAddPatient";
            this.mnuNavigationPatientAddPatient.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPatientAddPatient.Text = "Add Patient";
            this.mnuNavigationPatientAddPatient.Click += new System.EventHandler(this.mnuNavigationPatientAddPatient_Click);
            // 
            // mnuNavigationPatientSearchPatient
            // 
            this.mnuNavigationPatientSearchPatient.Name = "mnuNavigationPatientSearchPatient";
            this.mnuNavigationPatientSearchPatient.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPatientSearchPatient.Text = "Search Patient";
            this.mnuNavigationPatientSearchPatient.Click += new System.EventHandler(this.mnuNavigationPatientSearchPatient_Click);
            // 
            // mnuNavDelPat
            // 
            this.mnuNavDelPat.Name = "mnuNavDelPat";
            this.mnuNavDelPat.Size = new System.Drawing.Size(180, 22);
            this.mnuNavDelPat.Text = "Delete Patient";
            this.mnuNavDelPat.Click += new System.EventHandler(this.mnuNavDelPat_Click);
            // 
            // mnuNavigationPharmacist
            // 
            this.mnuNavigationPharmacist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNavigationPharmacistAddPharmacist,
            this.mnuNavigationPharmacistSearchPharmacist});
            this.mnuNavigationPharmacist.Name = "mnuNavigationPharmacist";
            this.mnuNavigationPharmacist.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPharmacist.Text = "Pharmacist";
            // 
            // mnuNavigationPharmacistAddPharmacist
            // 
            this.mnuNavigationPharmacistAddPharmacist.Name = "mnuNavigationPharmacistAddPharmacist";
            this.mnuNavigationPharmacistAddPharmacist.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPharmacistAddPharmacist.Text = "Add Pharmacist";
            this.mnuNavigationPharmacistAddPharmacist.Click += new System.EventHandler(this.mnuNavigationPharmacistAddPharmacist_Click);
            // 
            // mnuNavigationPharmacistSearchPharmacist
            // 
            this.mnuNavigationPharmacistSearchPharmacist.Name = "mnuNavigationPharmacistSearchPharmacist";
            this.mnuNavigationPharmacistSearchPharmacist.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPharmacistSearchPharmacist.Text = "Search Pharmacist";
            this.mnuNavigationPharmacistSearchPharmacist.Click += new System.EventHandler(this.mnuNavigationPharmacistSearchPharmacist_Click);
            // 
            // mnuNavigationPrescription
            // 
            this.mnuNavigationPrescription.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNavigationPrescriptionAddPrescription,
            this.mnuNavigationPrescriptionSearchPrescription});
            this.mnuNavigationPrescription.Name = "mnuNavigationPrescription";
            this.mnuNavigationPrescription.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPrescription.Text = "Prescription";
            // 
            // mnuNavigationPrescriptionAddPrescription
            // 
            this.mnuNavigationPrescriptionAddPrescription.Name = "mnuNavigationPrescriptionAddPrescription";
            this.mnuNavigationPrescriptionAddPrescription.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPrescriptionAddPrescription.Text = "Add Prescription";
            this.mnuNavigationPrescriptionAddPrescription.Click += new System.EventHandler(this.mnuNavigationPrescriptionAddPrescription_Click);
            // 
            // mnuNavigationPrescriptionSearchPrescription
            // 
            this.mnuNavigationPrescriptionSearchPrescription.Name = "mnuNavigationPrescriptionSearchPrescription";
            this.mnuNavigationPrescriptionSearchPrescription.Size = new System.Drawing.Size(180, 22);
            this.mnuNavigationPrescriptionSearchPrescription.Text = "Search Prescription";
            this.mnuNavigationPrescriptionSearchPrescription.Click += new System.EventHandler(this.mnuNavigationPrescriptionSearchPrescription_Click);
            // 
            // mnuRefill
            // 
            this.mnuRefill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefillsRefill});
            this.mnuRefill.Name = "mnuRefill";
            this.mnuRefill.Size = new System.Drawing.Size(180, 22);
            this.mnuRefill.Text = "Refills";
            // 
            // mnuRefillsRefill
            // 
            this.mnuRefillsRefill.Name = "mnuRefillsRefill";
            this.mnuRefillsRefill.Size = new System.Drawing.Size(100, 22);
            this.mnuRefillsRefill.Text = "Refill";
            this.mnuRefillsRefill.Click += new System.EventHandler(this.mnuRefillRefill_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowArrangeIcons,
            this.mnuWindowCascade,
            this.mnuWindowHorizontal,
            this.mnuWindowVertical,
            this.mnuWindowCloseAll});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            // 
            // mnuWindowArrangeIcons
            // 
            this.mnuWindowArrangeIcons.Name = "mnuWindowArrangeIcons";
            this.mnuWindowArrangeIcons.Size = new System.Drawing.Size(147, 22);
            this.mnuWindowArrangeIcons.Text = "Arrange Icons";
            this.mnuWindowArrangeIcons.Click += new System.EventHandler(this.mnuWindowArrangeIcons_Click);
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(147, 22);
            this.mnuWindowCascade.Text = "Cascade";
            this.mnuWindowCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);
            // 
            // mnuWindowHorizontal
            // 
            this.mnuWindowHorizontal.Name = "mnuWindowHorizontal";
            this.mnuWindowHorizontal.Size = new System.Drawing.Size(147, 22);
            this.mnuWindowHorizontal.Text = "Horizontal";
            this.mnuWindowHorizontal.Click += new System.EventHandler(this.mnuWindowHorizontal_Click);
            // 
            // mnuWindowVertical
            // 
            this.mnuWindowVertical.Name = "mnuWindowVertical";
            this.mnuWindowVertical.Size = new System.Drawing.Size(147, 22);
            this.mnuWindowVertical.Text = "Vertical";
            this.mnuWindowVertical.Click += new System.EventHandler(this.mnuWindowVertical_Click);
            // 
            // mnuWindowCloseAll
            // 
            this.mnuWindowCloseAll.Name = "mnuWindowCloseAll";
            this.mnuWindowCloseAll.Size = new System.Drawing.Size(147, 22);
            this.mnuWindowCloseAll.Text = "Close All";
            this.mnuWindowCloseAll.Click += new System.EventHandler(this.mnuWindowCloseAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 682);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming.Properties.Resources.LPLogoGradient;
            this.ClientSize = new System.Drawing.Size(1162, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPatient;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPharmacist;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPrescription;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCloseAll;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPharmacistAddPharmacist;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPrescriptionAddPrescription;
        public System.Windows.Forms.ToolStripMenuItem mnuNavigationPatientAddPatient;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPatientSearchPatient;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPharmacistSearchPharmacist;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigationPrescriptionSearchPrescription;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNavDelPat;
        private System.Windows.Forms.ToolStripMenuItem mnuRefill;
        private System.Windows.Forms.ToolStripMenuItem mnuRefillsRefill;
    }
}