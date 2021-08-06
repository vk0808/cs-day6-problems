using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Fibonacci
    {
        public static void FibonacciSeries()
        {
            int first = 0;
            int second = 1;

            int fib = 0;

            Console.WriteLine("Finding Fibonacci Series\n");

            Console.WriteLine("Enter no of terms in series");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 1; i <= num-2; i++)
            {
                fib = first + second;
                first = second;
                second = fib;
                Console.WriteLine(fib);
            }
        }
    }
}
