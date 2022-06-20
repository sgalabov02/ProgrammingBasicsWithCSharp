using System;

namespace _1._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double price = 0;

            if (people >= 1 && people <= 4)
            {
                budget = budget - budget * 75 / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                budget = budget - budget * 60 / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                budget = budget - budget * 50 / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                budget = budget - budget * 40 / 100;
            }
            else if (people >= 50)
            {
                budget = budget - budget * 25 / 100;
            }

            switch(category)
            {
                case "Normal":
                    price = 249.99 * people;
                    break;
                case "VIP":
                    price = 499.99 * people;
                    break;
            }    
            if (price <= budget)
            {
                Console.WriteLine($"Yes! you have {budget - price:f2} leva left.");
            }
            else if(price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
