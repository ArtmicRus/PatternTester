using InterpreterPattern.Examples.Metanit.Entity;
using InterpreterPattern.Examples.Metanit.Interfaces;

namespace InterpreterPattern.Examples.Metanit.Realizations
{
    // нетерминальное выражение для сложения
    class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}
