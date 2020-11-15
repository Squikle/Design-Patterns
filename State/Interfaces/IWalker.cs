namespace State.Interfaces
{
    interface IWalker
    {
        IWalkState State { get; set; }
        void WalkSlower();
        void WalkFaster();
    }
}
