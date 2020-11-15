using Visitor.Interfaces;

namespace Visitor.Implementers
{
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
}
