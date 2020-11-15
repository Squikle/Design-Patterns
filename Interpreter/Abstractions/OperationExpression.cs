namespace Interpreter
{
    abstract class OperationExpression : IExpression
    {
        protected IExpression LeftExpression;
        protected IExpression RightExpression;

        protected OperationExpression(IExpression leftExpression, IExpression rightExpression)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
        }
        public abstract double Interpret(Context context);
    }
}