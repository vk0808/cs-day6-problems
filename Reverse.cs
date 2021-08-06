using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Reverse
    {
        public static void FindReverse()
        {
            Console.WriteLine("Find reverse of a number\n");
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;

            int reverse = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10  + rem;
                num /= 10;
            }
            Console.WriteLine(temp + " and it's reverse " + reverse);
        }
    }
}
