using System;

namespace _3._Numbers_1_to_N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
