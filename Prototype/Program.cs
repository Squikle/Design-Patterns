using System;
using Prototype.Classes;
using Prototype.Interfaces;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            //значимый тип
            Console.WriteLine("Значимый тип:");
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
    }
}
