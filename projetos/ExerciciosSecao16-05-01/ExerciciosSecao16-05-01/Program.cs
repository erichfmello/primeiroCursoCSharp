using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExerciciosSecao16_05_01.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao16_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);

                        products.Add(new Product(name, price));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }

            var averange = products.Average(p => p.Price);
            Console.WriteLine("Anerange price: $" + averange.ToString("F2", CultureInfo.InvariantCulture));

            var selection = products.Where(p => p.Price < averange).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in selection)
            {
                Console.WriteLine(name);
            }
        }
    }
}
