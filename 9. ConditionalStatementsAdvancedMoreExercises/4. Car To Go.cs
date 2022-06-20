using System;

namespace _4._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string class_car = "";
            string type_car = "";
            double price_car = 0;

            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        class_car = "Economy class";
                        type_car = "Cabrio";
                        price_car = budget * 35 / 100;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        class_car = "Compact class";
                        type_car = "Cabrio";
                        price_car = budget * 45 / 100;
                    }
                    else if (budget > 500)
                    {
                        class_car = "Luxury class";
                        type_car = "Jeep";
                        price_car = budget * 90 / 100;
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        class_car = "Economy class";
                        type_car = "Jeep";
                        price_car = budget * 65 / 100;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        class_car = "Compact class";
                        type_car = "Jeep";
                        price_car = budget * 80 / 100;
                    }
                    else if (budget > 500)
                    {
                        class_car = "Luxury class";
                        type_car = "Jeep";
                        price_car = budget * 90 / 100;
                    }
                    break;
            }
            Console.WriteLine($"{class_car}");
            Console.WriteLine($"{type_car} - {price_car:f2}");
        }
    }
}
