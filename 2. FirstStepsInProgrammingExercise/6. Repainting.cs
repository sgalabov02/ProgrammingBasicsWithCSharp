using System;

namespace _6._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = (a + 2) * 1.50 + (b + b * 1/10) * 14.50 + c * 5.00 + 0.40;
            double f = (e * 30 / 100) * 8;

            Console.WriteLine(e + f);
        }
    }
}
