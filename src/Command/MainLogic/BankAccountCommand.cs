namespace Command;

public class BankAccountCommand
{
    private BankAccount account;
    private Action action;
    private int amount;

    public BankAccountCommand(BankAccount account, Action action, int amount)
    {
        this.account = account;
        this.action = action;
        this.amount = amount;
    }

    // Этот метот по вызову команды может быть реализован по разному
    // речь выше идет о хэндленге этой команды
    public void Call()
    {
        switch (action)
        {
            case Action.Deposit:
                account.Deposit(amount);
                break;
            case Action.Withdraw:
                account.Withdraw(amount);
                break;
        }
    }
}