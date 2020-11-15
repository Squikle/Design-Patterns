using System;
using Observer.Classes;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            ObservableList<int> list = new ObservableList<int>();
            Printer printer = new Printer();
            list.AddObserver(printer);
            list.AddObserver(new ReversePrinter());
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            list.RemoveObserver(printer);
            for (int i = 0; i < 5; i++)
            {
                list.Remove(i);
            }

            Console.ReadKey();
        }
    }
}
