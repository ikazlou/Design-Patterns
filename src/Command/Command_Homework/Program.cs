namespace Command_Homework
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var acc = new Account(100);
            acc.Process(new Command
            {
                Amount = 10,
                TheAction = Command.Action.Deposit
            });

            Console.ReadLine();
        }
    }
}