using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam= int.Parse(Console.ReadLine());
            int minutesExam= int.Parse(Console.ReadLine());
            int arriveHours= int.Parse(Console.ReadLine());
            int arriveMinutes= int.Parse(Console.ReadLine());
            minutesExam += hoursExam * 60;
            arriveMinutes += arriveHours * 60;
            int difference;
            int hours;
            int minutes;

            if (arriveMinutes>minutesExam)
            {
                difference = arriveMinutes - minutesExam;
                    hours = difference / 60;
                    minutes = difference % 60;
                Console.WriteLine("Late");
                if (difference<60)
                {
                Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hours} : {minutes:d2} hours after the start");
                }
            }
            else if (arriveMinutes<=minutesExam)
            {
                    difference = minutesExam - arriveMinutes;
                    hours = difference / 60;
                    minutes = difference % 60;
                if (difference==0)
                {
                    Console.WriteLine("On time");
                }
                else if (difference<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                 else
                 {
                    Console.WriteLine("Early");
                    if (difference>=60)
                    {
                        Console.WriteLine($"{hours} : {minutes:d2} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                 }
            }
        }                                
    }
}
