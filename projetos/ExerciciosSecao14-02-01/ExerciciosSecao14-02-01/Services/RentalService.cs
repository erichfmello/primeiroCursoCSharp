using System;
using ExerciciosSecao14_02_01.Entities;

namespace ExerciciosSecao14_02_01.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private TaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, TaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.TaxService(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
