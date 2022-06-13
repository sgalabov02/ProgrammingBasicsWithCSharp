using System;

namespace _4._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = a / b;
            int e = d / c;

            Console.WriteLine(e);
        }
    }
}
