using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double appartmentPricePerNight;
            double studioPricePerNight;
            if (mounth=="May" 
              ||mounth=="October")
            {
                studioPricePerNight = 50.0;
                appartmentPricePerNight = 65.0;
                if (nights>7&&nights<=14)
                {
                      studioPricePerNight-=studioPricePerNight* 0.05;
                }
                else if (nights>14)
                {
                    studioPricePerNight -= studioPricePerNight * 0.30;
                }
            }
            else if (mounth=="June" 
                   ||mounth=="September")
            {
                studioPricePerNight = 75.20;
                appartmentPricePerNight = 68.70;
                if (nights>14)
                {
                    studioPricePerNight-= studioPricePerNight * 0.20;
                }
            }
            else
            {
                studioPricePerNight = 76.0;
                appartmentPricePerNight = 77.0;
            }
            if (nights>14)
            {
                 appartmentPricePerNight-=appartmentPricePerNight* 0.10;
            }
            double studioTotalPrice = studioPricePerNight * nights;
            double appartmentTotalPrice = appartmentPricePerNight * nights;
            Console.WriteLine($"Apartment: {appartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: { studioTotalPrice:f2} lv.");
        }
    }
}
