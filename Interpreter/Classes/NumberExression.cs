using Interpreter.Interfaces;

namespace Interpreter.Classes
{
    class NumberExression : IExpression
    {
        private readonly string _key;

        public NumberExression(string key)
        {
            _key = key;
        }
        public double Interpret(Context context)
        {
            return context.GetVariable(_key);
        }
    }
}