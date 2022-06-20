using System;

namespace _6._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double salary = 0;

            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = km * 0.75 * 4;
                }
                else if (season == "Summer")
                {
                    salary = km * 0.90 * 4;
                }
                else if (season == "Winter")
                {
                    salary = km * 1.05 * 4;
                }
            }
            else if(km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = km * 0.95 * 4;
                }
                else if (season == "Summer")
                {
                    salary = km * 1.10 * 4;
                }
                else if (season == "Winter")
                {
                    salary = km * 1.25 * 4;
                }
            }
            else if (km > 10000 && km <= 20000)
            {
                salary = km * 1.45 * 4;
            }

            salary = salary - salary * 10 / 100;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
