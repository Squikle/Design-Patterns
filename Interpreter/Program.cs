using System;

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
}
