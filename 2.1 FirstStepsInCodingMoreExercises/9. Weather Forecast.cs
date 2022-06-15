using System;

namespace _9._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string condition = Console.ReadLine();

            if (condition == "sunny" || '["sunny"]')
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
