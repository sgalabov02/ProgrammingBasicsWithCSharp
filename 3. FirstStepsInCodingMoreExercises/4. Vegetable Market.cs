using System;

namespace _4._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double result = a * c + b * d;
            double result_to_euro = result / 1.94;

            Console.WriteLine($"{result_to_euro:f2}");

        }
    }
}
