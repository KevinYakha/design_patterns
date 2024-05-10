namespace Command;

class Program
{
    static void Main(string[] args)
    {
        BankAccount timoBA = new BankAccount();
        Console.WriteLine("Account was opened: " + timoBA.ToString());

        CashMachine cashMachineSC = new CashMachine();

        IBankTransactionCommand command1 = new DepositCommand(timoBA, 500);
        IBankTransactionCommand command2 = new WithdrawCommand(timoBA, 5000);
        //IBankTransactionCommand command3 = new DepositCommand(timoBA, 1000);

        cashMachineSC.ExecuteBankTransaction(command1);
        cashMachineSC.ExecuteBankTransaction(command2);
        //cashMachineSC.ExecuteBankTransaction(command3);

        command1.UnExecute();
        command2.UnExecute();

        Console.ReadKey();
    }
}
//Bankaccount->IbankTrans->Depo->With->Cash

/* 
 * I initially overthought it and would have implemented a transaction history
 * in the BankAccount class, but after a brief search online I stumbled upon
 * an article explaining a way to implement undo functionality using the command pattern.
 *  
 * Source:
 * https://www.codeproject.com/Articles/33384/Multilevel-Undo-and-Redo-Implementation-in-Cshar-2
 */
