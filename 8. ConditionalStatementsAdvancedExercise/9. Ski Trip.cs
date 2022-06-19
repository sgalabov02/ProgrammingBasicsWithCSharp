using System;

namespace _9._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;

            switch(room)
            {
                case "room for one person":
                    price = (days - 1) * 18;
                    break;
                case "apartment":
                    price = (days - 1) * 25;
                    if (days - 1 < 10)
                    {
                        price = price - price * 30 / 100;
                    }
                    else if(days - 1 >= 10 && days - 1 <= 15)
                    {
                        price = price - price * 35 / 100;
                    }
                    else if(days - 1 > 15)
                    {
                        price = price - price * 50 / 100;
                    }
                    break;
                case "president apartment":
                    price = (days - 1) * 35;
                    if (days - 1 < 10)
                    {
                        price = price - price * 10 / 100;
                    }
                    else if (days - 1 >= 10 && days - 1 <= 15)
                    {
                        price = price - price * 15 / 100;
                    }
                    else if (days - 1 > 15)
                    {
                        price = price - price * 20 / 100;
                    }
                    break;
            }
            if (rating == "positive")
            {
                price = price + price * 25 / 100;
            }
            else
            {
                price = price - price * 10 / 100;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
