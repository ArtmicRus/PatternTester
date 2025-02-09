using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Abstractions
{
    internal abstract class Absworker : IWorker
    {
        private IWorker nextWorker;

        protected Absworker()
        {
            nextWorker = null;
        }

        public IWorker SetNextWorker(IWorker worker)
        {
            nextWorker = worker;
            return worker;
        }

        public virtual string Execute(string command)
        {
            if (nextWorker != null)
                return nextWorker.Execute(command);
            return string.Empty;
        }
    }
}
