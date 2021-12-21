using System;

namespace BankEcapsulationExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();

            Console.WriteLine("Your balance today is: ");
            Console.WriteLine(userAccount.GetBalance());
            Console.WriteLine("How much money would you like to deposit?");
            Console.Write("Enter amount here: ");
            double amount = double.Parse(Console.ReadLine());
            userAccount.Deposit(amount);
            Console.WriteLine();
            Console.WriteLine("Thank you! Have a nice day.");

                        
        }
    }
}
