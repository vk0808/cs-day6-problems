using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Prime
    {
        public static void FindPrime()
        {

            Console.WriteLine("Finding prime numbers\n");

            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int num = rand.Next(0, 1001);

            int is_Prime = 1;

            for (int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    is_Prime = 0;
                }
            }

            if (is_Prime == 0)
            {
                Console.WriteLine(num + " is not a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a prime number");
            }
        }
    }
}
