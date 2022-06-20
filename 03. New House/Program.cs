using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers= int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double roses=5.0;
            double dahlias=3.8;
            double tulips=2.8;
            double narcissus=3.0;
            double guadiolus=2.5;
            double totalPrice;
            switch (typeOfFlower)
            {   case"Roses":
                    totalPrice = numberOfFlowers * roses;
                    if (numberOfFlowers>80)
                    {
                        totalPrice -= totalPrice * 0.1;
                    }
                    break;
                case"Dahlias":
                    totalPrice = numberOfFlowers * dahlias;
                    if (numberOfFlowers>90)
                    {
                        totalPrice -= totalPrice * 0.15;   
                    }
                    break;
                case"Tulips":
                    totalPrice = numberOfFlowers * tulips;
                    if (numberOfFlowers>80)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case"Narcissus":
                    totalPrice = numberOfFlowers * narcissus;
                    if (numberOfFlowers<120)
                    {
                        totalPrice += totalPrice * 0.15;
                    }
                    break;
                default:
                    totalPrice = numberOfFlowers * guadiolus;
                    if (numberOfFlowers<80)
                    {
                        totalPrice += totalPrice * 0.2;
                    }
                    break;
            }
            double difference = Math.Abs(budget - totalPrice);
            Console.WriteLine(totalPrice<=budget?$"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {difference:f2} leva left.":$"Not enough money, you need {difference:f2} leva more.");
        }
    }
}
