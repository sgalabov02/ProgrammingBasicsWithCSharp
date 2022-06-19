using System;

namespace _5._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string type_vacation = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = budget * 30 / 100;
                    destination = "Bulgaria";
                    type_vacation = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 70 / 100;
                    destination = "Bulgaria";
                    type_vacation = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    price = budget * 40 / 100;
                    destination = "Balkans";
                    type_vacation = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 80 / 100;
                    destination = "Balkans";
                    type_vacation = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                price = budget * 90 / 100;
                destination = "Europe";
                type_vacation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type_vacation} - {price:f2}");
        }
    }
}
