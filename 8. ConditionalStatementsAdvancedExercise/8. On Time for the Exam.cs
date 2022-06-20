using System;

namespace _8._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exam_hour = int.Parse(Console.ReadLine());
            int exam_minutes = int.Parse(Console.ReadLine());
            exam_minutes = exam_hour * 60 + exam_minutes;
            int arrive_hour = int.Parse(Console.ReadLine());
            int arrive_minutes = int.Parse(Console.ReadLine());
            arrive_minutes = arrive_hour * 60 + arrive_minutes;

            int difference = exam_minutes - arrive_minutes;

            if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On Time");
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int diff_hours = difference / 60;
                    int diff_minutes = difference % 60;
                    Console.WriteLine($"{diff_hours}:{diff_minutes:d2} hours before the start");
                }
            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");

                difference = Math.Abs(difference);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int diff_hours = difference / 60;
                    int diff_minutes = difference % 60;
                    Console.WriteLine($"{diff_hours}:{diff_minutes:d2} hours after the start");
                }
            }
        }
    }
}
