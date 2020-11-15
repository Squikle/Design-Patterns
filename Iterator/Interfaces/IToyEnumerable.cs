using Iterator.Classes;

namespace Iterator.Interfaces
{
    interface IToyEnumerable
    {
        IToyEnumerator GetEnumerator();
        int Count { get; }
        ChristmasToy this[int index] { get; }
    }
}