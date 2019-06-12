using System;
using ExerciciosSecao10_04_02.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao10_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                string typeOfPayer = Console.ReadLine();
                                
                switch (typeOfPayer)
                {
                    case "i":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Anual income: $");
                        double anualIncome = double.Parse(Console.ReadLine());
                        Console.Write("Health expenditures: $");
                        double helthExpenditures = double.Parse(Console.ReadLine());

                        taxPayers.Add(new Individual(helthExpenditures, name, anualIncome));
                        break;

                    case "c":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Anual income: $");
                        anualIncome = double.Parse(Console.ReadLine());
                        Console.Write("Number of employee: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());

                        taxPayers.Add(new Company(numberOfEmployees, name, anualIncome));
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;

            foreach(TaxPayer elements in taxPayers)
            {
                Console.WriteLine(elements.Name + ": $" + elements.Tax().ToString("F2"));
                sum += elements.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));
        }
    }
}
