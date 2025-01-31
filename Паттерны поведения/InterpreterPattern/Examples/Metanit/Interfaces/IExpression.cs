using InterpreterPattern.Examples.Metanit.Entity;

namespace InterpreterPattern.Examples.Metanit.Interfaces
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}
