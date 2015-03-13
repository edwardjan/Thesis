using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PRJCLUMS.Logger;

namespace PRJCLUMS
{
    public partial class frmMDI : Form
    {
        bool cond = true;
        string strAdmin = string.Empty;
        public frmMDI()
        {
            InitializeComponent();
            Logger.Logger.Log("Initialization successful.");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = MessageBox.Show("Are you sure you want to log out?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (con.Equals("Yes"))
                {
                    frmLogin fl = new frmLogin();
                    fl.Show();
                    cond = false;
                    Logger.Logger.Log(string.Format("Logging out from account [{0}].", strAdmin));
                    this.Close();
                }
            }
            catch (Exception ex) 
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        public void setAdmin(string admin)
        {
            try
            {
                lblUser.Text = lblUser.Text + admin;
                strAdmin = admin;
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        public void setType(string type)
        {
            try
            {
                if (type.Equals("Regular"))
                {
                    userToolStripMenuItem.Visible = false;
                    inventoryToolStripMenuItem.Visible = false;
                }
            }
            catch(Exception ex){
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void adduserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening add user form.");
                frmAddUser au = new frmAddUser();
                au.MdiParent = this;
                au.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void manageusersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening manage users form.");
                frmViewUser vu = new frmViewUser();
                vu.MdiParent = this;
                vu.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void additemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDBProvider cdb = new CDBProvider();
            int tee = Convert.ToInt16(cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE(Status='Active');"));
            if (tee <= 0)
            {
                MessageBox.Show("There are no categories in the database!\nA category must be added into the system first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmViewCategory fvc = new frmViewCategory();
                fvc.MdiParent = this;
                fvc.Show();
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Opening add item form.");
                    frmAddInventory ai = new frmAddInventory();
                    ai.MdiParent = this;
                    ai.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void manageinventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening manage items form.");
                frmViewItems vi = new frmViewItems();
                vi.MdiParent = this;
                vi.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening add main category form.");
                frmAddCategory ac = new frmAddCategory();
                ac.MdiParent = this;
                ac.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening manage categories form.");
                frmViewCategory vc = new frmViewCategory();
                vc.MdiParent = this;
                vc.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDBProvider cdb = new CDBProvider();
            int tee = Convert.ToInt16(cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblitem` WHERE(Status='Active');"));
            if (tee <= 0)
            {
                MessageBox.Show("There are no items in the database!\nAn item must be added into the system first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmViewItems fvi = new frmViewItems();
                fvi.Show();
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Opening billing form.");
                    frmBilling bill = new frmBilling();
                    bill.UserId = this.lblUser.Text.Substring(this.lblUser.Text.LastIndexOf(":") + 1);
                    bill.ShowDialog();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyReports dr = new frmDailyReports();
            dr.ShowDialog(); 
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening reports form.");
                frmReports rep = new frmReports();
                rep.ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening inquiry form.");
                frmBillInquiry _frmBillInquiry = new frmBillInquiry();
                _frmBillInquiry.UserId = lblUser.Text;
                _frmBillInquiry.ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cond == true)
            {
                Application.Exit();
            }
        }

        private void itemReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening item reports form.");
                frmItemReports rep = new frmItemReports();
                rep.ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void addSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Opening add sub category form.");
                frmAddSubCategory asc = new frmAddSubCategory();
                asc.MdiParent = this;
                asc.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }
    }
}
