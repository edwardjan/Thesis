using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    class CCategory
    {
        private int ID;
        private string Name;
        private string Desc;
        private string Stat;
        public CCategory(int ID, string Name, string Desc, string Stat)
        {
            setID(ID);
            setName(Name);
            setDesc(Desc);
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
        public string getStat()
        {
            return this.Stat;
        }
        public bool Save(bool IsEdit)
        {
            bool RetValue= false;
            CDBProvider cdb = new CDBProvider();
            if (cdb.AddCategory(getID(), getName(), getDesc(), getStat(), IsEdit))
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
