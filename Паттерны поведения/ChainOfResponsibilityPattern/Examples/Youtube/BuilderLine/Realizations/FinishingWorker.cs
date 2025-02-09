using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Abstractions;

namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class FinishingWorker : Absworker
    {
        public override string Execute(string command)
        {
            if (command == "клеить обои")
            {
                return "Рабочий внутренней отделки выполнил команду: " + command;
            }
            else
            {
                return base.Execute(command);
            }
        }
    }
}
