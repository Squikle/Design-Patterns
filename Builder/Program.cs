using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            var table = customer.OrderTable(new IronTableCarpenter());
            Console.WriteLine(table.Legs + " " + table.Top);

            table = customer.OrderTable(new WoodenTableCarpenter());
            Console.WriteLine(table.Legs + " " + table.Top);

            Console.ReadKey();
        }

        class Customer
        {
            public Table OrderTable(Carpenter carpenter)
            {
                carpenter.CreateTable();
                carpenter.CreateLegs();
                carpenter.CreateTop();
                return carpenter.Table;
            }
        }

        class Table
        {
            public string Top { get; set; }
            public string Legs { get; set; }
        }

        abstract class Carpenter
        {
            public Table Table;

            public void CreateTable()
            {
               Table = new Table();
            }
            public abstract void CreateTop();
            public abstract void CreateLegs();
        }

        class WoodenTableCarpenter : Carpenter
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

        class IronTableCarpenter : Carpenter
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
