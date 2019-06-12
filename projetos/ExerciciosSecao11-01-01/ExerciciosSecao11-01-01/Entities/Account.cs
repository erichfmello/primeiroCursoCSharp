using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao11_01_01.Entities.Exceptions;

namespace ExerciciosSecao11_01_01.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            
            Balance -= amount;
        }
    }
}
