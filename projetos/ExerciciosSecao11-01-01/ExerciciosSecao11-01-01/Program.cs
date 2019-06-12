using System;
using ExerciciosSecao11_01_01.Entities;
using ExerciciosSecao11_01_01.Entities.Exceptions;

namespace ExerciciosSecao11_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter accont data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, name, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                acc.WithDraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            } catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
