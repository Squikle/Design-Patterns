using System.Collections.Generic;

namespace Iterator
{
    class BoxWithToys : IToyEnumerable
    {
        private readonly List<ChristmasToy> _toys;
        public BoxWithToys()
        {
            _toys = new List<ChristmasToy>();
        }
        public void PutToy(ChristmasToy christmasToy)
        {
            _toys.Add(christmasToy);
        }
        public void PourOutToys()
        {
            _toys.Clear();
        }
        public IToyEnumerator GetEnumerator()
        {
            return new ToyEnumerator(this);
        }
        public int Count => _toys.Count;
        public ChristmasToy this[int index] => _toys[index];
    }
}