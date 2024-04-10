namespace Command_UndoOperation;

public interface ICommand
{
    void Call();
    void Undo();
}