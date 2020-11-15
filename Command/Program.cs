using System;
using Command.Classes;

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
    }
}
