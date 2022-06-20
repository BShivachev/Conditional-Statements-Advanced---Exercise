using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTicket = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double premierePrice = 12.00;
            double normalPrice = 7.5;
            double discountPrice = 5.0;
            double totalPlaces = rows * colums;
            double totalProphit=0;
            switch (typeOfTicket)
            {
                case "Premiere":
                    totalProphit = totalPlaces * premierePrice;
                    break;
                case "Normal":
                    totalProphit = totalPlaces * normalPrice;     
                    break;
                case"Discount":
                    totalProphit = totalPlaces * discountPrice;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"{totalProphit:f2}");
        }
    }
}
