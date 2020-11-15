using Interpreter.Abstractions;
using Interpreter.Interfaces;

namespace Interpreter.Classes
{
    class DivideExpression : OperationExpression
    {
        public DivideExpression(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression) { }

        public override double Interpret(Context context)
        {
            return LeftExpression.Interpret(context) / RightExpression.Interpret(context);
        }
    }
}