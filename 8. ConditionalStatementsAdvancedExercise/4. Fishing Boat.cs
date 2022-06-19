using System;

namespace _4._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;

            switch(season)
            {
                case "Spring":
                    price = 3000;
                    if (fishermen <= 6)
                    {
                        price = price - price * 10 / 100;
                    }
                    else if(fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 15 / 100;
                    }
                    else if(fishermen >= 12)
                    {
                        price = price - price * 25 / 100;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 5 / 100;
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 10 / 100;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 15 / 100;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 25 / 100;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 5 / 100;
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 10 / 100;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 15 / 100;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 25 / 100;
                    }
                    break;
                case "Winter":
                    price = 2600;
                    if (fishermen <= 6)
                    {
                        price = price - price * 10 / 100;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 15 / 100;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 25 / 100;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 5 / 100;
                    }
                    break;
                default:
                    return;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
