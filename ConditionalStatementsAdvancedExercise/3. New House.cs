using System;

namespace _3._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;

            if (quantity < 10 && quantity > 1000)
            {
                return;
            }
            if (budget < 50 && budget > 2500)
            {
                return;
            }

            switch(flower)
            {
                case "Roses":
                    price = 5 * quantity;
                    if (quantity > 80)
                    {
                        price = price - price * 10 / 100;
                    }
                    break;
                case "Dahlias":
                    price = 3.80 * quantity;
                    if (quantity > 90)
                    {
                        price = price - price * 15 / 100;
                    }
                    break;
                case "Tulips":
                    price = 2.80 * quantity;
                    if (quantity > 80)
                    {
                        price = price - price * 15 / 100;
                    }
                    break;
                case "Narcissus":
                    price = 3 * quantity;
                    if (quantity < 120)
                    {
                        price = price + price * 15 / 100;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50 * quantity;
                    if (quantity < 80)
                    {
                        price = price + price * 20 / 100;
                    }
                    break;
            }
            if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
            else if(budget > price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - price:f2} leva left.");
            }
        }
    }
}
