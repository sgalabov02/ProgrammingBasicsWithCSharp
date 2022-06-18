using System;

namespace _5._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double product_price;

            switch(product)
            {
                case "coffee":
                    product_price = 0.50;
                    if(city == "Plovdiv")
                    {
                        product_price = 0.40;
                    }
                    else if(city == "Varna")
                    {
                        product_price = 0.45;
                    }
                    break;
                case "water":
                    product_price = 0.80;
                    if(city == "Plovdiv" || city == "Varna")
                    {
                        product_price = 0.70;
                    }
                    break;
                case "beer":
                    product_price = 1.2;
                    if(city == "Plovdiv")
                    {
                        product_price = 1.15;
                    }
                    else if(city == "Varna")
                    {
                        product_price = 1.10;
                    }
                    break;
                case "sweets":
                    product_price = 1.45;
                    if(city == "Plovdiv")
                    {
                        product_price = 1.30;
                    }
                    else if(city == "Varna")
                    {
                        product_price = 1.35;
                    }
                    break;
                case "peanuts":
                    product_price = 1.60;
                    if(city == "Plovdiv")
                    {
                        product_price = 1.50;
                    }
                    else if(city == "Varna")
                    {
                        product_price = 1.55;
                    }
                    break;
                default:
                    Console.WriteLine();
                    return;
            }
            Console.WriteLine(quantity * product_price);
        }
    }
}
