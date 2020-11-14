using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            SwitchController controller = new SwitchController(new Tv());
            controller.Action(new OnCommand());
            controller.Action(new OffCommand());

            controller.Device = new Fan();
            controller.Action(new OnCommand());
            controller.Action(new OffCommand());

            Console.ReadKey();
        }

        class SwitchController
        {
            public IDevice Device { private get; set; }

            public SwitchController(IDevice device)
            {
                Device = device;
            }
            public void Action(ICommand command)
            {
                command.Do(Device);
            }
            public void Undo(ICommand command)
            {
                command.Undo(Device);
            }
        }
        interface ICommand
        {
            void Do(IDevice device);
            void Undo(IDevice device);
        }

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

        interface IDevice
        {
            void On();
            void Off();
        }

        class Tv : IDevice
        {
            public void Off()
            {
                Console.WriteLine("Tv off");
            }

            public void On()
            {
                Console.WriteLine("Tv on");
            }
        }

        class Fan : IDevice
        {
            public void Off()
            {
                Console.WriteLine("Fan off");
            }

            public void On()
            {
                Console.WriteLine("Fan on");
            }
        }
    }
}
