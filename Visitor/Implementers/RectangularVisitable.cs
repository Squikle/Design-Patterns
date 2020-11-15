using Visitor.Interfaces;

namespace Visitor.Implementers
{
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
