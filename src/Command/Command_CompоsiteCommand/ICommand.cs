namespace Command_CompositeCommand
{
    public interface ICommand
    {
        void Call();
        void Undo();

        public bool Success { get; set; }
    }
}