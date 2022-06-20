using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget= int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen= int.Parse(Console.ReadLine());
            double priceForRent;            
            switch (season)
            {
                case "Spring":
                    priceForRent = 3000.0;                    
                    break;
                case"Summer":
                case"Autumn":
                    priceForRent = 4200.0;
                    break;               
                default:
                    priceForRent = 2600.0;
                    break;
            }
            if (numberOfFishermen <= 6)
            {
                priceForRent -= priceForRent * 0.1;
            }
            else if (numberOfFishermen>=12)
            {
                priceForRent -= priceForRent * 0.25;
            }
            else
            {
                priceForRent -= priceForRent * 0.15;
            }
            double totalPriceForRent = priceForRent;
            if (numberOfFishermen%2==0&&season!="Autumn")
            {
                totalPriceForRent = priceForRent * 0.95;
            }
            double difference = Math.Abs(budget - totalPriceForRent);
            Console.WriteLine(budget>=totalPriceForRent?$"Yes! You have {difference:f2} leva left.":$"Not enough money! You need {difference:f2} leva.");
        }
    }
}
