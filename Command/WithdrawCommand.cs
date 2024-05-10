using System;
namespace Command
{
    public class WithdrawCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount;
        private bool success = false;

        public WithdrawCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            success = bankAccount.Withdraw(amount);
        }

        public void UnExecute()
        {
            if (success)
                bankAccount.Deposit(amount);
        }
    }
}

