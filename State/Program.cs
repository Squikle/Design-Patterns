using System;
using State.Classes;
using State.Interfaces;

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
    }
}
