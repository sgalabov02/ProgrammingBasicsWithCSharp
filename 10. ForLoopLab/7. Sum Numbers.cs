using System;

namespace _7._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int c = 0;

            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                c += b;
            }
            Console.WriteLine(c);
        }
    }
}
