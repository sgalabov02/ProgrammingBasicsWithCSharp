using System;

namespace _7._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = b * 3;

            Console.WriteLine("The architect " + a + " will need " + c + " hours to complete " + b + " project/s.");
        }
    }
}
