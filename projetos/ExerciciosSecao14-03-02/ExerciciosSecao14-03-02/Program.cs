using System;
using System.Globalization;
using ExerciciosSecao14_03_02.Entities;
using ExerciciosSecao14_03_02.Services;

namespace ExerciciosSecao14_03_02
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

            ContractService contractService = new ContractService(new PaypalService());
            Contract contract = new Contract(number, date, totalValue);
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.installments)
            {
                Console.WriteLine(installment.ToString());
            }
        }
    }
}
