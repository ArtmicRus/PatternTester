namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IWorker
    {
        IWorker SetNextWorker(IWorker worker);
        string Execute(string command);
    }
}
