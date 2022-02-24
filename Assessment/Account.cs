using System;

namespace Assessment
{
    public class Account
    {
        private static string[] listOfAccount = { "", "", "" };

        protected string ID;
        protected string NAME;
        protected double BALANCE;
        protected int Position;

        public string pID { get => ID; set => ID = value; }

        public string pNAME { get => NAME; set => NAME = value; }

        public double pBALANCE { get => BALANCE; set => BALANCE = value; }

        public int pPosition { get => Position; set => Position = value; }

        public Account()
        {

        }

        public Account(string id)
        {
            for (int i = 0; i < listOfAccount.Length; i++)
            {
                string[] account = listOfAccount[i].Split('|');
                if (account[0] == id)
                {
                    ID = account[0];
                    NAME = account[1];
                    BALANCE = Convert.ToDouble(account[2]);
                    Position = i;

                    return;
                }
            }

            ID = string.Empty;
        }

        public bool isExists()
        {
            if (ID == string.Empty)
            {
                return false;
            }
            else return true;
        }

        public void saveNewAccount()
        {
            for (int i = 0; i < listOfAccount.Length; i++)
            {
                if (listOfAccount[i] == "")
                {
                    listOfAccount[i] = ID + "|" + NAME + "|" + BALANCE;
                    return;
                }
            }
        }

        public void deposit(double amount)
        {
            BALANCE += amount;
            updateAccount();
        }

        public void withdraw(double amount)
        {
            BALANCE -= amount;
            updateAccount();
        }

        public void updateAccount()
        {
            listOfAccount[Position] = ID + "|" + NAME + "|" + BALANCE;
        }

        public string getInfo()
        {
            return NAME + "'s account. Balance: " + BALANCE;
        }
    }
}
