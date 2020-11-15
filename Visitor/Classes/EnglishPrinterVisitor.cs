using System;
using Visitor.Interfaces;

namespace Visitor.Classes
{
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
}
