using System;
using ExerciciosSecao10_01_02.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao10_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeed = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                string comparetor = Console.ReadLine();
                if(comparetor == "y" || comparetor == "Y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCarge = double.Parse(Console.ReadLine());

                    employeed.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCarge));
                } else if(comparetor == "n" || comparetor == "N")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    employeed.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach(Employee emp in employeed)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
