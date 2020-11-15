namespace Interpreter
{
    class SubExpression : OperationExpression
    {
        public SubExpression(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression) { }

        public override double Interpret(Context context)
        {
            return LeftExpression.Interpret(context) - RightExpression.Interpret(context);
        }
    }
}