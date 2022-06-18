using System;

namespace _12._Trade_Comissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if(sales <= 0)
            {
                Console.WriteLine("error");
                return;
            }
            switch(town)
            {
                case "Sofia":
                    if(sales >= 0 && sales <= 500)
                    {
                        sales = sales * 5 / 100;
                    }
                    else if(sales > 500 && sales <= 1000)
                    {
                        sales = sales * 7 / 100;
                    }
                    else if(sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 8 / 100;
                    }
                    else if(sales > 10000)
                    {
                        sales = sales * 12 / 100;
                    }
                    break;
                case "Varna":
                    if(sales >= 0 && sales <= 500)
                    {
                        sales = sales * 4.5 / 100;
                    }
                    else if(sales > 500 && sales <= 1000)
                    {
                        sales = sales * 7.5 / 100;
                    }
                    else if(sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 10 / 100;
                    }
                    else if(sales > 10000)
                    {
                        sales = sales * 13 / 100;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        sales = sales * 5.5 / 100;
                    }
                    else if(sales > 500 && sales <= 1000)
                    {
                        sales = sales * 8 / 100;
                    }
                    else if(sales > 1000 && sales <= 10000)
                    {
                        sales = sales * 12 / 100;
                    }
                    else if(sales > 10000)
                    {
                        sales = sales * 14.5 / 100;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            Console.WriteLine($"{sales:f2}");
        }
    }
}
