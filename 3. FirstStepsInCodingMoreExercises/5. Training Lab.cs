using System;

namespace _5._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double a = Math.Floor(w * 100 / 120);
            double b = Math.Floor((h * 100 - 100) / 70);

            double seats = a * b - 3;


            Console.WriteLine(seats);
        }
    }
}
