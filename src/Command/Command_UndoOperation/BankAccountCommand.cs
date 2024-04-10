namespace Command_UndoOperation;

public class BankAccountCommand : ICommand
{
    private BankAccount account;
    private Action action;
    private int amount;
    private bool succseded;

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
                succseded = true;
                break;
            case Action.Withdraw:
                succseded = account.Withdraw(amount);
                break;
        }
    }

    public void Undo()
    {
        if (!succseded) return;

        switch (action)
        {
            case Action.Deposit:
                account.Withdraw(amount);
                break;
            case Action.Withdraw:
                account.Deposit(amount);
                break;
        }
    }
}