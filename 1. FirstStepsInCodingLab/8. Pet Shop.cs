using System;

namespace _8._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a * 2.50;
            double d = b * 4;
            double e = c + d;

            Console.WriteLine(e + " lv.");
        }
    }
}
