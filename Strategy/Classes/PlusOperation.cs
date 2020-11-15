using Strategy.Interfaces;

namespace Strategy.Classes
{
    class PlusOperation : IOperation
    {
        public int Operate(int a, int b)
        {
            return a + b;
        }
    }
}
