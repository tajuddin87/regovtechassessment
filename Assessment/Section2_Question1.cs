using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Section2_Question1
    {
        public Section2_Question1()
        {
            Account newAcc1 = new Account();
            newAcc1.pID = "10";
            newAcc1.pNAME = "tajuddin1";
            newAcc1.pBALANCE = 100;
            newAcc1.saveNewAccount();

            Account newAcc2 = new Account();
            newAcc2.pID = "20";
            newAcc2.pNAME = "tajuddin2";
            newAcc2.pBALANCE = 200;
            newAcc2.saveNewAccount();

            Account newAcc3 = new Account();
            newAcc3.pID = "30";
            newAcc3.pNAME = "tajuddin3";
            newAcc3.pBALANCE = 300;
            newAcc3.saveNewAccount();

            Account theAcc1 = new Account("10");
            if (theAcc1.isExists())
            {
                theAcc1.deposit(50);
                theAcc1.withdraw(10);
                Console.WriteLine(theAcc1.getInfo());
            }

            Account theAcc2 = new Account("20");
            if (theAcc2.isExists())
            {
                theAcc2.deposit(10);
                theAcc2.withdraw(60);
                Console.WriteLine(theAcc2.getInfo());
            }

            Account theAcc3 = new Account("30");
            if (theAcc3.isExists())
            {
                theAcc3.deposit(50);
                theAcc3.withdraw(100);
                Console.WriteLine(theAcc3.getInfo());
            }
        }
    }
}
