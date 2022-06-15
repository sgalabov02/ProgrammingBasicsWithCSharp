using System;

namespace _2._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 180 / Math.PI;

            Console.WriteLine(b);
        }
    }
}
