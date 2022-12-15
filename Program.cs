using System;
namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prodajbi = 0;
            double ratingTotal = 0;
            double total = 0;
            double totalProdajbi = 0;
            double numberCpu = double.Parse(Console.ReadLine());
            for (double i = 1; i <= numberCpu; i++)
            {
                double sellers = double.Parse(Console.ReadLine());
                double rating = sellers % 10;
                double newSum = Math.Round(sellers - rating) / 10;
                ratingTotal += rating;
                if (rating <= 2)
                {
                    totalProdajbi = newSum * 0;
                }
                else if (rating == 3)
                {
                    totalProdajbi = newSum * 0.50;
                }
                else if (rating == 4)
                {
                    totalProdajbi = newSum * 0.70;
                }
                else if (rating == 5)
                {
                    totalProdajbi = newSum * 0.85;
                }
                else if (rating >= 6)
                {
                    totalProdajbi = newSum * 1.0;
                }
                total += totalProdajbi;
            }
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"{ratingTotal / numberCpu:f2}");
        }
    }
}