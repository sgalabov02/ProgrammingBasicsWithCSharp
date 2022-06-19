using System;

namespace _6._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;

            switch(symbol)
            {
                case "+":
                    result = a + b;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{a} + {b} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} + {b} = {result} - odd");
                    }
                    break;
                case "-":
                    result = a - b;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{a} - {b} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} - {b} = {result} - odd");
                    }
                    break;
                case "*":
                    result = a * b;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{a} * {b} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} * {b} = {result} - odd");
                    }
                    break;
                case "/":
                    result = a / b;
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {result}");
                    }
                    break;
                case "%":
                    result = a % b;
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{a} % {b} = {result}");
                    }
                    break;
            }
        }
    }
}
