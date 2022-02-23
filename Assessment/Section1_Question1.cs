using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Section1_Question1
    {
        static void Main(string[] args)
        {
            int n = 10; // change variable here
            int nmultiple = 1;
            int sum = 0;

            for (int i = n; i > 0; i--)
            {
                nmultiple = nmultiple * i;
            }

            Console.WriteLine(nmultiple.ToString());

            for (int i = 0; i < nmultiple.ToString().Length; i++)
            {
                int digit = Convert.ToInt32(nmultiple.ToString().Substring(i, 1));
                sum += digit;
                Console.WriteLine(digit);
            }

            Console.WriteLine("Sum of digits : " + sum.ToString());

            Account acc1 = new Account("870701A", "tajuddin1", 1000);
            //Account acc2 = new Account("870701B", "tajuddin2", 2000);
            //Account acc3 = new Account("870701C", "tajuddin3", 3000);

            acc1.deposit("870701A", 100);
            //acc2.deposit("870701B", 200);
            //acc3.deposit("870701C", 300);

            acc1.withdraw("870701A", 500);
            //acc2.withdraw("870701B", 600);
            //acc3.withdraw("870701C", 700);

            Console.WriteLine(acc1.getInfo("870701A"));
            //Console.WriteLine(acc2.getInfo("870701A"));
            //Console.WriteLine(acc3.getInfo("870701A"));
        }
    }
}
