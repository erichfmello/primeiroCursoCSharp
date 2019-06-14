using System;
using ExerciciosSecao11_01_03.Entities.Exceptions;
using ExerciciosSecao11_01_03.Entities;

namespace ExerciciosSecao11_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Initial balance: $");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: $");
            double limit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, name, balance, limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: $");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: $" + acc.Balance);
            } catch(DomainException e)
            {
                Console.WriteLine("Withdraw erro: " + e.Message);
            }
        }
    }
}
