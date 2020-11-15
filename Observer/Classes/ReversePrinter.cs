using System;
using Observer.Interfaces;

namespace Observer.Classes
{
    class ReversePrinter : IObserver
    {
        public void Update(string notification)
        {
            char[] charArray = notification.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
