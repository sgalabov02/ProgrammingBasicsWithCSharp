using System;

namespace _7._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a == "square")
            {
                double b = double.Parse(Console.ReadLine());
                double S = b * b;
                S.ToString("#.000");
                Console.WriteLine(S);
            }
            else if (a == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double S = b * c;
                Console.WriteLine(S);
            }
            else if (a == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = Math.PI * r * r;
                Console.WriteLine(S);
            }
            else if (a == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double S = (b * c) / 2;
                Console.WriteLine(S);
            }
        }
    }
}
