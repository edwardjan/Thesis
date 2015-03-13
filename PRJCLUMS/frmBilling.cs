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
    public partial class frmBilling : Form
    {
        CDBProvider cdb = new CDBProvider();
        public string UserId { get; set; }
        CreateInvoice createInvoice = new CreateInvoice();
        private string[] data = new string[11];

        public frmBilling()
        {
            InitializeComponent();
            string[] data = new string[11];

            CBilling item = new CBilling();
            tbxBillNo.Text = (item.GetLatestBillNo()).ToString("00000");
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing billing form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(Status='Active');");
            cdb.ShowCountData(lblDataItems);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(Status='Active');");
            cdb.ShowCountData(lblDataItems);
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a search value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(ItemName LIKE'%" + txtSearch.Text + "%' AND Status='Active') OR(Category LIKE'%" + txtSearch.Text + "%' AND Status='Active');");
                cdb.ShowCountData(lblDataItems);
                int dats = lsvItems.Items.Count;
                if (dats == 0)
                {
                    MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lsvItems_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 9; x++)
            {
                data[x] = lsvItems.FocusedItem.SubItems[x].Text.ToString();
            }
            txtNumber.Text = data[0];
            txtName.Text = data[1];
            txtCategory.Text = data[2] + " (" + data[3] + ")";
            txtDesc.Text = data[4];
            txtPrice.Text = data[5];
            txtStock.Text = data[6];
            txtItemSold.Text = data[7];
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Pictures\" + data[9]))
            {
                pictureBox.BackgroundImage = Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Pictures\" + data[9]);
            }
            else
            {
                pictureBox.BackgroundImage = global::PRJCLUMS.Properties.Resources.buttonsearchbook;
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Adding item to be sold.");
                if (lsvItems.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item to add!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Convert.ToInt32(txtStock.Text) <= 0)
                    {
                        MessageBox.Show("No more items available!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtQuantity.Text) < 0)
                        {
                            MessageBox.Show("The specified quantity of items is greater than the current stock!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Convert.ToInt32(txtStock.Text) <= 5 && Convert.ToInt32(txtStock.Text) >= 1)
                            {
                                string con = MessageBox.Show("Only " + txtStock.Text + " left!\nDo you want to continue?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                                if (con.Equals("Yes"))
                                {
                                    cdb.ExecuteSql("UPDATE tblitem SET Stock=" + (Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtQuantity.Text)) + ", NoOfItemSold=" + (Convert.ToInt32(txtItemSold.Text) + Convert.ToInt32(txtQuantity.Text)) + " WHERE(ItemNumber='" + txtNumber.Text + "');");
                                    string[] _data = new string[11];
                                    for (int x = 0; x < 5; x++)
                                    {
                                        _data[x] = lsvItems.FocusedItem.SubItems[x].Text.ToString();
                                    }
                                    _data[5] = (Convert.ToDecimal(lsvItems.FocusedItem.SubItems[5].Text)).ToString("#,###0.00");
                                    _data[6] = txtQuantity.Text;
                                    _data[7] = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(data[5])).ToString("#,###0.00");

                                    // Compute 12% TAX.
                                    txtGrandTotal.Text = (Convert.ToDecimal(txtGrandTotal.Text) + Convert.ToDecimal(_data[7])).ToString("#,###,###0.00");
                                    tbxNetSales.Text = (Convert.ToDouble(txtGrandTotal.Text) / 1.12).ToString("###,##0.00");
                                    tbxTaxPayable.Text = (Convert.ToDouble(txtGrandTotal.Text) - (Convert.ToDouble(txtGrandTotal.Text) / 1.12)).ToString("###,##0.00");

                                    ListViewItem items = new ListViewItem(_data);
                                    lsvCart.Items.Add(items);

                                    if (lsvCart.Items.Count > 0) this.btnPrint.Enabled = true;
                                    else this.btnPrint.Enabled = false;

                                    txtNumber.Clear();
                                    txtName.Clear();
                                    txtCategory.Clear();
                                    txtDesc.Clear();
                                    txtPrice.Clear();
                                    txtStock.Clear();
                                    pictureBox.Image = global::PRJCLUMS.Properties.Resources.buttonsearchbook;
                                    cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(Status='Active');");
                                    cdb.ShowCountData(lblDataItems);
                                }
                            }
                            else
                            {
                                cdb.ExecuteSql("UPDATE tblitem SET Stock=" + (Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtQuantity.Text)) + ", NoOfItemSold=" + (Convert.ToInt32(txtItemSold.Text) + Convert.ToInt32(txtQuantity.Text)) + " WHERE(ItemNumber='" + txtNumber.Text + "');");
                                string[] _data = new string[11];
                                for (int x = 0; x < 5; x++)
                                {
                                    _data[x] = lsvItems.FocusedItem.SubItems[x].Text.ToString();
                                }
                                _data[5] = (Convert.ToDecimal(lsvItems.FocusedItem.SubItems[5].Text)).ToString("#,###0.00");
                                _data[6] = txtQuantity.Text;
                                _data[7] = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(data[5])).ToString("#,###0.00");

                                // Compute 12% TAX.
                                txtGrandTotal.Text = (Convert.ToDecimal(txtGrandTotal.Text) + Convert.ToDecimal(_data[7])).ToString("#,###,###0.00");
                                tbxNetSales.Text = (Convert.ToDouble(txtGrandTotal.Text) / 1.12).ToString("###,##0.00");
                                tbxTaxPayable.Text = (Convert.ToDouble(txtGrandTotal.Text) - (Convert.ToDouble(txtGrandTotal.Text) / 1.12)).ToString("###,##0.00");

                                ListViewItem items = new ListViewItem(_data);
                                lsvCart.Items.Add(items);

                                if (lsvCart.Items.Count > 0) this.btnPrint.Enabled = true;
                                else this.btnPrint.Enabled = false;

                                txtNumber.Clear();
                                txtName.Clear();
                                txtCategory.Clear();
                                txtDesc.Clear();
                                txtPrice.Clear();
                                txtStock.Clear();
                                pictureBox.Image = global::PRJCLUMS.Properties.Resources.buttonsearchbook;
                                cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(Status='Active');");
                                cdb.ShowCountData(lblDataItems);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
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
                    createInvoice.listViewItem = lsvCart.Items;
                    createInvoice.InvoidNo = tbxBillNo.Text;
                    createInvoice.UserID = this.UserId;
                    createInvoice.CustomerName = this.tbxCustomerName.Text;
                    createInvoice.CustomerAddress = this.tbxAddress.Text;
                    createInvoice.PrintPDF(save.FileName);
                    Logger.Logger.Log("Generating Bill Report successfully!");
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Confirming billing transaction.");
                CBilling item = new CBilling();

                if (lsvCart.Items.Count < 1)
                {
                    MessageBox.Show("No items in selection, unable to complete transaction!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                item.BillInfoId = null;
                item.UserId = this.UserId;
                item.CustomerName = tbxCustomerName.Text;
                item.CustomerAddress = tbxAddress.Text;
                item.NoOfItemsSold = lsvCart.Items.Count;
                item.TotalAmount = Convert.ToDouble(txtGrandTotal.Text);
                item.SaveBillInfo();

                if (item.BillInfoId == null || item.BillInfoId == "0")
                {
                    MessageBox.Show("Failed to save data!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result = true;// means success
                foreach (ListViewItem listItems in lsvCart.Items)
                {
                    item.ItemNumber = listItems.SubItems[0].Text;
                    item.ItemName = listItems.SubItems[1].Text;
                    item.MCategory = listItems.SubItems[2].Text;
                    item.SCategory = listItems.SubItems[3].Text;
                    item.Description = listItems.SubItems[4].Text;
                    item.Price = Convert.ToDouble(listItems.SubItems[5].Text);
                    item.Quantity = Convert.ToInt32(listItems.SubItems[6].Text);
                    item.TotalPrice = Convert.ToDouble(listItems.SubItems[7].Text);
                    item.UserId = this.UserId;

                    if (!item.SaveBill())
                    {
                        result = false;
                        break;
                    }
                }

                if (!result)
                {
                    MessageBox.Show("Failed to save data!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Data successfully saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvCart.Items.Clear();
                txtGrandTotal.Text = "0.00";
                tbxTaxPayable.Text = "0.00";
                tbxNetSales.Text = "0.00";
                btnPrint.Enabled = false;

                txtNumber.Text = "";
                txtName.Text = "";
                txtCategory.Text = "";
                txtDesc.Text = ""; ;
                txtPrice.Text = "";
                txtStock.Text = "";
                pictureBox.BackgroundImage = global::PRJCLUMS.Properties.Resources.buttonsearchbook;

                CBilling cbilling = new CBilling();
                tbxBillNo.Text = (cbilling.GetLatestBillNo()).ToString("00000");
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Removing an item to be sold.");
                    string idremd = lsvCart.FocusedItem.SubItems[0].Text.ToString();
                    int quan = Convert.ToInt32(lsvCart.FocusedItem.SubItems[6].Text);
                    int stokk = Convert.ToInt32(cdb.GetData("SELECT Stock FROM `dbclums`.`tblitem`WHERE ItemNumber='" + idremd + "';"));
                    int itemSold = Convert.ToInt32(cdb.GetData("SELECT NoOfItemSold FROM `dbclums`.`tblitem`WHERE ItemNumber='" + idremd + "';"));
                    cdb.ExecuteSql("UPDATE tblitem SET Stock=" + (stokk + quan) + ", NoOfItemSold="+(itemSold - quan)+" WHERE(ItemNumber='" + idremd + "');");

                    txtGrandTotal.Text = (Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(lsvCart.FocusedItem.SubItems[7].Text)).ToString("#,###,###0.00");
                    tbxNetSales.Text = (Convert.ToDouble(txtGrandTotal.Text) / 1.12).ToString("###,##0.00");
                    tbxTaxPayable.Text = (Convert.ToDouble(txtGrandTotal.Text) - (Convert.ToDouble(txtGrandTotal.Text) / 1.12)).ToString("###,##0.00");

                    lsvCart.Items.Remove(lsvCart.FocusedItem);

                    if (lsvCart.Items.Count > 0) this.btnPrint.Enabled = true;
                    else this.btnPrint.Enabled = false;

                    txtNumber.Text = "";
                    txtName.Text = "";
                    txtCategory.Text = "";
                    txtDesc.Text = ""; ;
                    txtPrice.Text = "";
                    txtStock.Text = "";
                    pictureBox.BackgroundImage = global::PRJCLUMS.Properties.Resources.buttonsearchbook;

                    cdb.Populate(lsvItems, "SELECT * FROM `dbclums`.`tblitem` WHERE(Status='Active');");
                    cdb.ShowCountData(lblDataItems);
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
