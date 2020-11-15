using System;
using Facade.Interfaces;

namespace Facade.Classes
{
    class MotherBoardB250M : IMotherBoard
    {
        public void Start()
        {
            Console.WriteLine("Start PC");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutdown PC");
        }
    }
}