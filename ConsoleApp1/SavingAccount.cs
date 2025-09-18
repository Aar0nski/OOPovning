using System;

namespace ConsoleApp1
{
    public class SavingsAccount : Account // Ärver från Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, double initialBalance, double interestRate)
            : base(accountNumber, initialBalance) // Anropar basklassens konstruktor
        {
            InterestRate = interestRate; 
        } 

        public override void PrintAccountInfo() // skriver ut info om sparkonto
        {
            Console.WriteLine(
                $"Sparkonto: {AccountNumber}, Saldo: {balance}, Ränta: {InterestRate * 100}%"
            );
        }
    }
}
