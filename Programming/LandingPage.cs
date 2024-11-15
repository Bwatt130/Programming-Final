using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Programming
{
    public partial class LandingPage : Form
    {
        public static string patID = "";
        public static string pharmID = "";
        public static string refID = "";
        public static bool addPAT = false;

        public LandingPage()
        {
            InitializeComponent();
        }

        //This is for the File dropdown menu
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        //This is for the Help dropdown menu
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            aboutApplication aB = new aboutApplication();

            mnuFile.Visible = true;
            DisableButtons("mnuHelpAbout");

            aB.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuHelpAbout");
            aB.MdiParent = this;
            aB.StartPosition = FormStartPosition.CenterScreen;
            aB.Show();
            aB.Focus();
        }


        //This is the patient section
        public void mnuNavigationPatientAddPatient_Click(object sender, EventArgs e)
        { 
            Patient pO = new Patient();
            patID = "Add";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPatientAddPatient");

            //               \/   This is a lambda that is to handle the formclosed event and pass the button names
            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPatientAddPatient");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
            addPAT = true;
            
           
        }

        public void mnuNavigationPatientSearchPatient_Click(object sender, EventArgs e)
        {
            Patient pO = new Patient();
            patID = "Search";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPatientSearchPatient");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPatientSearchPatient");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }


        //This is the Pharmacist
        private void mnuNavigationPharmacistAddPharmacist_Click(object sender, EventArgs e)
        {
            Pharmacist pO = new Pharmacist();
            pharmID = "Add";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPharmacistAddPharmacist");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPharmacistAddPharmacist");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }

        private void mnuNavigationPharmacistSearchPharmacist_Click(object sender, EventArgs e)
        {
            Pharmacist pO = new Pharmacist();
            pharmID = "Search";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPharmacistSearchPharmacist");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPharmacistSearchPharmacist");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }


        //These are for the Prescription dropdown menu
        private void mnuNavigationPrescriptionAddPrescription_Click(object sender, EventArgs e)
        {
            frmPatientPrescription pO = new frmPatientPrescription();
            patID = "PrescriptionAdd";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPrescriptionAddPrescription");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPrescriptionAddPrescription");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }

        private void mnuNavigationPrescriptionSearchPrescription_Click(object sender, EventArgs e)
        {
            frmPatientPrescription pO = new frmPatientPrescription();
            patID = "PrescriptionSearch";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPrescriptionSearchPrescription");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPrescriptionSearchPrescription");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }


        //These are for the Window dropdown menu
        private void mnuWindowVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuWindowHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuWindowArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.Close();
            }

            mnuNavigationPatient.Enabled = true;
            mnuNavigationPatientAddPatient.Enabled = true;
            mnuNavigationPharmacist.Enabled = true;
            mnuNavigationPharmacistAddPharmacist.Enabled = true;

        }

        //This is the formClose / button enable and disable section

        public delegate void FormClosedHandler(object sender, FormClosedEventArgs e, params string[] buttonNames);

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e, params string[] buttonNames)
        {
            EnableButtons(buttonNames);
        }

        private void EnableButtons(params string[] itemNames)
        {
            foreach (string itemName in itemNames)
            {
                // Search through the MenuStrip for the ToolStripMenuItem by name
                ToolStripMenuItem item = FindItemByName(this.menuStrip1.Items, itemName) as ToolStripMenuItem;
                if (item != null)
                {
                    item.Enabled = true;
                }
            }
        }

        private void DisableButtons(params string[] itemNames)
        {
            foreach (string itemName in itemNames)
            {
                // Search through the MenuStrip for the ToolStripMenuItem by name
                ToolStripMenuItem item = FindItemByName(this.menuStrip1.Items, itemName) as ToolStripMenuItem;
                if (item != null)
                {
                    item.Enabled = false;
                }
            }
        }


        // Helper method to recursively find a ToolStripMenuItem by name
        private ToolStripItem FindItemByName(ToolStripItemCollection items, string name)
        {
            foreach (ToolStripItem item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }

                if (item is ToolStripDropDownItem dropdownItem)
                {
                    ToolStripItem foundItem = FindItemByName(dropdownItem.DropDownItems, name);
                    if (foundItem != null)
                    {
                        return foundItem;
                    }
                }
            }
            return null;
        }

        private void mnuPatientPrescription_Click(object sender, EventArgs e)
        {
            frmPatientPrescription pO = new frmPatientPrescription();
            patID = "AddPrescriptionToPatient";

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPatientPrescription");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPatientPrescription");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }

        private void mnuNavigationPrescriptionRefillPrescription_Click(object sender, EventArgs e)
        {
            frmPatientPrescription pO = new frmPatientPrescription();

            mnuFile.Visible = true;
            DisableButtons("mnuNavigationPrescriptionRefillPrescription");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavigationPrescriptionRefillPrescription");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void mnuRefillRefill_Click(object sender, EventArgs e)
        {
            Refills pO = new Refills();
            refID = "Refill";

            mnuFile.Visible = true;
            DisableButtons("mnuRefillsRefill");

            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuRefillsRefill");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
        }

        private void mnuNavDelPat_Click(object sender, EventArgs e)
        {
            Patient pO = new Patient();
            patID = "Delete";

            mnuFile.Visible = true;
            DisableButtons("mnuNavDelPat");

            //               \/   This is a lambda that is to handle the formclosed event and pass the button names
            pO.FormClosed += (s, args) => ChildForm_FormClosed(s, args, "mnuNavDelPat");
            pO.MdiParent = this;
            pO.StartPosition = FormStartPosition.CenterScreen;
            pO.Show();
            pO.Focus();
            addPAT = true;

        }
    }
}
