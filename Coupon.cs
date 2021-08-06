using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Coupon
    {
        public static void CheckCoupon()
        {

            int RANGE = 100;
            int flag = 0;
            
            Random rand = new Random();

            Console.WriteLine("Find no of RN need to generate a distinct coupon number\n");
            Console.WriteLine("Enter no of coupon you want to check");
            int len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            Console.WriteLine("Enter distinct coupon numbers line by line");
            for (int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in array)
            {
                double count = 0;
                while (flag == 0)
                {
                    int newNumber = rand.Next(RANGE);
                    //Console.WriteLine(i + " " + newNumber);
                    if (newNumber == i)
                    {
                        flag = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine("Coupon no " + i + " was generated at " + count);

                flag = 0;
            }
        }
    }
}
