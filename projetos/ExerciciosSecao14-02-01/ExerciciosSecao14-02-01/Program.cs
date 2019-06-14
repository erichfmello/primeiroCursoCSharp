using System;
using System.Globalization;
using ExerciciosSecao14_02_01.Entities;
using ExerciciosSecao14_02_01.Services;

namespace ExerciciosSecao14_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pichup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: $");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: $");
            double pricePerDay = double.Parse(Console.ReadLine());

            Vehicle vehicle = new Vehicle(carModel);
            CarRental carRental = new CarRental(start, finish, vehicle);
            BrazilTaxService brazilTaxService = new BrazilTaxService();
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, brazilTaxService);
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice.ToString());
        }
    }
}
