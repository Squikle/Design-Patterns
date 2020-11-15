using System;
using Iterator.Classes;

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
}
