namespace Command_UndoOperation;

public class BankAccountCommand : ICommand
{
    private readonly BankAccount _account;
    private readonly Action _action;
    private readonly int _amount;
    private bool _succeeded;

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
                _succeeded = true;
                break;
            case Action.Withdraw:
                _succeeded = _account.Withdraw(_amount);
                break;
        }
    }

    public void Undo()
    {
        if (!_succeeded) return;

        switch (_action)
        {
            case Action.Deposit:
                _account.Withdraw(_amount);
                break;
            case Action.Withdraw:
                _account.Deposit(_amount);
                break;
        }
    }
}