using Command_CompositeCommand.Commands;

namespace Command_CompositeCommand
{
    public static class Program
    {
        // Иногда такое исполнение где используется патерн Команда + Компановщик
        // называют Макросы
        public static void Main(string[] args)
        {
            // 1 - part
            // var bankAccount = new BankAccount(0);
            // var cmdDeposit1 = new BankAccountCommand(bankAccount, Action.Deposit, 100);
            // var cmdWithdraw1 = new BankAccountCommand(bankAccount, Action.Deposit, 10);
            //
            // var composite = new CompositeBankAccountCommand(new []{cmdDeposit1, cmdWithdraw1});
            //
            // composite.Call();
            // Console.WriteLine(bankAccount);
            //
            // composite.Undo();
            // Console.WriteLine(bankAccount);

            // 2 - part
            var firstBankAccount = new BankAccount(100);
            var secondBankAccount = new BankAccount(0);

            var transferCommand = new MoneyTransferCommand(firstBankAccount, secondBankAccount, 40);

            Console.WriteLine("Transfer - Call");
            transferCommand.Call();
            Console.WriteLine($"First BA - {firstBankAccount}");
            Console.WriteLine($"Second BA - {secondBankAccount}");

            Console.WriteLine("Transfer - Undo");
            transferCommand.Undo();
            Console.WriteLine($"First BA - {firstBankAccount}");
            Console.WriteLine($"Second BA - {secondBankAccount}");

            Console.ReadLine();
        }
    }
}