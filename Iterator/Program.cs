using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            ChristmasTree christmasTree = new ChristmasTree();
            ChristmasToy christmasToy = new ChristmasToy("red");
            christmasTree.HangToy(christmasToy);
            christmasTree.HangToy(new ChristmasToy("black"));
            christmasTree.HangToy(new ChristmasToy("green"));

            var enumerator = christmasTree.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.GetCurrent());
            }

            Console.WriteLine("\n\nChange Toy:\n");
            christmasTree.TakeOffToy(christmasToy);
            christmasTree.HangToy(new ChristmasToy("golden"));

            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.GetCurrent());
            }

            Console.WriteLine("\n\nBox with Toys also:\n");
            BoxWithToys boxWithToys = new BoxWithToys();
            boxWithToys.PutToy(new ChristmasToy("red"));
            boxWithToys.PutToy(new ChristmasToy("green"));
            boxWithToys.PutToy(new ChristmasToy("blue"));
            enumerator = boxWithToys.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.GetCurrent());
            }

            Console.WriteLine("\n\nPour out Toys:\n");
            boxWithToys.PourOutToys();
            enumerator.Reset();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.GetCurrent());
            }

            Console.ReadKey();
        }
    }

    interface IToyEnumerable
    {
        IToyEnumerator GetEnumerator();
        int Count { get; }
        ChristmasToy this[int index] { get; }
    }
    interface IToyEnumerator
    {
        ChristmasToy GetCurrent();
        bool MoveNext();
        void Reset();
    }

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

    class ChristmasToy
    {
        public string Color { get; set; }

        public ChristmasToy(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return Color;
        }
    }
}
