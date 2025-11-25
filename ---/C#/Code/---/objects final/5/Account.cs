using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Account
    {

        int num; string id; double balance; bool isActive;

        public Account(int num=0, string id="")
        {
            SetNum(num);
            SetId(id);
        }
        #region setget
        public int GetNum() { return num; }
        public void SetNum(int v) { num = v; }

        public string GetId() { return id; }
        public void SetId(string v) { id = v; }

        public double GetBalance() { return balance; }
        public void SetBalance(double v) { balance = v; }

        public bool GetIsActive() { return isActive; }
        public void SetIsActive(bool v) { isActive = v; }
        #endregion


    }
}
