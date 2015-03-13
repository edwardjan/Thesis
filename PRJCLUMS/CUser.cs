using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    class CUser
    {
        private int ID;
        private string User;
        private string Pass;
        private string Type;
        private string Status;
        public CUser(int ID, string User, string Pass, string Type, string Status)
        {
            setID(ID);
            setUser(User);
            setPass(Pass);
            setType(Type);
            setStatus(Status);
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public void setUser(string User)
        {
            this.User = User;
        }
        public void setPass(string Pass)
        {
            this.Pass = Pass;
        }
        public void setType(string Type)
        {
            this.Type = Type;
        }
        public void setStatus(string Status)
        {
            this.Status = Status;
        }
        public int getID()
        {
            return this.ID;
        }
        public string getUser()
        {
            return this.User;
        }
        public string getPass()
        {
            return this.Pass;
        }
        public string getType()
        {
            return this.Type;
        }
        public string getStatus()
        {
            return this.Status;
        }
        public bool Save(bool IsEdit)
        {
            bool RetValue = false;
            CDBProvider cdb = new CDBProvider();
            if (cdb.AddUser(getID(), getUser(), getPass(), getType(), getStatus(), IsEdit))
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
