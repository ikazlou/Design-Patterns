namespace Command_Homework
{
    public class Account
    {
        public int Balance { get; set; }

        public Account(int balance)
        {
            Balance = balance;
        }

        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Command.Action.Withdraw:
                    if (Balance >= c.Amount)
                    {
                        c.Success = true;
                        Balance -= c.Amount;
                    }
                    else
                    {
                        c.Success = false;
                    }

                    break;
                case Command.Action.Deposit:
                    c.Success = true;
                    Balance += c.Amount;
                    break;
            }

            Console.WriteLine($"Balance: {Balance}");
        }
    }
}