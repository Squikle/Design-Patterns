using System;
using Visitor.Classes;
using Visitor.Interfaces;

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
}
