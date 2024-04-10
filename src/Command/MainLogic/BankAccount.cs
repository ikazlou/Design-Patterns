namespace Command;

public class BankAccount
{
    private int balance;
    private readonly int _overdraftLimit = -500;

    public void Deposit(int amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount}, balance = ${balance}");
    }

    public void Withdraw(int amount)
    {
        if (balance - amount >= _overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew ${amount}, balance = ${balance}");
        }
    }

    public override string ToString()
    {
        return $"{nameof(balance)}: {balance}";
    }
}