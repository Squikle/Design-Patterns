using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            SwitchController controller = new SwitchController(new Tv(), new OnCommand());
            controller.Action(); 
            controller.Command = new OffCommand();
            controller.Action();

            controller.Device = new Fan();
            controller.Command = new OnCommand();
            controller.Action();
            controller.Undo();

            Console.ReadKey();
        }

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
