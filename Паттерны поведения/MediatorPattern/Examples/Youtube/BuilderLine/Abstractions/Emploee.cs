using MediatorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MediatorPattern.Examples.Youtube.BuilderLine.Abstractions
{
    internal abstract class Emploee
    {
        protected IMediator mediator;

        protected Emploee(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
