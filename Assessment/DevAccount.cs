using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class DevAccount : Account
    {
        public DevAccount()
        {

        }

        public DevAccount(string id, string name, double balance)
        {
            for (int i = 0; i < accountAllocation; i++)
            {
                if (listOfAccount[i] == "")
                {
                    listOfAccount[i] = id + "|" + name + "|" + balance;
                    return;
                }
            }
        }

        public double getBalance(string id)
        {
            string[] account = getSpecifiedAccountInfo(id).Split('|');
            return Convert.ToDouble(account[2]);
        }

        public void setBalance(string id, double balance)
        {
            string[] account = getSpecifiedAccountInfo(id).Split('|');
            string name = account[1];

            listOfAccount[position] = id + "|" + name + "|" + balance;
        }

        public void transfer(string idFrom, string idTo, double amount)
        {
            withdraw(idFrom, amount);
            deposit(idTo, amount);
        }
    }
}
