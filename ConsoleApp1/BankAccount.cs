using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    public class BankAccount : Account // Ärver från Account
    {
        public BankAccount(string accountNumber, double initialBalance)
            : base(accountNumber, initialBalance) { } // Anropar basklassens konstruktor

        public override void PrintAccountInfo() // Skriver ut kontoinformation
        {
            Console.WriteLine($"Konto: {AccountNumber}, Saldo: {balance}");
        }
    }
}
