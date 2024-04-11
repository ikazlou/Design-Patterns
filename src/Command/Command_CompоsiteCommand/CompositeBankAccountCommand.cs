namespace Command_CompositeCommand;

public class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
{
    public CompositeBankAccountCommand()
    {

    }

    public CompositeBankAccountCommand(IEnumerable<BankAccountCommand> collection) : base(collection)
    {

    }

    public bool Success { get; set; }

    public virtual void Call()
    {
        Success = true;
        ForEach(cmd =>
        {
            cmd.Call();
            Success &= cmd.Success;
        });
    }

    public virtual void Undo()
    {
        foreach (var cmd in ((IEnumerable<BankAccountCommand>)this).Reverse())
        {
            cmd.Undo();
        }
    }

}