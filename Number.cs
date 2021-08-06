using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Number
    {
        public static void FindPerfectNumber()
        {
            Console.WriteLine("Finding perfect number\n");

            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }

            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is a not Perfect Number");
            }
        }
    }
}
