using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using ExerciciosSecao16_06_01.Entities;

namespace ExerciciosSecao16_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    salary = double.Parse(fields[2]);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: $");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Email of people whose salary is more than $" + salary);
            var emailComparation = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string email in emailComparation)
            {
                Console.WriteLine(email);
            }
            var nameWithM = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': $" + nameWithM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
