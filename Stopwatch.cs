using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Problems
{
    class Stopwatch
    {

        static void GetTimer()
        {
            DateTime startTime, endTime;


            Console.WriteLine("Press enter key to start");
            string start = Console.ReadLine();
            startTime = DateTime.UtcNow;


            Console.WriteLine("Press enter key to stop");
            string stop = Console.ReadLine();
            endTime = DateTime.UtcNow;


            TimeSpan elapsedTime = endTime - startTime;


            string hours = elapsedTime.ToString("%h") + " hours ";
            string mins = elapsedTime.ToString("%m") + " mins ";
            string seconds = elapsedTime.ToString("%s") + " seconds ";
            string miliseconds = elapsedTime.ToString("%fff") + " miliseconds";


            string msg = "Elapsed time: " + hours + mins + seconds + miliseconds;
            Console.WriteLine(msg);
        }
        public static void Timer()
        {
            Console.WriteLine("Simualting Stopwatch Program\n");
            int choice = 1;

            while (choice != 0)
            {

                GetTimer();
                Console.WriteLine("\nPress 1: use Timer again, 0: quit");
                choice = int.Parse(Console.ReadLine());
            }

        }
    }
}
