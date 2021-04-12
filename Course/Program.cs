using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] productData = Console.ReadLine().Split(',');
                string name = productData[0];
                double price = double.Parse(productData[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product p  = calculationService.Max(list);

            Console.WriteLine();
            Console.WriteLine("Most expensive: " + p);
            
        }
    }
}
