using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SavingsAccount : BankAccount // Arv från BankAccount
    {
        public double InterestRate { get; set; } // Ny prop som bara finns i SavingsAccount eftersom att ett bankkonto inte har ränta.

        public SavingsAccount(string accountNumber, double initialBalance, double interestRate) // det som körs när man skapar nytt sparkonto
            : base(accountNumber, initialBalance) // skickar vidare accountNumber och initialBalance till basklassens konstruktor
        {
            InterestRate = interestRate; // sparar räntan
        }
      
    }
}
