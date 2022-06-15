using System;

namespace _7._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double sum_graphicscard = b * 250;
            double sum_processors = c * sum_graphicscard * 35 / 100;
            double sum_ram = d * sum_graphicscard * 10 / 100;
            double total = sum_graphicscard + sum_processors + sum_ram;

            if (b > c)
            {
                total = total - total * 15 / 100;
            }

            if (a > total)
            {
                double money_left = a - total;
                Console.WriteLine($"You have {money_left:f2} leva left!");
            }
            else
            {
                double money_left = total - a;
                Console.WriteLine($"Not enough money! You need {money_left:f2} leva more!");
            }
        }
    }
}
