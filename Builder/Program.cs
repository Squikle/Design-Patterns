using System;
using Builder.Classes;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            Carpenter carpenter = new Carpenter();
            var table = carpenter.CreateTable(new WoodenTableBuilder());
            Console.WriteLine(table.Legs + " " + table.Top);

            table = carpenter.CreateTable(new IronTableBuilder());
            Console.WriteLine(table.Legs + " " + table.Top);

            Console.ReadKey();
        }
    }
}
