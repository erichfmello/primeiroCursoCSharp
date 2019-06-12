using System;
using ExerciciosSecao10_02_01.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao10_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string typeOfProduct = Console.ReadLine();

                if (typeOfProduct == "c" || typeOfProduct == "C")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $");
                    double price = double.Parse(Console.ReadLine());

                    products.Add(new Product(name, price));
                }
                else if (typeOfProduct == "u" || typeOfProduct == "U")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (MM/DD/YYYY): ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, dateTime));
                }
                else if (typeOfProduct == "i" || typeOfProduct == "I")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: $");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
