using System;
using Strategy.Classes;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            IntCalculator intCalculator = new IntCalculator(new MultiplyOperation());
            Console.WriteLine(intCalculator.Operate(5, 2));
            intCalculator.Operation = new PlusOperation();
            Console.WriteLine(intCalculator.Operate(5, 2));

            Console.ReadKey();
        }
    }
}
