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
    public partial class frmReports : Form
    {
        CDBProvider cdb = new CDBProvider();
        CreateMonthlyReport createMontlyReport = new CreateMonthlyReport();
        CreateYearlyReport createYearlyReport = new CreateYearlyReport();
        CreateDailyReport createDailyReport = new CreateDailyReport();

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            cdb.PopulateDailWeeklyReports(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
            cdb.ShowCountData(lblData);

            if (listView.Items.Count > 0)
                btnDailyWeekly.Enabled = true;
            else btnDailyWeekly.Enabled = false;
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing reports form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            cdb.PopulateMonthyReports(listView1, String.Format("SELECT BillDate, User, CustomerName, TotalItemsSold, TotalDue FROM tblbillinginfo WHERE BillDate LIKE '{0}%';", dtpByMonth.Value.ToString("yyyy-MM")));

            if (listView1.Items.Count > 0)
                btnPrint.Enabled = true;
            else btnPrint.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double TotalAmount = 0;
            listView2.Items.Clear();

            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-01"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-02"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-03"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-04"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-05"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-06"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-07"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-08"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-09"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-10"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-11"), ref TotalAmount, false);
            cdb.PopulateYearlyReports(listView2, String.Format("SELECT MONTH(`BillDate`) As 'Month', SUM(`TotalItemsSold`) As 'ItemSold', SUM(`TotalDue`) As 'TotalDue' FROM `tblbillinginfo` WHERE `BillDate` LIKE '{0}%' GROUP BY Month;", dtpByYear.Value.ToString("yyyy") + "-12"), ref TotalAmount, false);

            if (listView2.Items.Count > 0)
            {
                // Compute 12% TAX.
                string NetSales = (TotalAmount / 1.12).ToString("###,##0.00") + " PHP";
                string TaxPayable = (TotalAmount - (TotalAmount / 1.12)).ToString("###,##0.00") + " PHP";
                string TotalSales = TotalAmount.ToString("###,##0.00") + " PHP";

                ListViewItem footer = new ListViewItem(new string[] { "", "=======", "==========" });
                listView2.Items.Add(footer);
                footer = new ListViewItem(new string[] { "", "Net Sales:", NetSales });
                listView2.Items.Add(footer);
                footer = new ListViewItem(new string[] { "", "Tax Payable (12%):", TaxPayable });
                listView2.Items.Add(footer);
                footer = new ListViewItem(new string[] { "", "Total Sales:", TotalSales });
                listView2.Items.Add(footer);


                btnPrintYearly.Enabled = true;
            }
            else btnPrintYearly.Enabled = false;
        }

        private void btnPrintYearly_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Generating PDF file.");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf;";
                save.FileName = "Yearly_Report";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    createYearlyReport.listViewItem = listView2.Items;
                    createYearlyReport.daily_report_date = dtpByYear.Value.ToString("yyyy");
                    createYearlyReport.PrintPDF(save.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrintMontly_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Generating PDF file.");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf;";
                save.FileName = "Monthly_Report";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    createMontlyReport.listViewItem = listView1.Items;
                    createMontlyReport.daily_report_date = dtpByMonth.Value.ToString("MM-yyyy");
                    createMontlyReport.PrintPDF(save.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd") != monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd"))
                cdb.PopulateDailWeeklyReports(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate >= '{0}' AND BillInfo.BillDate <= '{1}';", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"), monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd")));
            else
                cdb.PopulateDailWeeklyReports(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%';", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd")));

            cdb.ShowCountData(lblData);

            if (listView.Items.Count > 0)
                btnDailyWeekly.Enabled = true;
            else btnDailyWeekly.Enabled = false;
        }

        
        private void btnPrintDaily_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Generating PDF file.");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf;";
                save.FileName = "Daily_Report";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    //if (monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd") != monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd"))
                    //    cdb.PopulateDailWeeklyReports(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,SUM(Bill.Quantity),SUM(Bill.TotalPrice), BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate >= '{0}' AND BillInfo.BillDate <= '{1}' GROUP BY (Bill.ItemNumber AND Bill.BillingInfoId);", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"), monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd")));
                    //else
                    //    cdb.PopulateDailWeeklyReports(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,SUM(Bill.Quantity),SUM(Bill.TotalPrice), BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%' GROUP BY (Bill.ItemNumber AND Bill.BillingInfoId);", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd")));

                    createDailyReport.listViewItem = listView.Items;
                    createDailyReport.daily_report_date = monthCalendar.SelectionRange.Start.ToString("MM-dd-yyyy");
                    createDailyReport.PrintPDF(save.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnSearchDailyWeekly_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(text) || cbSearch.Text.Equals("         (select)"))
            {
                MessageBox.Show("Please enter a search value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbSearch.Text.Equals("By Item Name"))
                {
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE Bill.ItemName LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
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
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.CustomerName LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
                    cdb.ShowCountData(lblData);
                    int dats = listView.Items.Count;
                    if (dats == 0)
                    {
                        MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cdb.Populate(listView, String.Format("SELECT Bill.BillingInfoId,BillInfo.BillDate,Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,Bill.Quantity,Bill.TotalPrice, BillInfo.CustomerName, BillInfo.User FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.User LIKE'%" + txtSearch.Text + "%' AND BillInfo.BillDate LIKE '{0}%';", DateTime.Now.ToString("yyyy-MM-dd")));
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TabControl tb = (System.Windows.Forms.TabControl)sender;
        }

    }
}
