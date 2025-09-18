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
        public double Balance { get; set; }
        // En metod som skriver ut kontoinformation 
        public void PrintAccountInfo() 
        {
            Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
        } 
    } 
}
