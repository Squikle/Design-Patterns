using Command.Interfaces;

namespace Command.Classes
{
    class OnCommand : ICommand
    {
        public void Do(IDevice device)
        {
            device.On();
        }
        public void Undo(IDevice device)
        {
            device.Off();
        }
    }
}
