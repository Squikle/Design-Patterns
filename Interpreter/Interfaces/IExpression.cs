namespace Interpreter
{
    interface IExpression
    {
        double Interpret(Context context);
    }
}