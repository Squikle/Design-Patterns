using System;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            //значимый тип
            Console.WriteLine("\nЗначимый тип:");
            Rectangle first = new Rectangle(5,10);
            Console.WriteLine(first);

            Rectangle second = first.Clone() as Rectangle;
            Console.WriteLine(second);

            first.Height = 50;
            Console.WriteLine(first);
            Console.WriteLine(second);

            //ссылочный тип
            Console.WriteLine("\nСсылочный тип:");
            ICloneableRectangle cloneableRectangle = new CloneableRectangle(new Size(10, 20));
            Console.WriteLine(cloneableRectangle);

            ICloneableRectangle clonedCloneableRectangle = cloneableRectangle.Clone();
            Console.WriteLine(clonedCloneableRectangle);

            cloneableRectangle.Size = new Size(100, 100);
            Console.WriteLine(cloneableRectangle);
            Console.WriteLine(clonedCloneableRectangle);

            Console.ReadKey();
        }
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

        // ссылочный тип, глубокое копирование
        interface ICloneableRectangle
        {
            Size Size { get; set; }
            ICloneableRectangle Clone();
        }
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

        class Size
        {
            public int Width;
            public int Height;

            public Size(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }
    }
}
