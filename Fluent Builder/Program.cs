using System;

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

        class Table
        {
            public string Top { get; set; }
            public string Legs { get; set; }
        }

        class Carpenter
        {
            private Table _table;

            public Carpenter CreateTable()
            {
                _table = new Table();
                return this;
            }

            public Carpenter WithTopMaterial(string topType)
            {
                _table.Top = topType;
                return this;
            }
            public Carpenter WithLegsMaterial(string legsType)
            {
                _table.Legs = legsType;
                return this;
            }

            public Table Build()
                => _table;
        }
    }
}
