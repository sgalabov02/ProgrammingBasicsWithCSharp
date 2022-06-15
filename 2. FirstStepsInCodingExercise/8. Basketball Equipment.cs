using System;

namespace _8._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a - a * 40 / 100;
            double c = b - b * 20 / 100;
            double d = c * 1 / 4;
            double e = d * 1 / 5;
            double f = a + b + c + d + e;

            Console.WriteLine(f);
        }
    }
}
