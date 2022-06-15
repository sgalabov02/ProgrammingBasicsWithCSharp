using System;

namespace _2._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = 0;

            if (a <= 100)
            {
                b = 5;
            }
            else if (a > 1000)
            {
                b = a * 0.1;
            }
            else
            {
                b = a * 0.2;
            }
            if (a % 2 == 0)
            {
                b = b + 1;
            }
            else if (a % 10 == 5)
            {
                b += 2;
            }

            Console.WriteLine(b);
            Console.WriteLine(a + b);
        }
    }
}
