using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Abstractions;

namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Designer : Absworker
    {
        public override string Execute(string command)
        {
            if (command == "спроектировать дом")
                return "Проектировщик выполник команду: " + command;
            else 
                return base.Execute(command);
        }
    }
}
