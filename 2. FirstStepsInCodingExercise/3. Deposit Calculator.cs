using System;

namespace _3._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = a + b * ((a * c / 100) / 12);

            Console.WriteLine(d);
        }
    }
}
