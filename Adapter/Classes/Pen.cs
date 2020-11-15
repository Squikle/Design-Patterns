using System;
using Adapter.Interfaces;

namespace Adapter.Classes
{
    class Pen : IWriting
    {
        public void Write()
        {
            Console.WriteLine("Ручка пишет");
        }
    }
}
