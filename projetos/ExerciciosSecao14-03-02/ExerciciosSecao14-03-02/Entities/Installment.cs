using System;
using System.Globalization;

namespace ExerciciosSecao14_03_02.Entities
{
    class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " - $" + Amount;
        }
    }
}
