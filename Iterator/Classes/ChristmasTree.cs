using System.Collections.Generic;
using Iterator.Interfaces;

namespace Iterator.Classes
{
    class ChristmasTree : IToyEnumerable
    {
        private readonly List<ChristmasToy> _toys;
        public ChristmasTree()
        {
            _toys = new List<ChristmasToy>();
        }
        public void HangToy(ChristmasToy christmasToy)
        {
            _toys.Add(christmasToy);
        }
        public void TakeOffToy(ChristmasToy christmasToy)
        {
            _toys.Remove(christmasToy);
        }
        public IToyEnumerator GetEnumerator()
        {
            return new ToyEnumerator(this);
        }
        public int Count => _toys.Count;
        public ChristmasToy this[int index] => _toys[index];
    }
}