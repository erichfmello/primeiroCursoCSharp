using System;
using System.Collections.Generic;
using ExerciciosSecao16_02_01.Entities;

namespace ExerciciosSecao16_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100);
            list.RemoveAll(ProductTeste);

            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTeste(Product p)
        {
            return p.Price >= 100;
        }
    }
}
