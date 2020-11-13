using System;

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

        interface IOperation
        {
            int Operate(int a, int b);
        }

        class PlusOperation : IOperation
        {
            public int Operate(int a, int b)
            {
                return a + b;
            }
        }
        class MultiplyOperation : IOperation
        {
            public int Operate(int a, int b)
            {
                return a * b;
            }
        }

        class IntCalculator
        {
            public IOperation Operation { get; set; }

            public IntCalculator(IOperation operation)
            {
                Operation = operation;
            }

            public int Operate(int a, int b)
                => Operation.Operate(a, b);
        }
    }
}
