using Command.Interfaces;

namespace Command.Classes
{
    class OffCommand : ICommand
    {
        public void Do(IDevice device)
        {
            device.Off();
        }
        public void Undo(IDevice device)
        {
            device.On();
        }
    }
}
