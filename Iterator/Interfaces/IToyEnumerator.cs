namespace Iterator
{
    interface IToyEnumerator
    {
        ChristmasToy GetCurrent();
        bool MoveNext();
        void Reset();
    }
}