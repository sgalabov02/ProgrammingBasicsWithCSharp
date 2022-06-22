using System;

namespace _5._Character_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                char letter = a[i];
                //Console.WriteLine(letter);
                if (letter == 'a')
                {
                    sum += 1;
                }
                else if (letter == 'e')
                {
                    sum += 2;
                }
                else if (letter == 'i')
                {
                    sum += 3;
                }
                else if (letter == 'o')
                {
                    sum += 4;
                }
                else if (letter == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
