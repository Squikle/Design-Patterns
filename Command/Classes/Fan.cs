using System;
using Command.Interfaces;

namespace Command.Classes
{
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
