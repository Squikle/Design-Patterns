using System;
using State.Interfaces;

namespace State.Classes
{
    class RunningWalkState : IWalkState
    {
        public void WalkFaster(IWalker walker)
        {
            Console.WriteLine("Бежим максимально быстро");
        }

        public void WalkSlower(IWalker walker)
        {
            walker.State = new NormalWalkState();
            Console.WriteLine("Замедляемся к нормальной скорости");
        }
    }
}
