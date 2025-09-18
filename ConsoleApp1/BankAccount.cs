using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Skapar en klass 
    public class BankAccount 
    {
        // Egenskapaper för kontonummer och saldo
        public string AccountNumber { get; set; }
        // Jag gör balance privat så vi låser den från direkt åtkomst
        private double Balance;

        // Kontsruktor som körs när ett nytt konto skapas, AccountNumber och InitialBalance sätter konto nummer och startbelopp.

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            // Jag sätter initial balance till 0 om det är negativt. Det gör så att ett konto aldrig kan starta på minus. Så om Initial Balance är -100 så blir det 0 istället.
            Balance = Math.Max(0, initialBalance);
        }
        // En metod för att sätta in pengar på kontot, Math .Max(0, amount) gör så att man inte kan sätta in negativa belopp.
        public void Deposit(double amount)
        {
            Balance += Math.Max(0, amount);
        }
        // En metod för att ta ut pengar från kontot, kollar så att det finns tillräckligt med pengar på kontot innan uttag.
        public void Whitdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Otillräckligt saldo.");
            }

        }
        // En metod som skriver ut kontoinformation 
        public void PrintAccountInfo() 
        {
            Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
        }
        // En metod som returnerar saldot. 
        public double GetBalance() => Balance;
    } 
}
