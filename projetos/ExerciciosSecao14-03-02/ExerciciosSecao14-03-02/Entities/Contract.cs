using System;
using System.Collections.Generic;

namespace ExerciciosSecao14_03_02.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }
        public List<Installment> installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            installments.Add(installment);
        }
    }
}
