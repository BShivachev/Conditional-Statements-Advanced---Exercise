using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spendingForVacantion;
            string typeOfExcursion;
            string destination;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spendingForVacantion = budget * 0.3;
                    typeOfExcursion = "Camp";
                }
                else
                {
                    spendingForVacantion = budget * 0.7;
                    typeOfExcursion = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendingForVacantion = budget * 0.9;
                typeOfExcursion = "Hotel";
            }
            else
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spendingForVacantion = budget * 0.4;
                    typeOfExcursion = "Camp";
                }
                else
                {
                    spendingForVacantion = budget * 0.8;
                    typeOfExcursion = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfExcursion} - {spendingForVacantion:f2}");
        }
    }
}
