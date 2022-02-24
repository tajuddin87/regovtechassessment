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

        public DevAccount(string id) : base(id)
        {

        }

        public double getBalance()
        {
            return BALANCE;
        }

        public void setBalance(double balance)
        {
            BALANCE = balance;
            updateAccount();
        }

        public void transfer(string idTo, double amount)
        {
            BALANCE -= amount;
            updateAccount();

            Account recepient = new Account(idTo);
            if (recepient.isExists())
            {
                recepient.pBALANCE += amount;
                recepient.updateAccount();
            }
            else throw new Exception("account not found");
        }
    }
}
