using System;
using ExerciciosSecao9_01_01.Entities.Enums;
using ExerciciosSecao9_01_01.Entities;

namespace ExerciciosSecao9_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string departamentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: R$");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament departament = new Departament(departamentName);
            Worker worker = new Worker(name, level, baseSalary, departament);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " contract data:");
                Console.Write("Date (MM/DD/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: R$");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"));
        }
    }
}
