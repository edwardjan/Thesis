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
    public partial class frmItemReports : Form
    {
        CDBProvider cdb = new CDBProvider();
        CreateItemReport createItemReport = new CreateItemReport();

        public frmItemReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                cdb.PopulateItems(listView, "SELECT Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,(SELECT Stock FROM `tblitem` WHERE Bill.ItemNumber = ItemNumber  LIMIT 1) AS Stock, (SELECT SUM(Quantity) FROM `tblbilling` WHERE ItemNumber = Bill.ItemNumber) AS ItemSold, 0, 0, 0 FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId GROUP BY Bill.ItemNumber;", true);

                if (listView.Items.Count > 0)
                    btnPrint.Enabled = true;
                else btnPrint.Enabled = false;
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TabControl tb = (System.Windows.Forms.TabControl)sender;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Generating PDF file.");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf;";
                save.FileName = "Item_Report";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    createItemReport.listViewItem = listView.Items;
                    createItemReport.daily_report_date = monthCalendar.SelectionRange.Start.ToString("MM-dd-yyyy");
                    createItemReport.PrintPDF(save.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void chkBxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!chkBxShowAll.Checked)
                    monthCalendar.Enabled = true;
                else
                {
                    monthCalendar.Enabled = false;
                    cdb.PopulateItems(listView, "SELECT Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,(SELECT Stock FROM `tblitem` WHERE Bill.ItemNumber = ItemNumber  LIMIT 1) AS Stock, (SELECT SUM(Quantity) FROM `tblbilling` WHERE ItemNumber = Bill.ItemNumber) AS ItemSold, 0, 0, 0 FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId GROUP BY Bill.ItemNumber;", true);
                    if (listView.Items.Count > 0)
                        btnPrint.Enabled = true;
                    else btnPrint.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd") != monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd"))
                    cdb.PopulateItems(listView, String.Format("SELECT Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,(SELECT Stock FROM `tblitem` WHERE Bill.ItemNumber = ItemNumber  LIMIT 1) AS Stock, (SELECT SUM(Quantity) FROM `tblbilling` WHERE (ItemNumber = Bill.ItemNumber AND BillInfo.ID = Bill.BillingInfoID)) AS ItemSold, 0, 0, 0 FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate >= '{0}' AND BillInfo.BillDate <= '{1}' GROUP BY Bill.ItemNumber;", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"), monthCalendar.SelectionRange.End.ToString("yyyy-MM-dd")), true);
                else
                    cdb.PopulateItems(listView, String.Format("SELECT Bill.ItemNumber,Bill.ItemName,Bill.Category,Bill.Description,Bill.Price,(SELECT Stock FROM `tblitem` WHERE Bill.ItemNumber = ItemNumber  LIMIT 1) AS Stock, (SELECT SUM(Quantity) FROM `tblbilling` WHERE (ItemNumber = Bill.ItemNumber AND BillInfo.ID = Bill.BillingInfoID)) AS ItemSold, 0, 0, 0 FROM `tblbillinginfo` AS BillInfo LEFT OUTER JOIN `tblbilling` AS Bill ON BillInfo.Id=Bill.BillingInfoId WHERE BillInfo.BillDate LIKE '{0}%' GROUP BY Bill.ItemNumber;", monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd")), true);

                if (listView.Items.Count > 0)
                    btnPrint.Enabled = true;
                else btnPrint.Enabled = false;
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

    }
}
