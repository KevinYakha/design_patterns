using System;
namespace Command
{
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = 1000;

        public void Deposit(double amount)
        {
            Balance += amount; //Balance = Balance + amount;
            Console.WriteLine($"{amount} Euros have been deposited into the account.");
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount + OverdraftLimit >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} Euros have been withdrawn from the account. The new balance is {Balance} Euros.");
            }
            else
                Console.WriteLine("The withdrawal amount exceeds your overdraft limit.");
        }

        public override string ToString()
        {
            return $"Account balance: {Balance} Euros, Overdraft limit: {OverdraftLimit} Euros";
        }
    }
}

