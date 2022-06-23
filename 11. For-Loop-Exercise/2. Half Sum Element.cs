using System;

namespace _2._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum += b;

                if (b > max)
                {
                    max = b;
                }
            }
            int sum2 = sum - max;
            if (max == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sum2);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
