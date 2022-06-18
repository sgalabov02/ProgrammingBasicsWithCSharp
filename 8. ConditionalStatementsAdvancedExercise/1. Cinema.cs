using System;

namespace _1._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;

            if (projection == "Premiere")
            {
                price = 12.00;
            }
            else if(projection == "Normal")
            {
                price = 7.50;
            }
            else if(projection == "Discount")
            {
                price = 5.00;
            }
            Console.WriteLine($"{price * rows * columns:f2} leva");
        }
    }
}
