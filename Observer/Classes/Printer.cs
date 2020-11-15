using System;
using Observer.Interfaces;

namespace Observer.Classes
{
    class Printer : IObserver
    {
        public void Update(string notification)
        {
            Console.WriteLine(notification);
        }
    }
}
