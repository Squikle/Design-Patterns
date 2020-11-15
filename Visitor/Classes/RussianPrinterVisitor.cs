using System;
using Visitor.Interfaces;

namespace Visitor.Classes
{
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
}
