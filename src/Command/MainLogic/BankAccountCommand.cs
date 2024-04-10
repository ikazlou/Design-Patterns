namespace Command;

public class BankAccountCommand
{
    private readonly BankAccount _account;
    private readonly Action _action;
    private readonly int _amount;

    public BankAccountCommand(BankAccount account, Action action, int amount)
    {
        _account = account;
        _action = action;
        _amount = amount;
    }

    // Этот метот по вызову команды может быть реализован по разному
    // речь выше идет о хэндленге этой команды
    public void Call()
    {
        switch (_action)
        {
            case Action.Deposit:
                _account.Deposit(_amount);
                break;
            case Action.Withdraw:
                _account.Withdraw(_amount);
                break;
        }
    }
}