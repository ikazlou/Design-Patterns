namespace Command_UndoOperation;

public class BankAccount
{
    private int balance;
    private readonly int overdraftLimit = -500;

    public BankAccount(int balance)
    {
        this.balance = balance;
    }

    public void Deposit(int amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount}, balance = ${balance}");
    }

    public bool Withdraw(int amount)
    {
        if (balance - amount >= overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew ${amount}, balance = ${balance}");
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"{nameof(balance)}: {balance}";
    }
}