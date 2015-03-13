using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRJCLUMS
{
    class CDBProvider
    {
        public MySqlConnection Con = null;
        public MySqlCommand Cmd = null;
        public MySqlDataReader Reader = null;
        public int NoData = 0;
        public string ErrorMsg = "";
        public string ConnectionString()
        {
            return "server=localhost;database=dbclums;username=root;password=root;";
        }
        public void ShowErrorMsg()
        {
            MessageBox.Show(ErrorMsg, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowCountData(Label Lbl)
        {
            Lbl.Text = "Data: " + this.NoData;
        }
        
        public bool Populate(ListView Lsv, string Qry, bool ClearItems = true)
        {
            bool retValue = false;

            if (ClearItems)
                Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        Lst.SubItems.Add(Reader.GetValue(x).ToString());
                    }
                    Lsv.Items.Add(Lst);
                    NoData++;
                }
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }

        public bool PopulateItems(ListView Lsv, string Qry, bool ClearItems = true)
        {
            bool retValue = false;

            if (ClearItems)
                Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        string dummy = Reader.GetValue(x).ToString();
                        Lst.SubItems.Add(Reader.GetValue(x).ToString());
                    }
                    Lsv.Items.Add(Lst);
                    NoData++;
                }
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }

        public bool PopulateDailWeeklyReports(ListView Lsv, string Qry, bool ClearItems = true)
        {
            bool retValue = false;

            if (ClearItems)
                Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                Double TotalDue = 0.0;
                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        string temp = Reader.GetValue(x).ToString();
                        Lst.SubItems.Add(Reader.GetValue(x).ToString());
                        
                    }
                    Lsv.Items.Add(Lst);
                    TotalDue += (Convert.ToDouble(Reader.GetValue(8)));
                    NoData++;
                }

                if (Lsv.Items.Count > 0)
                {

                    // Compute 12% TAX.
                    string NetSales = (TotalDue / 1.12).ToString("###,##0.00") + " PHP";
                    string TaxPayable = (TotalDue - (TotalDue / 1.12)).ToString("###,##0.00") + " PHP";
                    string TotalSales = TotalDue.ToString("###,##0.00") + " PHP";

                    ListViewItem footer = new ListViewItem(new string[] { "", "", "", "", "", "", "", "=======", "==========", "" });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "", "", "", "", "Net Sales:", NetSales, "" });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "", "", "", "", "Tax Payable (12%):", TaxPayable, "" });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "", "", "", "", "Total Sales:", TotalSales, "" });
                    Lsv.Items.Add(footer);
                }

                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }

        public bool PopulateMonthyReports(ListView Lsv, string Qry, bool ClearItems = true)
        {
            bool retValue = false;

            if (ClearItems)
                Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                Double TotalDue = 0.0;
                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        string temp = Reader.GetValue(x).ToString();
                        Lst.SubItems.Add(Reader.GetValue(x).ToString());

                    }
                    Lsv.Items.Add(Lst);
                    TotalDue += (Convert.ToDouble(Reader.GetValue(4)));
                    NoData++;
                }

                if (Lsv.Items.Count > 0)
                {
                    // Compute 12% TAX.
                    string NetSales = (TotalDue / 1.12).ToString("###,##0.00") + " PHP";
                    string TaxPayable = (TotalDue - (TotalDue / 1.12)).ToString("###,##0.00") + " PHP";
                    string TotalSales = TotalDue.ToString("###,##0.00") + " PHP";

                    ListViewItem footer = new ListViewItem(new string[] { "", "", "", "=======", "==========" });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "Net Sales:", NetSales });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "Tax Payable (12%):", TaxPayable });
                    Lsv.Items.Add(footer);
                    footer = new ListViewItem(new string[] { "", "", "", "Total Sales:", TotalSales });
                    Lsv.Items.Add(footer);
                }

                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }

        public bool PopulateYearlyReports(ListView Lsv, string Qry, ref Double TotalAmount ,bool ClearItems = true)
        {
            bool retValue = false;

            if (ClearItems)
                Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        string temp = Reader.GetValue(x).ToString();
                        Lst.SubItems.Add(Reader.GetValue(x).ToString());

                    }
                    Lsv.Items.Add(Lst);
                    TotalAmount += (Convert.ToDouble(Reader.GetValue(2)));
                    NoData++;
                }

                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }

        public bool PopulatePassword(ListView Lsv, String Qry)
        {
            bool RetValue = false;
            Lsv.Items.Clear();
            NoData = 0;

            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ListViewItem Lst = new ListViewItem(Reader.GetValue(0).ToString());
                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        if (x == 2)
                            Lst.SubItems.Add(Decrypt(Reader.GetValue(x).ToString()));
                        else
                            Lst.SubItems.Add(Reader.GetValue(x).ToString());
                    }
                    Lsv.Items.Add(Lst);
                    NoData++;
                }
                Con.Close();
                Con.Dispose();
                RetValue = true;
            }
            catch (Exception e)
            {
                RetValue = false;
                this.ErrorMsg = e.Message;
                MessageBox.Show(this.ErrorMsg);
            }
            return RetValue;
        }
        public bool AddInventory(int No, string Name, string MCategory, string SCategory, string Desc, double Price, int Stock, int NoOfItemSold, string Date, string Image, string Status, Boolean IsEdit)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tblitem VALUES(NULL,@ItemName,@MCategory,@SCategory,@Description,@Price,@Stock, @NoOfItemSold,@DateAdded,@Image,@Status);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tblitem SET ItemName=@ItemName,MainCategory=@MCategory,SubCategory=@SCategory,Description=@Description,Price=@Price,Stock=@Stock,NoOfItemSold=@NoOfItemSold,Image=@Image,Status=@Status WHERE(ItemNumber=@ItemNumber);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@ItemNumber", No));
            Cmd.Parameters.Add(new MySqlParameter("@ItemName", Name));
            Cmd.Parameters.Add(new MySqlParameter("@MCategory", MCategory));
            Cmd.Parameters.Add(new MySqlParameter("@SCategory", SCategory));
            Cmd.Parameters.Add(new MySqlParameter("@Description", Desc));
            Cmd.Parameters.Add(new MySqlParameter("@Price", Price));
            Cmd.Parameters.Add(new MySqlParameter("@Stock", Stock));
            Cmd.Parameters.Add(new MySqlParameter("@NoOfItemSold", NoOfItemSold));
            Cmd.Parameters.Add(new MySqlParameter("@DateAdded", Date));
            Cmd.Parameters.Add(new MySqlParameter("@Image", Image));
            Cmd.Parameters.Add(new MySqlParameter("@Status", Status));
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                Logger.Logger.Log(e.Message + e.StackTrace);
                ShowErrorMsg();
            }
            return retValue;
        }

        /// <summary>
        /// Returns Bill Info Number
        /// </summary>
        public int AddBillInfo(string UserId, string CustomerName, string CustomerAddress, int NoOfItemsSold, double TotalAmount, string BillNumber = null, Boolean IsEdit = false)
        {
            int billInfoNumber = 0;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tblbillinginfo VALUES(@Id, @UserId,@CustomerName,@CustomerAddress,@TotalItemsSold,@TotalDue,@BillDate);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tblbillinginfo SET UserId=@UserId,CustomerName=@CustomerName,CustomerAddress=@CustomerAddress,TotalItemsSold=@TotalItemsSold,TotalDue=@TotalDue WHERE(Id=@BillNumber);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@Id", BillNumber));
            Cmd.Parameters.Add(new MySqlParameter("@UserId", UserId));
            Cmd.Parameters.Add(new MySqlParameter("@CustomerName", CustomerName));
            Cmd.Parameters.Add(new MySqlParameter("@CustomerAddress", CustomerAddress));
            Cmd.Parameters.Add(new MySqlParameter("@TotalItemsSold", NoOfItemsSold));
            Cmd.Parameters.Add(new MySqlParameter("@TotalDue", TotalAmount));
            Cmd.Parameters.Add(new MySqlParameter("@BillDate", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();

                if (!IsEdit)
                    billInfoNumber = Convert.ToInt32(Cmd.LastInsertedId);
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return billInfoNumber;
        }

        public bool AddBill(string BillInfoNumber, string ItemNumber, string ItemName, string MCategory, string SCategory, string Description, double Price, int Quantity, double TotalPrice, Boolean IsEdit)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tblbilling VALUES(@Id, @BillingInfoId, @ItemNumber,@ItemName,@Category,@Description,@Price,@Quantity,@TotalPrice);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tblbilling SET @BillingInfoId=BillingInfoId, ItemNumber=@newNo,ItemName=@ItemName,Category=@Category,Description=@Description,Price=@Price,Quantity=@Quantity,TotalPrice=@TotalPrice WHERE(ItemNumber=@ItemNumber);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@Id", null));
            Cmd.Parameters.Add(new MySqlParameter("@BillingInfoId", BillInfoNumber));
            Cmd.Parameters.Add(new MySqlParameter("@ItemNumber", ItemNumber));
            Cmd.Parameters.Add(new MySqlParameter("@ItemName", ItemName));
            Cmd.Parameters.Add(new MySqlParameter("@Category", MCategory + " (" + SCategory + ")"));
            Cmd.Parameters.Add(new MySqlParameter("@Description", Description));
            Cmd.Parameters.Add(new MySqlParameter("@Price", Price));
            Cmd.Parameters.Add(new MySqlParameter("@Quantity", Quantity));
            Cmd.Parameters.Add(new MySqlParameter("@TotalPrice", TotalPrice));
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
            }
            return retValue;
        }

        public bool AddCategory(int ID, string Name, string Desc, string Stat, Boolean IsEdit)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tblcategory VALUES(NULL,@Name,@Desc,@Stat);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tblcategory SET Name=@Name,Description=@Desc,Status=@Stat WHERE(ID=@ID);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@ID", ID));
            Cmd.Parameters.Add(new MySqlParameter("@Name", Name));
            Cmd.Parameters.Add(new MySqlParameter("@Desc", Desc));
            Cmd.Parameters.Add(new MySqlParameter("@Stat", Stat));
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }
        public bool AddSubCategory(int ID, string Name, string Desc, string MainCat, string Stat, Boolean IsEdit)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tblsubcategory VALUES(NULL,@Name,@Desc,@MainCat,@Stat);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tblsubcategory SET Name=@Name,Description=@Desc,MainCategory=@MainCat,Status=@Stat WHERE(ID=@ID);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@ID", ID));
            Cmd.Parameters.Add(new MySqlParameter("@Name", Name));
            Cmd.Parameters.Add(new MySqlParameter("@Desc", Desc));
            Cmd.Parameters.Add(new MySqlParameter("@MainCat", MainCat));
            Cmd.Parameters.Add(new MySqlParameter("@Stat", Stat));
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }
        public bool AddUser(int ID, string User, string Pass, string Type, string Status, Boolean IsEdit)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(@"INSERT INTO tbluser VALUES(NULL,@Username,@Password,@Usertype,@Status);", Con);
            if (IsEdit)
            {
                Cmd = new MySqlCommand(@"UPDATE tbluser SET Username=@Username,Password=@Password,Usertype=@Usertype,Status=@Status WHERE(ID=@ID);", Con);
            }
            Cmd.Parameters.Add(new MySqlParameter("@ID", ID));
            Cmd.Parameters.Add(new MySqlParameter("@Username", User));
            Cmd.Parameters.Add(new MySqlParameter("@Password", Pass));
            Cmd.Parameters.Add(new MySqlParameter("@Usertype", Type));
            Cmd.Parameters.Add(new MySqlParameter("@Status", Status));
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }
        public string GetData(string Qry)
        {
            string retValue = "";
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    retValue = Reader.GetValue(0).ToString();
                }
                Con.Close();
                Con.Dispose();
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
            }
            return retValue;
        }
        public bool ExecuteSql(string Sql)
        {
            Boolean retValue = false;
            Con = new MySqlConnection(ConnectionString());
            Cmd = new MySqlCommand(Sql, Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                this.ErrorMsg = e.Message;
                Logger.Logger.Log(this.ErrorMsg);
                ShowErrorMsg();
            }
            return retValue;
        }
        public bool LogInUser(String Username, String Password)
        {
            Boolean retValue = false;
            try
            {
                Con = new MySqlConnection(ConnectionString());
                Cmd = new MySqlCommand("SELECT * FROM tbluser WHERE(Username=@Username AND Password=@Password AND Status='Active');", Con);

                Cmd.Parameters.Add(new MySqlParameter("@Username", Username));
                Cmd.Parameters.Add(new MySqlParameter("@Password", Password));
                try
                {
                    Con.Open();
                    Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        retValue = true;
                    }
                    Con.Close();
                    Con.Dispose();
                }
                catch (Exception e)
                {
                    retValue = false;
                    this.ErrorMsg = e.Message;
                    ShowErrorMsg();
                }
                return retValue;
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
                return retValue;
            }
        }
        private string Decrypt(string cipherText)
        {
            try
            {
                string EncryptionKey = "MAKV2SPBNI99212";
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
                return cipherText;                  
            }
        }
    }
}
