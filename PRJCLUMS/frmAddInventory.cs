using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    public partial class frmAddInventory : Form
    {
        CDBProvider cdb = new CDBProvider();
        private int No;
        private string Name;
        private string MCategory;
        private string SCategory;
        private string Desc;
        private double Price;
        private int Stock;
        private int NoOfItemSold;
        private string Date;
        private string Image;
        private string Image2;
        private string ImagePath;
        private string Status;

        public frmAddInventory()
        {
            InitializeComponent();
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"\Pictures\";
            if (!Directory.Exists(ImagePath)) 
            {
                Directory.CreateDirectory(ImagePath);
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing add item form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void ClearTxt()
        {
            txtName.Clear();
            txtDesc.Clear();
            cbCategory.Text = "           (Select)";
            cbCategory2.Text = "           (Select)";
            txtPrice.Clear();
            txtStock.Clear();
            txtImage.Clear();
            pictureBox.Image = global::PRJCLUMS.Properties.Resources.buttonsearchbook;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("SAVE"))
            {
                ClearTxt();
            }
            else
            {
                LoadData(No, Name, MCategory, SCategory, Desc, Price, Stock, NoOfItemSold, Date, Image2, Status);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Saving new item data.");
                if (string.IsNullOrWhiteSpace(txtDesc.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text) || cbCategory.Text.Equals("           (Select)") || cbCategory2.Text.Equals("           (Select)") || string.IsNullOrWhiteSpace(txtImage.Text))
                {
                    MessageBox.Show("Please fill up all data!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (File.Exists(Image))
                {
                    pictureBox.Image = Bitmap.FromFile(Image);
                }
                else
                    this.pictureBox.Image = global::PRJCLUMS.Properties.Resources.buttonsearchbook;

                if (btnSave.Text.Equals("SAVE"))
                {
                    try
                    {
                        string nam = txtName.Text;
                        string desc = txtDesc.Text;
                        string cat = cbCategory.Text;
                        string scat = cbCategory2.Text;
                        double pri = Convert.ToDouble(txtPrice.Text);
                        int sto = Convert.ToInt16(txtStock.Text);
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + cat + "';");
                        if (compare.Equals("0"))
                        {
                            MessageBox.Show("Main category does not exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE Name='" + scat + "';");
                            if (compare.Equals("0"))
                            {
                                MessageBox.Show("Sub category does not exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblitem` WHERE ItemName='" + nam + "';");
                                if (compare.Equals("0"))
                                {
                                    CInventory cs = new CInventory(No, nam, cat, scat, desc, pri, sto, 0, DateTime.Now.ToString(), txtImage.Text, "Active");
                                    if (cs.Save(false))
                                        ClearTxt();
                                }
                                else
                                {
                                    MessageBox.Show("An item with a similar name is already in use!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            } 
                        } 
                    }
                    catch (Exception ex)
                    {
                        Logger.Logger.Log(ex.Message + ex.StackTrace);
                        MessageBox.Show("Use numbers for the price/stock!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        string nam = txtName.Text;
                        string desc = txtDesc.Text;
                        string cat = cbCategory.Text;
                        string scat = cbCategory2.Text;
                        double pri = Convert.ToDouble(txtPrice.Text);
                        int sto = Convert.ToInt16(txtStock.Text);
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + cat + "';");
                        if (compare.Equals("0"))
                        {
                            MessageBox.Show("Main category does not exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE Name='" + scat + "';");
                            if (compare.Equals("0"))
                            {
                                MessageBox.Show("Sub category does not exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblitem` WHERE ItemName='" + nam + "';");
                                if (compare.Equals("0") || nam.Equals(Name))
                                {
                                    CInventory cs = new CInventory(No, nam, cat, scat, desc, pri, sto, NoOfItemSold, DateTime.Now.ToString(), txtImage.Text, Status);
                                    cs.Save(true);
                                    frmViewItems fv = new frmViewItems();
                                    fv.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("An item with a similar name is already in use!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        public void LoadData(int No, string Name, string MCategory, string SCategory, string Desc, double Price, int Stock, int NoOfItemSold,string Date, string Image, string Status)
        {
            this.No = No;
            this.Name = Name;
            this.MCategory = MCategory;
            this.SCategory = SCategory;
            this.Desc = Desc;
            this.Price = Price;
            this.Stock = Stock;
            this.Date = Date;
            this.Image2 = Image;
            this.Status = Status;
            this.NoOfItemSold = NoOfItemSold;
            btnSave.Text = "UPDATE";
            txtName.Text = Name;
            cbCategory.Text = MCategory;
            cbCategory2.Text = SCategory;
            txtDesc.Text = Desc;
            txtPrice.Text = Price.ToString();
            txtStock.Text = Stock.ToString();
            int tee = Convert.ToInt16(cdb.GetData("SELECT MAX(ID) FROM `dbclums`.`tblsubcategory` WHERE(Status='Active') AND(MainCategory='" + cbCategory.Text + "');"));
            cbCategory2.Items.Clear();
            for (int x = 0; x <= tee; x++)
            {
                string data = cdb.GetData("SELECT Name FROM `dbclums`.`tblsubcategory` WHERE(ID=" + x + ") AND (Status='Active');");
                if (data != "" && !cbCategory2.Items.Contains(data))
                {
                    cbCategory2.Items.Add(data);
                }
            }
            
            if (File.Exists(ImagePath + Image2))
                pictureBox.Image = Bitmap.FromFile(ImagePath + Image2);
            else
                this.pictureBox.Image = global::PRJCLUMS.Properties.Resources.buttonsearchbook;

            txtImage.Text = Image.Substring(Image.LastIndexOf("\\") + 1);
        }

        private void frmAddInventory_Load(object sender, EventArgs e)
        {
            int tee = Convert.ToInt16(cdb.GetData("SELECT MAX(ID) FROM `dbclums`.`tblcategory` WHERE(Status='Active');"));
            for (int x = 0; x <= tee; x++)
            {
                string data = cdb.GetData("SELECT Name FROM `dbclums`.`tblcategory` WHERE(ID=" + x + ") AND (Status='Active');");
                if (data != "")
                {
                    cbCategory.Items.Add(data);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Bitmap.FromFile(open.FileName);
                Image = open.FileName;

                string itemName = Image.Substring(Image.LastIndexOf(@"\") + 1);
                itemName = ImagePath + "\\" + itemName;

                txtImage.Text = Image.Substring(Image.LastIndexOf(@"\") + 1);
                if(File.Exists(itemName))
                {
                }
                else
                {
                    File.Copy(Image, itemName, true);
                }
            }
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            try
            {
                int tee = Convert.ToInt16(cdb.GetData("SELECT MAX(ID) FROM `dbclums`.`tblsubcategory` WHERE(Status='Active') AND(MainCategory='" + cbCategory.Text + "');"));
                cbCategory2.Items.Clear();
                cbCategory2.Text = "           (Select)";
                for (int x = 0; x <= tee; x++)
                {
                    string data = cdb.GetData("SELECT Name FROM `dbclums`.`tblsubcategory` WHERE(ID=" + x + ") AND (Status='Active') AND(MainCategory='" + cbCategory.Text + "');");
                    if (data != "" && !cbCategory2.Items.Contains(data))
                    {
                        cbCategory2.Items.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
