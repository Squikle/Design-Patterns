using System;

namespace Facade
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