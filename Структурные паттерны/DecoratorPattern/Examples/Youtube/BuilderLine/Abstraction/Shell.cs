using DecoratorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace DecoratorPattern.Examples.Youtube.BuilderLine.Abstraction
{
    internal abstract class Shell : IProcessor
    {
        protected IProcessor _processor;

        protected Shell(IProcessor processor)
        {
            _processor = processor;
        }

        public virtual void Process()
        {
            _processor.Process();
        }
    }
}
