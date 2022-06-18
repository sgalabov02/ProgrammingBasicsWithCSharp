using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double product_price;

            if(day == "Workday")
            {
                Console.WriteLine("error");
                return;
            }

            switch(product)
            {
                case "banana":
                    product_price = 2.50;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 2.70;
                    }
                    break;
                case "apple":
                    product_price = 1.20;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 1.25;
                    }
                    break;
                case "orange":
                    product_price = 0.85;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 0.90;
                    }
                    break;
                case "grapefruit":
                    product_price = 1.45;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 1.60;
                    }
                    break;
                case "kiwi":
                    product_price = 2.70;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 3.00;
                    }
                    break;
                case "pineapple":
                    product_price = 5.50;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 5.60;
                    }
                    break;
                case "grapes":
                    product_price = 3.85;
                    if(day == "Saturday" || day == "Sunday")
                    {
                        product_price = 4.20;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            Console.WriteLine($"{product_price * quantity:f2}");
        }
    }
}
