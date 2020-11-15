namespace Iterator
{
    interface IToyEnumerable
    {
        IToyEnumerator GetEnumerator();
        int Count { get; }
        ChristmasToy this[int index] { get; }
    }
}