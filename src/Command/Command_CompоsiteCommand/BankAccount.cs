namespace Command_CompositeCommand
{
    public class BankAccount
    {
        private int _balance;
        private const int OverdraftLimit = -500;

        public BankAccount(int balance)
        {
            _balance = balance;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance = ${_balance}");
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount >= OverdraftLimit)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance = ${_balance}");
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}