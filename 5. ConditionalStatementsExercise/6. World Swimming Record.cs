﻿using System;

namespace _6._2_Swimming_World_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;

            double recordByIvan = distance * timePerMeter + delay;

            if(recordByIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {recordByIvan - worldRecord:f2} seconds slower.");
            }
        }
    }
}
