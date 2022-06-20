using System;

namespace _7._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price_nights = 0;
            string sport = "";

            switch (group)
            {
                case "girls":
                case "boys":
                    if (season == "Winter")
                    {
                        price_nights = 9.60 * nights * students;
                    }
                    else if (season == "Spring")
                    {
                        price_nights = 7.20 * nights * students;
                    }
                    else if (season == "Summer")
                    {
                        price_nights = 15 * nights * students;
                    }
                    break;
                case "mixed":
                    if (season == "Winter")
                    {
                        price_nights = 10 * nights * students;
                    }
                    else if (season == "Spring")
                    {
                        price_nights = 9.50 * nights * students;
                    }
                    else if (season == "Summer")
                    {
                        price_nights = 20 * nights * students;
                    }
                    break;
            }
            if (students >= 50)
            {
                price_nights = price_nights - price_nights * 50 / 100;
            }
            else if (students >= 20 && students < 50)
            {
                price_nights = price_nights - price_nights * 15 / 100;
            }
            else if (students >= 10 && students < 20)
            {
                price_nights = price_nights - price_nights * 5 / 100;
            }    

            switch (season)
            {
                case "Winter":
                    if (group == "girls")
                    {
                        sport = "Gymnastics";
                    }
                    else if (group == "boys")
                    {
                        sport = "Judo";
                    }
                    else if (group == "mixed")
                    {
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (group == "girls")
                    {
                        sport = "Athletics";
                    }
                    else if (group == "boys")
                    {
                        sport = "Tennis";
                    }
                    else if (group == "mixed")
                    {
                        sport = "Cycling";
                    }
                    break;
                case "Summer":
                    if (group == "girls")
                    {
                        sport = "Volleyball";
                    }
                    else if (group == "boys")
                    {
                        sport = "Football";
                    }
                    else if (group == "mixed")
                    {
                        sport = "Swimming";
                    }
                    break;
            }
            Console.WriteLine($"{sport} {price_nights:f2} lv.");
        }
    }
}
