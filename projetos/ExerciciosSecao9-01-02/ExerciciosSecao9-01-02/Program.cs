using System;
using ExerciciosSecao9_01_02.Entities.Enum;
using ExerciciosSecao9_01_02.Entities;

namespace ExerciciosSecao9_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string departmentName;
            string workName;
            string monthAndYear;

            double baseSalary;

            int n;
            int month;
            int year;

            WorkerLevel level;

            Departament department;
            Worker worker;

            Console.Write("Enter department's name: ");
            departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            workName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)? ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: R$");
            baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            n = int.Parse(Console.ReadLine());

            department = new Departament(departmentName);
            worker = new Worker(workName, level, baseSalary, department);

            for (int i = 0; i < n; i++)
            {
                double valuePerHour;
                int duration;

                DateTime date;

                HourContract contract;

                Console.WriteLine("Enter #" + (i+1) + " contract data:");
                Console.Write("Date (MM/DD/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: R$");
                valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                duration = int.Parse(Console.ReadLine());

                contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            monthAndYear = Console.ReadLine();
            month = int.Parse(monthAndYear.Substring(0, 2));
            year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": R$" + worker.Income(year, month).ToString("F2"));
        }
    }
}
