using System;

namespace _5._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine((a * 5.80 + b * 7.20 + c * 1.20) - (a * 5.80 + b * 7.20 + c * 1.20) * d / 100);
            
        }
    }
}
