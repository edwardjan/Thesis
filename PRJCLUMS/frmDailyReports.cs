using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    public partial class frmDailyReports : Form
    {
        CDBProvider cdb = new CDBProvider();
        CreateDailyReport createDailyReport = new CreateDailyReport();

        public frmDailyReports()
        {
            InitializeComponent();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
           if (monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd") != monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd"))
                cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate >= '{0}' AND BillInfo.BillDate <= '{1}' ;", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"), monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd")));
            else
                cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%';", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd")));

            cdb.ShowCountData(lblData);

            if (listView.Items.Count > 0)
                btnPrint.Enabled = true;
            else btnPrint.Enabled = false;
        }

        private void frmDailyReports_Load(object sender, EventArgs e)
        {
            cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
            cdb.ShowCountData(lblData);

            if (listView.Items.Count > 0)
                btnPrint.Enabled = true;
            else btnPrint.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF|*.pdf;";
            save.FileName = "Daily_Report";
            if (save.ShowDialog() == DialogResult.OK)
            {
                createDailyReport.listViewItem = listView.Items;
                createDailyReport.daily_report_date = monthCalendar.SelectionRange.Start.ToString("MM-dd-yyyy");
                createDailyReport.PrintPDF(save.FileName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(text) || cbSearch.Text.Equals("         (select)"))
            {
                MessageBox.Show("Please enter a search value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbSearch.Text.Equals("By Item Number"))
                {
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE Bill.ItemNumber LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
                    //cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem` WHERE(ItemNumber LIKE'%" + txtSearch.Text + "%');");
                    cdb.ShowCountData(lblData);
                    int dats = listView.Items.Count;
                    if (dats == 0)
                    {
                        MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cbSearch.Text.Equals("By Customer"))
                {
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.CustomerName LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
                    cdb.ShowCountData(lblData);
                    int dats = listView.Items.Count;
                    if (dats == 0)
                    {
                        MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.UserId FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.UserId LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
                    cdb.ShowCountData(lblData);
                    int dats = listView.Items.Count;
                    if (dats == 0)
                    {
                        MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (listView.Items.Count > 0)
                btnPrint.Enabled = true;
            else btnPrint.Enabled = false;
        }

    }
}
