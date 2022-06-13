using System;

namespace _9._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 7.61;
            double c = b * 18/100;
            double d = b - c;

            Console.WriteLine("The final price is: " + d + " lv.");
            Console.WriteLine("The discount is: " + c + " lv.");
        }
    }
}
