using System;

namespace _3._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = (a * 1.8) + 32;

            Console.WriteLine($"{b:f2}");
        }
    }
}
