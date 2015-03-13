using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PRJCLUMS
{
    class CBilling
    {
        private MySqlConnection Con = null;
        private MySqlCommand Cmd = null;
        private MySqlDataReader Reader = null;

        // for Billing Info Table
        public string BillInfoId { get; set; }
        public string UserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int NoOfItemsSold { get; set; }
        public double TotalAmount { get; set; }

        // for Billing Table
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string MCategory { get; set; }
        public string SCategory { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    

        public CBilling()
        {
        }

        public string SaveBillInfo(bool IsEdit = false)
        {
            CDBProvider cdb = new CDBProvider();

            BillInfoId = cdb.AddBillInfo(UserId, CustomerName, CustomerAddress, NoOfItemsSold, TotalAmount, BillInfoId).ToString();
            return BillInfoId;
        }

        public bool SaveBill(bool IsEdit = false)
        {
            CDBProvider cdb = new CDBProvider();
            return cdb.AddBill(BillInfoId, ItemNumber, ItemName, MCategory, SCategory, Description, Price, Quantity, TotalPrice, IsEdit);
        }

        public long GetLatestBillNo()
        {
            long retValue = 0;
            CDBProvider cdb = new CDBProvider();

            Con = new MySqlConnection(cdb.ConnectionString());
            Cmd = new MySqlCommand("SELECT ID FROM tblbillinginfo ORDER BY ID DESC LIMIT 1", Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
               if (Reader.Read())
                    retValue = Convert.ToInt64(Reader.GetValue(0)) + 1;
                Con.Close();
                Con.Dispose();
            }
            catch (Exception e)
            {
                return retValue;
            }

            return retValue;
        }

        public CBilling GetBill(string BillNo) 
        {
            string retValue = "";
            CDBProvider cdb = new CDBProvider();

            Con = new MySqlConnection(cdb.ConnectionString());
            Cmd = new MySqlCommand(string.Format("SELECT CustomerName, CustomerAddress, TotalItemsSold, TotalDue FROM tblbillinginfo WHERE ID={0}", BillNo), Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
              
                if (Reader.Read())
                {
                    retValue = Reader.GetValue(0).ToString();
                    this.CustomerName = Reader.GetValue(0).ToString();
                    this.CustomerAddress = Reader.GetValue(1).ToString();
                    this.NoOfItemsSold = Convert.ToInt32(Reader.GetValue(2));
                    this.TotalAmount = Convert.ToDouble(Reader.GetValue(3));
                }
                Con.Close();
                Con.Dispose();
            }
            catch (Exception e)
            {
                return null;
            }
            
            return this;
        }
    }
}
