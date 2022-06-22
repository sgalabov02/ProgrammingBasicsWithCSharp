using System;

namespace _2._Numbers_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
