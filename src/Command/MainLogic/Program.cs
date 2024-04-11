namespace Command
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var newAccount = new BankAccount();
            var cmd1 = new BankAccountCommand(newAccount, Action.Deposit, 300);

            cmd1.Call(); // тут могут быть команды типа Execute, Do итд
            Console.WriteLine(cmd1);

            Console.WriteLine("Hello, World!");
        }
    }
}