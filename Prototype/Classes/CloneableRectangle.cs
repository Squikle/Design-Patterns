using Prototype.Interfaces;

namespace Prototype.Classes
{
    class CloneableRectangle : ICloneableRectangle
    {
        public Size Size { get; set; }
        public CloneableRectangle(Size size)
        {
            Size = size;
        }

        public override string ToString()
        {
            return $"{Size.Width}x{Size.Height}";
        }

        public ICloneableRectangle Clone()
        {
            return new CloneableRectangle(new Size(Size.Width, Size.Height));
        }
    }
}
