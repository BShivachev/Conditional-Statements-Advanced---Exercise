using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string value = Console.ReadLine();
            double onepersonRoom = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;
            double totalPrice;
            switch (roomType)
            {
                case"apartment":
                    totalPrice = (days - 1) * apartment;
                    if (days<10)
                    {
                        totalPrice *= 0.7;
                    }
                    else if (days>15)
                    {
                        totalPrice *= 0.5;
                    }
                    else
                    {
                        totalPrice *= 0.65;
                    }
                    break;
                case"president apartment":
                    totalPrice = (days - 1) * presidentApartment;
                    if (days < 10)
                    {
                        totalPrice *= 0.9;
                    }
                    else if (days > 15)
                    {
                        totalPrice *= 0.8;
                    }
                    else
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                default:
                    totalPrice = (days - 1) * onepersonRoom;
                    break;                                        
            }
            if (value == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
