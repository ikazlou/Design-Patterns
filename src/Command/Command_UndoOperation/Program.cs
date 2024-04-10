namespace Command_UndoOperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newAccount = new BankAccount(100);
            var cmd = new BankAccountCommand(newAccount, Action.Withdraw, 1000);

            cmd.Call(); // тут могут быть команды типа Execute, Do итд
            Console.WriteLine(newAccount);

            cmd.Undo();
            Console.WriteLine(newAccount);

            Console.ReadLine();
        }
    }
}