using System;

namespace _7._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double stranichna_stena = x * y;
            double prozorec = 1.5 * 1.5;
            double dve_strani = 2 * stranichna_stena - 2 * prozorec;
            double zadna_stena = x * x;
            double total_predna_zadna_stena = 2 * zadna_stena - 2.4;

            double zelena_boq = (total_predna_zadna_stena + dve_strani) / 3.4;

            double pravougulnici_pokriv = 2 * (x * y);
            double dva_triugulnika = 2 * (x * h / 2);
            double obshta_plosht = pravougulnici_pokriv + dva_triugulnika;

            double chervena_boq = obshta_plosht / 4.3;

            Console.WriteLine($"{zelena_boq:f2}");
            Console.WriteLine($"{chervena_boq:f2}");
        }
    }
}
