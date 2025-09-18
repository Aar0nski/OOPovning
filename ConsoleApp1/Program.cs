using ConsoleApp1;

class Program 
{
    static void Main(string[] args) // Main metoden är startpunkten för programmet
    {
        BankAccount normal = new BankAccount("11111", 1000);
        SavingsAccount savings = new SavingsAccount("22222", 2000, 0.05);

        normal.PrintAccountInfo();  // Konto: 11111, Saldo: 1000
        savings.PrintAccountInfo(); // Sparkonto: 22222, Saldo: 2000, Ränta: 5%
    }
}