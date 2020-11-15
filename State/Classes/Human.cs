using State.Interfaces;

namespace State.Classes
{
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
}
