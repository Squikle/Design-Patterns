namespace Command.Interfaces
{
    interface ICommand
    {
        void Do(IDevice device);
        void Undo(IDevice device);
    }
}
