using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    public partial class frmBillInquiry : Form
    {
        CDBProvider cdb = new CDBProvider();
        CreateInvoice createInvoice = new CreateInvoice();
        public string UserId { get; set; }
        private string[] data = new string[8];

        public frmBillInquiry()
        {
            try
            {
                InitializeComponent();
                string[] data = new string[8];
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing inquiry form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Generating PDF file.");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf;";
                save.FileName = "Bill_Report";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    cdb.Populate(lsvCart, String.Format("SELECT ItemNumber, ItemName, Category, Description, Price, SUM(Quantity), SUM(TotalPrice) FROM `tblbilling` WHERE BillingInfoID = '{0}%' GROUP BY ItemNumber;", tbxBillNo.Text));
                    createInvoice.listViewItem = lsvCart.Items;
                    createInvoice.InvoidNo = Convert.ToInt64(tbxBillNo.Text).ToString("00000");
                    createInvoice.UserID = this.UserId;
                    createInvoice.CustomerName = this.tbxCustomerName.Text;
                    createInvoice.CustomerAddress = this.tbxAddress.Text;
                    createInvoice.PrintPDF(save.FileName);
                    cdb.Populate(lsvCart, String.Format("SELECT ItemNumber, ItemName, Category, Description, Price, Quantity, TotalPrice FROM `tblbilling` WHERE BillingInfoID = '{0}%';", tbxBillNo.Text));
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing inquiry form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxCustomerName.Text = "";
            tbxAddress.Text = "";
            tbxTaxPayable.Text = "0.00";
            tbxNetSales.Text = "0.00";
            tbxTotalSales.Text = "0.00";

            cdb.Populate(lsvCart, String.Format("SELECT ItemNumber, ItemName, Category, Description, Price, Quantity, TotalPrice FROM `tblbilling` WHERE BillingInfoID = '{0}%';", tbxBillNo.Text));
            cdb.ShowCountData(lblData);

            if (cdb.NoData == 0)
            {
                MessageBox.Show("Record not found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnPrint.Enabled = false;
                return;
            }
            
            CBilling _cBilling = new CBilling();
            _cBilling = _cBilling.GetBill(tbxBillNo.Text);
            tbxCustomerName.Text = _cBilling.CustomerName;
            tbxAddress.Text = _cBilling.CustomerAddress;

            // Compute 12% TAX.
            tbxNetSales.Text = (_cBilling.TotalAmount / 1.12).ToString("###,##0.00");
            tbxTaxPayable.Text = (_cBilling.TotalAmount - (_cBilling.TotalAmount / 1.12)).ToString("###,##0.00");
            tbxTotalSales.Text = _cBilling.TotalAmount.ToString("###,##0.00");

            this.btnPrint.Enabled = true;
        }

        private void tbxBillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button1_Click(sender, new EventArgs());
        }
    }
}
