using Strategy.Interfaces;

namespace Strategy.Classes
{
    class MultiplyOperation : IOperation
    {
        public int Operate(int a, int b)
        {
            return a * b;
        }
    }
}
