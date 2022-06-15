using System;

namespace _4._ConditionalStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = a + b + c;
            int e = d / 60;
            int f = d % 60;

            if (f < 10)
            {
                Console.WriteLine(e + ":0" + f);
            }
            else
            {
                Console.WriteLine(e + ":" + f);
            }
        }
    }
}
