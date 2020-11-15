using Interpreter.Classes;

namespace Interpreter.Interfaces
{
    interface IExpression
    {
        double Interpret(Context context);
    }
}