using System;

namespace _3._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            b += 15;
            
            if (b >= 60)
            {
                a += 1;
                b -= 60;
            }
            if (a > 23)
            {
                a -= 24;
            }
            if (b < 10)
            {
                Console.WriteLine(a + ":0" + b);
            }
            else
            {
                Console.WriteLine(a + ":" + b);
            }
        }
    }
}
