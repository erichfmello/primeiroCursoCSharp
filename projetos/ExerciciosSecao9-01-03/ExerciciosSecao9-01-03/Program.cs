using System;
using ExerciciosSecao9_01_03.Entities;
using ExerciciosSecao9_01_03.Entities.Enums;

namespace ExerciciosSecao9_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: R$");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(workerName, level, baseSalary, department);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " contract data:");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: R$");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": R$" + worker.Income(year, month));
        }
    }
}
