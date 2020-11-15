using System;
using State.Interfaces;

namespace State.Classes
{
    class SlowWalkState : IWalkState
    {
        public void WalkFaster(IWalker walker)
        {
            walker.State = new NormalWalkState();
            Console.WriteLine("Идем со средней скоростью");
        }

        public void WalkSlower(IWalker walker)
        {
            Console.WriteLine("Идем максимально медленно");
        }
    }
}
