using System;
using System.Globalization;

namespace ExerciciosSecao14_04_01.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployy)
        {
            string[] text = csvEmployy.Split(',');
            Name = text[0];
            Salary = double.Parse(text[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", $" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("ERROR");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
