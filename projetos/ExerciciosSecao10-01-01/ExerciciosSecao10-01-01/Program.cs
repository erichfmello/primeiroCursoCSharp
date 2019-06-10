using System;
using System.Collections.Generic;
using ExerciciosSecao10_01_01.Entities;

namespace ExerciciosSecao10_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + " data:");
                Console.Write("Outsourced (s/n)? ");
                string typeOfEmployee = Console.ReadLine();
                if (typeOfEmployee == "N" || typeOfEmployee == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    employees.Add(new Employee(name, hours, valuePerHour));
                } else if (typeOfEmployee == "S" || typeOfEmployee == "s")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: $");
                    double additionalCarge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCarge));
                } else
                {
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
