using System;
using State.Interfaces;

namespace State.Classes
{
    class NormalWalkState : IWalkState
    {
        public void WalkFaster(IWalker walker)
        {
            walker.State = new RunningWalkState();
            Console.WriteLine("Бежим");
        }

        public void WalkSlower(IWalker walker)
        {
            walker.State = new SlowWalkState();
            Console.WriteLine("Замедляемся к минимальной скорости");
        }
    }
}
