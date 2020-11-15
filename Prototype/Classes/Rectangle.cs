using System;

namespace Prototype.Classes
{
    class Rectangle : ICloneable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Width}x{Height}";
        }

        public object Clone()
        {
            return new Rectangle(Width, Height);
        }
    }
}
