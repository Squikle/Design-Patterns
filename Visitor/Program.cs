using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            IVisitor russianPrinterVisitor = new RussianPrinterVisitor();
            IVisitor englishPrinterVisitor = new EnglishPrinterVisitor();

            IVisitable squareBox = new SquareVisitable(10);
            squareBox.AcceptVisitor(russianPrinterVisitor);
            squareBox.AcceptVisitor(englishPrinterVisitor);

            Console.WriteLine();

            IVisitable rectangularBox = new RectangularVisitable(5, 10,10);
            rectangularBox.AcceptVisitor(russianPrinterVisitor);
            rectangularBox.AcceptVisitor(englishPrinterVisitor);

            Console.ReadKey();
        }
    }

    interface IVisitor
    {
        void VisitSquareBox(SquareVisitable visitable);
        void VisitRectangularBox(RectangularVisitable visitable);
    }

    class RussianPrinterVisitor : IVisitor
    {
        public void VisitSquareBox(SquareVisitable visitable)
        {
            Console.WriteLine($"Все стороны коробки равны {visitable.SideSize}");
        }

        public void VisitRectangularBox(RectangularVisitable visitable)
        {
            Console.WriteLine($"Размер коробки: {visitable.Width}x{visitable.Height}x{visitable.Length}");
        }
    }
    class EnglishPrinterVisitor : IVisitor
    {
        public void VisitSquareBox(SquareVisitable visitable)
        {
            Console.WriteLine($"All sides of box are {visitable.SideSize}");
        }

        public void VisitRectangularBox(RectangularVisitable visitable)
        {
            Console.WriteLine($"Size of box is: {visitable.Width}x{visitable.Height}x{visitable.Length}");
        }
    }

    interface IVisitable
    {
        void AcceptVisitor(IVisitor visitor);
    }

    class SquareVisitable : IVisitable
    {
        public int SideSize;
        public SquareVisitable(int sideSize)
        {
            SideSize = sideSize;
        }
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitSquareBox(this);
        }
    }

    class RectangularVisitable : IVisitable
    {
        public int Width;
        public int Height;
        public int Length;

        public RectangularVisitable(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitRectangularBox(this);
        }
    }
}
