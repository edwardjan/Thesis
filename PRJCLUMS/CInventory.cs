using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    class CInventory
    {
        private int No;
        private string Name;
        private string MCategory;
        private string SCategory;
        private string Desc;
        private double Price;
        private int Stock;
        private int NoOfItemsSold;
        private string Date;
        private string Image;
        private string Status;
        public CInventory(int No, string Name, string MCategory, string SCategory, string Desc, double Price, int Stock, int NoOfItemsSold, string Date, string Image, string Status)
        {
            setNo(No);
            setName(Name);
            setMCategory(MCategory);
            setSCategory(SCategory);
            setDesc(Desc);
            setPrice(Price);
            setStock(Stock);
            setNoOfItemsSold(NoOfItemsSold);
            setDate(Date);
            setImage(Image);
            setStatus(Status);
        }
        public void setNo(int No)
        {
            this.No = No;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setMCategory(string MCategory)
        {
            this.MCategory = MCategory;
        }
        public void setSCategory(string SCategory)
        {
            this.SCategory = SCategory;
        }
        public void setDesc(string Desc)
        {
            this.Desc = Desc;
        }
        public void setPrice(double Price)
        {
            this.Price = Price;
        }
        public void setStock(int Stock)
        {
            this.Stock = Stock;
        }
        public void setNoOfItemsSold(int NoOfItemsSold)
        {
            this.NoOfItemsSold = NoOfItemsSold;
        }
        public void setDate(string Date)
        {
            this.Date = Date;
        }
        public void setImage(string Image)
        {
            this.Image = Image;
        }
        public void setStatus(string Status)
        {
            this.Status = Status;
        }
        public int getNo()
        {
            return this.No;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getMCategory()
        {
            return this.MCategory;
        }
        public string getSCategory()
        {
            return this.SCategory;
        }
        public string getDesc()
        {
            return this.Desc;
        }
        public double getPrice()
        {
            return this.Price;
        }
        public int getStock()
        {
            return this.Stock;
        }
        public int getNoOfItemsSold()
        {
            return this.NoOfItemsSold;
        }
        public string getDate()
        {
            return this.Date;
        }
        public string getImage()
        {
            return this.Image;
        }
        public string getStatus()
        {
            return this.Status;
        }
        public bool Save(bool IsEdit)
        {
            bool RetValue= false;
            CDBProvider cdb = new CDBProvider();
            if (cdb.AddInventory(getNo(), getName(), getMCategory(), getSCategory(), getDesc(), getPrice(), getStock(), getNoOfItemsSold(), getDate(), getImage(), getStatus(), IsEdit))
            {
                MessageBox.Show("Data successfully saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RetValue = true;
            }

            return RetValue;
        }
    }
}
