using System;

namespace _5._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string location = "";
            double price = 0;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 65 / 100;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 45 / 100;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 80 / 100;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 60 / 100;
                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                price = budget * 90 / 100;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
