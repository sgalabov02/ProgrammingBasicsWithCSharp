using System;

namespace _9._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = a * b * c;
            double f = e / 1000;
            double g = f * (1 - d / 100);

            Console.WriteLine(g);
        }
    }
}
