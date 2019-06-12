using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao10_04_01.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee) : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Tax()
        {
            if(NumberOfEmployee <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
