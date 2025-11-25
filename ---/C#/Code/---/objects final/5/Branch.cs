using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Branch
    {
        private static readonly Random rng = new Random();
        int branchNum; Account[] accounts = new Account[0]; int current; int maxAccount;

        public Branch(int branchNum, int maxAccount)
        {
            SetBranchNum(branchNum);
            SetMaxAccount(maxAccount);
            Account[] arr = new Account[maxAccount];
            SetAccounts(arr);
            SetCurrent(0);
        }
        #region setget
        public int GetBranchNum() { return branchNum; }
        public void SetBranchNum(int v) { branchNum = v; }

        public Account[] GetAccounts() { return accounts; }
        public void SetAccounts(Account[] arr) { accounts = arr; }

        public int GetCurrent() { return current; }
        public void SetCurrent(int v) { current = v; }

        public int GetMaxAccount() { return maxAccount; }
        public void SetMaxAccount(int v) { maxAccount = v; }
        #endregion

        public int GenerateNum()
        {
            int num = 0;
            bool check = true;
            do
            {
                num = rng.Next(1000, 10000);
                int count = 0;

                for (int i = 0; i < current-1; i++)
                {
                    if (accounts[i].GetNum() == num)
                    {
                        count++;
                    }
                }
                if (count == 0) check = false;
            } while (check);
            return num;
        }

        public void AddAccount(string id, bool trans = false, double sum = 0)
        {
            if (current >= maxAccount)
            {
                Account[] arr = new Account[current + 1];
                for (int i = 0; i < current; i++)
                {
                    arr[i] = accounts[i];
                }
                accounts = arr;
            }
            current++; maxAccount++;
            accounts[current - 1] = new Account(GenerateNum(),id);
            Console.WriteLine("enter id");
            accounts[current - 1].SetId(id);
            accounts[current - 1].SetIsActive(true);
            if (trans)
            {
                accounts[current - 1].SetBalance(sum);
            }
            else
            {
                bool check = true;
                for (int i = 0; i < current-1; i++)
                {
                    if (accounts[i].GetId() == id)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    accounts[current - 1].SetBalance(500);
                }
                else accounts[current - 1].SetBalance(100);
            }
        }

        public string ClassToString(string id)
        {
            string s = "";
            for (int i = 0; i < GetCurrent(); i++)
            {
                if (accounts[i].GetId() == id)
                {
                    s += $"\nbalance: {accounts[i].GetBalance()}\nacc number: {accounts[i].GetNum()}";
                }
            }
            return s;
        }
    }
}
