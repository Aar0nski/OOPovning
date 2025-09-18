using System;

namespace ConsoleApp1
{
    public abstract class Account // Abrakt klass
    {
        public string AccountNumber { get; set; }
        protected double balance; // Bara subklasser kan komma åt saldot

        public Account(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber; // Sätter kontonummer
            balance = Math.Max(0, initialBalance);
        }

        public void Deposit(double amount) => balance += Math.Max(0, amount); // Insättning av belopp, kan inte vara negativt.

        public void Withdraw(double amount) // Uttag av belopp
        {
            if ( balance - amount >= 0)
            {
                balance -= amount;
            }
            else             {
                Console.WriteLine("Otillräckligt saldo.");
            }

        }
        // Abstrakt metod som måste implementeras i subklasser 
        public abstract void PrintAccountInfo();
    }
}
