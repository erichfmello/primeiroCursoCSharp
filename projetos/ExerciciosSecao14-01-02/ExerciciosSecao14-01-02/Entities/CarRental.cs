using System;

namespace ExerciciosSecao14_01_02.Entities
{
    class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
