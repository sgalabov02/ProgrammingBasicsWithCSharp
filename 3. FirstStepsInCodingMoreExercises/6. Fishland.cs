using System;

namespace _6._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriq = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            double midi = double.Parse(Console.ReadLine());

            double palamud_price = skumriq + skumriq * 0.60;
            double total_palamud_price = palamud * palamud_price;
            double safrid_price = caca + caca * 0.80;
            double total_safrid_price = safrid * safrid_price;
            double midi_price = midi * 7.50;
            double bill = total_palamud_price + total_safrid_price + midi_price;

            Console.WriteLine($"{bill:f2}");
        }
    }
}
