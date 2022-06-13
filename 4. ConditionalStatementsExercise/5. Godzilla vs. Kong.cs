using System;

namespace _5._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double decor = a * 10 / 100;
            double clothes = b * c;
            if (b > 150)
            {
                clothes = clothes - clothes * 10 / 100;
            }
            double total_sum = decor + clothes;
            double money_left = a - total_sum;

            if ( total_sum <= a)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money_left:f2} leva left.");
            }
            else
            {
                money_left = total_sum - a;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {money_left:f2} leva more.");
            }
        }
    }
}
