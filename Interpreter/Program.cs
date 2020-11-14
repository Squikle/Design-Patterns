using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            Context context = new Context();
            context.SetVariable("a", 10);
            context.SetVariable("b", 20);
            IExpression expression = new DivideExpression(
                new AddExpression(new NumberExression("a"), new NumberExression("b")),
                new SubExpression(
                    new NumberExression("a"),new MultiplyExpression(
                        new NumberExression("a"), new NumberExression("b"))));
            Console.WriteLine(expression.Interpret(context));
            Console.ReadKey();
        }
    }

    class Context
    {
        private readonly Dictionary<string, double> _variables = new Dictionary<string, double>();

        public void SetVariable(string key, double variable)
        {
            _variables[key] = variable;
        }

        public double GetVariable(string key)
        {
            return _variables[key];
        }
    }

    interface IExpression
    {
        double Interpret(Context context);
    }

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
    class AddExpression : OperationExpression
    {
        public AddExpression(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression) { }

        public override double Interpret(Context context)
        {
            return LeftExpression.Interpret(context) + RightExpression.Interpret(context);
        }
    }
    class SubExpression : OperationExpression
    {
        public SubExpression(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression) { }

        public override double Interpret(Context context)
        {
            return LeftExpression.Interpret(context) - RightExpression.Interpret(context);
        }
    }
    class MultiplyExpression : OperationExpression
    {
        public MultiplyExpression(IExpression leftExpression, IExpression rightExpression)
            : base(leftExpression, rightExpression) { }

        public override double Interpret(Context context)
        {
            return LeftExpression.Interpret(context) * RightExpression.Interpret(context);
        }
    }
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
