using Visitor.Classes;

namespace Visitor.Interfaces
{
    interface IVisitor
    {
        void VisitSquareBox(SquareVisitable visitable);
        void VisitRectangularBox(RectangularVisitable visitable);
    }
}
