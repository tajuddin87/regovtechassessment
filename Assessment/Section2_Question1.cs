using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Section2_Question1
    {
        public Section2_Question1()
        { 
            Account acc1 = new Account("870701A", "tajuddin1", 1000);
            Account acc2 = new Account("870701B", "tajuddin2", 2000);
            Account acc3 = new Account("870701C", "tajuddin3", 3000);

            acc1.deposit("870701A", 100);
            acc2.deposit("870701B", 200);
            acc3.deposit("870701C", 300);

            acc1.withdraw("870701A", 500);
            acc2.withdraw("870701B", 600);
            acc3.withdraw("870701C", 700);

            Console.WriteLine(acc1.getInfo("870701A"));
            Console.WriteLine(acc2.getInfo("870701B"));
            Console.WriteLine(acc3.getInfo("870701C"));
        }
    }
}
