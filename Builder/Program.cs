using System;

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

        class Carpenter
        {
            public Table CreateTable(Builder builder)
            {
                builder.CreateTable();
                builder.CreateLegs();
                builder.CreateTop();
                return builder.Table;
            }
        }

        class Table
        {
            public string Top { get; set; }
            public string Legs { get; set; }
        }

        abstract class Builder
        {
            public Table Table;

            public void CreateTable()
            {
               Table = new Table();
            }
            public abstract void CreateTop();
            public abstract void CreateLegs();
        }

        class WoodenTableBuilder : Builder
        {
            public override void CreateLegs()
            {
                Table.Legs = "WoodenLegs";
            }

            public override void CreateTop()
            {
                Table.Top = "WoodenTop";
            }
        }

        class IronTableBuilder : Builder
        {
            public override void CreateLegs()
            {
                Table.Legs = "IronLegs";
            }

            public override void CreateTop()
            {
                Table.Top = "IronTop";
            }
        }
    }
}
