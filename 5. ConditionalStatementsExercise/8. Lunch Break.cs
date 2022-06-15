using System;

namespace _8._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double lunch = c * 1 / 8;
            double rest = c * 1 / 4;
            double time_left = c - lunch - rest;
            double d = b - time_left;

            if (time_left >= b)
            {
                d = time_left - b;
                Console.WriteLine("You have enough time to watch " + a + " and left with " + Math.Ceiling(d) + " minutes free time.");
            }
            else
            {
                Console.WriteLine("You don't have enough time to watch " + a + ", you need " + Math.Ceiling(d) + " more minutes.");
            }
        }
    }
}
