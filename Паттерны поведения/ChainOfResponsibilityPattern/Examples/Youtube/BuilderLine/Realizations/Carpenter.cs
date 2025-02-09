using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Abstractions;

namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Carpenter : Absworker
    {
        public override string Execute(string command)
        {
            if (command == "класть кирпич")
                return "Плотник выполнил команду: " + command;
            else
                return base.Execute(command);
        }
    }
}
