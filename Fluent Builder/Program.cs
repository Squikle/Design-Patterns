using System;
using Fluent_Builder.Classes;

namespace Fluent_Builder
{
    class Program
    {
        static void Main()
        {
            Carpenter carpenter = new Carpenter();
            var table = carpenter.CreateTable().WithLegsMaterial("wooden").WithTopMaterial("glass").Build();
            Console.WriteLine($"table with {table.Legs} legs and {table.Top} top");

            Console.ReadKey();
        }
    }
}
