using InterpreterPattern.Examples.Metanit.Entity;
using InterpreterPattern.Examples.Metanit.Interfaces;

namespace InterpreterPattern.Examples.Metanit.Realizations
{
    // терминальное выражение
    class NumberExpression : IExpression
    {
        string name; // имя переменной
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
