using Iterator.Classes;

namespace Iterator.Interfaces
{
    interface IToyEnumerator
    {
        ChristmasToy GetCurrent();
        bool MoveNext();
        void Reset();
    }
}