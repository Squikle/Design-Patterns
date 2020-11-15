using Command.Interfaces;

namespace Command.Classes
{
    class SwitchController
    {
        public IDevice Device { private get; set; }
        public ICommand Command { private get; set; }

        public SwitchController(IDevice device, ICommand command)
        {
            Device = device;
            Command = command;
        }
        public void Action()
        {
            Command.Do(Device);
        }
        public void Undo()
        {
            Command.Undo(Device);
        }
    }
}
