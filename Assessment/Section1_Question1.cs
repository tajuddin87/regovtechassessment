﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Section1_Question1
    {
        static void Main(string[] args)
        {
            int n = 100; // change variable here
            System.Numerics.BigInteger nmultiple = 1;
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
        }
    }
}
