using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Section1_Question1
    {
        static void Main(string[] args)
        { 
            int n = 100;  // change variable here
            int[] arr = new int[20000];
            int l = 1;
            int temp = 0;
            arr[0] = 1;

            for (int i = 2; i <= n; i++)
            { 
                for (int j = 0; j < l; j++)
                {
                    int k = temp + i * arr[j];
                    arr[j] = k % 10;
                    temp = k / 10; 
                }
                 
                while (temp > 0)
                {
                    arr[l++] = temp % 10;
                    temp = temp / 10;
                }
            }

            int sum = 0;

            for (int i = l - 1; i > -1; i--)
            {
                Console.Write(arr[i]);
                sum += arr[i];
            }

            Console.WriteLine("\n\nSum of digits : " + sum);
        }
    }
}
