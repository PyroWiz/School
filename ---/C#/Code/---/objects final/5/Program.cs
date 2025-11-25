using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Branch br1 = new Branch(1,5);
            br1.AddAccount("206857963");
            Console.WriteLine(br1.ClassToString("206857963"));
        }
        public static void moveClient(string id, Branch br1, Branch br2)
        {
            double sum = 0;
            Account[] acarr = br1.GetAccounts();
            for (int i = 0; i < br1.GetCurrent(); i++)
            {
                if (acarr[i].GetId() == id)
                {
                    acarr[i].SetIsActive(false);
                    sum += acarr[i].GetBalance();
                    acarr[i].SetBalance(0);
                }
            }
            br1.SetAccounts(acarr);
            br2.AddAccount(id, true, sum);
        }
    }
}
