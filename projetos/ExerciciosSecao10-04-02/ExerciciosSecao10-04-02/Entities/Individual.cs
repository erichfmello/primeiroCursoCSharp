using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao10_04_02.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            } else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
