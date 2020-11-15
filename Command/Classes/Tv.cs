using System;
using Command.Interfaces;

namespace Command.Classes
{
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
}
