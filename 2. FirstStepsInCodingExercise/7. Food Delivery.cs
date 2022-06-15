using System;

namespace _7._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = a * 10.35 + b * 12.40 + c * 8.15;
            double e = d * 1/5;

            Console.WriteLine(d + e + 2.50);
        }
    }
}
