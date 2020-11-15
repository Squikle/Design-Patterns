namespace Iterator
{
    class ToyEnumerator : IToyEnumerator
    {
        private readonly IToyEnumerable _aggregate;
        private int _current = -1;
        public ToyEnumerator(IToyEnumerable aggregate)
        {
            _aggregate = aggregate;
        }

        public ChristmasToy GetCurrent()
        {
            return _aggregate[_current];
        }

        public bool MoveNext()
        {
            return ++_current < _aggregate.Count;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}