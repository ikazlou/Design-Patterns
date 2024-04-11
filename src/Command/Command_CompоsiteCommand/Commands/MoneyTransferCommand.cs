namespace Command_CompositeCommand.Commands;

public class MoneyTransferCommand : CompositeBankAccountCommand
{
    public MoneyTransferCommand(BankAccount bankAccountFrom, BankAccount bankAccountTo, int amount)
    {
        AddRange(new []
        {
            new BankAccountCommand(bankAccountFrom, Action.Withdraw, amount),
            new BankAccountCommand(bankAccountTo, Action.Deposit, amount)
        });
    }

    public override void Call()
    {
        BankAccountCommand last = null;
        foreach (var cmd in this)
        {
            if (last == null || last.Success)
            {
                cmd.Call();
                last = cmd;
            }
            else
            {
                cmd.Undo();
                break;
            }
        }

    }
}