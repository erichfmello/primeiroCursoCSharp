using System;
using System.Globalization;
using ExerciciosSecao14_03_01.Entities;
using ExerciciosSecao14_03_01.Services;

namespace ExerciciosSecao14_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: $");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            PaypalService paypalService = new PaypalService();
            ContractService contractService = new ContractService(paypalService);
            Contract contract = new Contract(number, date, totalValue);
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments");
            foreach(Installment installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }
        }
    }
}
