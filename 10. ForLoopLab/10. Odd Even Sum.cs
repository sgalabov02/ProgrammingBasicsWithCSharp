using System;

namespace _10._2_Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += b;
                }
                else if (i % 2 == 1)
                {
                    sum2 += b;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum1);
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
