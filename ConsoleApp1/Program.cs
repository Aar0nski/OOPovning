using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett vanligt konto
            BankAccount bankAccount = new BankAccount("11111", 1000);
            bankAccount.Deposit(500);
            bankAccount.PrintAccountInfo();
            // Konto: 11111, Saldo: 1500

            // Skapar ett sparkonto
            SavingsAccount savingsAccount = new SavingsAccount("22222", 2000, 0.05);
            savingsAccount.Withdraw(300);
            savingsAccount.PrintAccountInfo();
            // Sparkonto: 22222, Saldo: 1700, Ränta: 5%
        }
    }
}
