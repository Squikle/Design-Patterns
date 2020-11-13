using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            IWalker human = new Human(new SlowWalkState());
            human.WalkFaster();

            human.WalkSlower();
            human.WalkSlower();

            human.WalkFaster();
            human.WalkFaster();
            human.WalkFaster();

            human.WalkSlower();
            human.WalkSlower();

            human.WalkFaster();

            Console.ReadKey();
        }

        interface IWalker
        {
            IWalkState State { get; set; }
            void WalkSlower();
            void WalkFaster();
        }

        class Human : IWalker
        {
            public IWalkState State { get; set; }

            public Human(IWalkState state)
            {
                State = state;
            }

            public void WalkSlower()
            {
                State.WalkSlower(this);
            }

            public void WalkFaster()
            {
                State.WalkFaster(this);
            }
        }

        interface IWalkState
        {
            void WalkFaster(IWalker walker);
            void WalkSlower(IWalker walker);
        }

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
}
