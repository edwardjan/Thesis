using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    class CSubCategory
    {
        private int ID;
        private string Name;
        private string Desc;
        private string MainCat;
        private string Stat;
        public CSubCategory(int ID, string Name, string Desc, string MainCat, string Stat)
        {
            setID(ID);
            setName(Name);
            setDesc(Desc);
            setMainCat(MainCat);
            setStat(Stat);
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setDesc(string Desc)
        {
            this.Desc = Desc;
        }
        public void setMainCat(string MainCat)
        {
            this.MainCat = MainCat;
        }
        public void setStat(string Stat)
        {
            this.Stat = Stat;
        }
        public int getID()
        {
            return this.ID;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getDesc()
        {
            return this.Desc;
        }
        public string getMainCat()
        {
            return this.MainCat;
        }
        public string getStat()
        {
            return this.Stat;
        }
        public bool Save(bool IsEdit)
        {
            bool RetValue = false;
            CDBProvider cdb = new CDBProvider();
            if (cdb.AddSubCategory(getID(), getName(), getDesc(), getMainCat(), getStat(), IsEdit))
            {
                MessageBox.Show("Data successfully saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RetValue = true;
            }
            else
            {
                MessageBox.Show("Failed to save data!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RetValue;
        }
    }
}
