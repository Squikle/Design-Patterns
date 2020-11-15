using Strategy.Interfaces;

namespace Strategy.Classes
{
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
