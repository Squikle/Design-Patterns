namespace State.Interfaces
{
    interface IWalkState
    {
        void WalkFaster(IWalker walker);
        void WalkSlower(IWalker walker);
    }
}
