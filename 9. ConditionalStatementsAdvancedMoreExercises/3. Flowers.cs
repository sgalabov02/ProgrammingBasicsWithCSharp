using System;

namespace _3._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            double price_chrysanthemums = 0;
            int roses = int.Parse(Console.ReadLine());
            double price_roses = 0;
            int tulips = int.Parse(Console.ReadLine());
            double price_tulips = 0;
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double price_total = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    price_chrysanthemums = 2 * chrysanthemums;
                    price_roses = 4.10 * roses;
                    price_tulips = 2.50 * tulips;
                    price_total = price_chrysanthemums + price_roses + price_tulips;
                    break;
                case "Autumn":
                case "Winter":
                    price_chrysanthemums = 3.75 * chrysanthemums;
                    price_roses = 4.50 * roses;
                    price_tulips = 4.15 * tulips;
                    price_total = price_chrysanthemums + price_roses + price_tulips;
                    break;
            }
            if (holiday == "Y")
            {
                price_total = price_total + price_total * 15 / 100;
            }
            if (season == "Spring" && tulips >= 7)
            {
                price_total = price_total - price_total * 5 / 100;
            }
            if (season == "Winter" && roses >= 10)
            {
                price_total = price_total - price_total * 10 / 100;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                price_total = price_total - price_total * 20 / 100;
            }
            price_total += 2;
            Console.WriteLine($"{price_total:f2}");
        }
    }
}
