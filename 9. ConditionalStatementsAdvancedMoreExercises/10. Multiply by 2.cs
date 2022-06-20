using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            while (a >= 0)
            {
                a = double.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    Console.WriteLine($"Result: {a * 2:f2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                }
            }
        }
    }
}
