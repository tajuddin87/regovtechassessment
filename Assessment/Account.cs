using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Account
    {
        protected const int accountAllocation = 30;
        protected string[] listOfAccount = { "", "", "" };
        protected int position;

        public Account()
        {

        }

        public Account(string id, string name, double balance)
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

        public void deposit(string id, double amount)
        {
            string[] account = getSpecifiedAccountInfo(id).Split('|');
            string name = account[1];
            double balance = Convert.ToInt32(account[2]);

            balance += amount;

            listOfAccount[position] = id + "|" + name + "|" + balance;
        }

        public void withdraw(string id, double amount)
        {
            string[] account = getSpecifiedAccountInfo(id).Split('|');
            string name = account[1];
            double balance = Convert.ToInt32(account[2]);

            balance -= amount;

            listOfAccount[position] = id + "|" + name + "|" + balance;
        }

        public string getInfo(string id)
        {
            string[] account = getSpecifiedAccountInfo(id).Split('|');
            string name = account[1];
            double balance = Convert.ToInt32(account[2]);

            return name + "'s account. Balance: " + balance;
        }

        public string getSpecifiedAccountInfo(string id)
        {
            string returnedAccount = string.Empty;
            for (int i = 0; i < accountAllocation; i++)
            {
                if (listOfAccount[i] != "")
                {
                    string[] account = listOfAccount[i].Split('|');
                    if (account[0] == id)
                    {
                        position = i;
                        returnedAccount = listOfAccount[i];
                        goto endsFunction;
                    }
                }
            }

        endsFunction:
            return returnedAccount;
        }
    }
}
