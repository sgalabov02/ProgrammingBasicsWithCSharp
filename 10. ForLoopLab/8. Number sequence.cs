using System;
using System.Linq;

namespace _8._1_Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = new string[];

            //cars[0] = "Tesla";
            //cars[1] = "Mustang";
            //cars[2] = "Corvette";

            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[a];

            for (int i = 0; i < a; i++)
            {
                //string[] cars = new string[a];
                //Console.WriteLine(cars[i]);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            /*for (int i = 0; i < a; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/
            int maxValue = numbers.Max();
            int minValue = numbers.Min();
            Console.WriteLine("Max number: " + maxValue);
            Console.WriteLine("Min number: " + minValue);
        }
    }
}
