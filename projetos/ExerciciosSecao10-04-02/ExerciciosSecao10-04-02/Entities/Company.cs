using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao10_04_02.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees <= 10)
            {
                return AnualIncome * 0.16;
            } else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
