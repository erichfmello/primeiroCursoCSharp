using System;
using ExerciciosSecao10_04_01.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao10_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayer = new List<TaxPayer>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                string typeOfPayer = Console.ReadLine();

                if(typeOfPayer == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: $");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: $");
                    double helthExpenditures = double.Parse(Console.ReadLine());

                    taxPayer.Add(new Individual(name, anualIncome, helthExpenditures));
                } else if(typeOfPayer == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: $");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employee: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());

                    taxPayer.Add(new Company(name, anualIncome, numberOfEmployee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            double sum = 0;
            foreach(TaxPayer elements in taxPayer)
            {
                Console.WriteLine(elements.Name + ": $" + elements.Tax().ToString("F2"));
                sum += elements.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));
        }
    }
}
