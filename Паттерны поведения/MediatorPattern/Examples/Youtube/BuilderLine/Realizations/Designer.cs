using MediatorPattern.Examples.Youtube.BuilderLine.Abstractions;
using MediatorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MediatorPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Designer : Emploee
    {
        private bool isWorking;
        public Designer(IMediator mediator = null) : base(mediator)
        {
        }

        public void ExecuteWork()
        {
            Console.WriteLine("<-Дизайнер в работе");
            mediator.Notiry(this, "дизайнер проектирует...");
        }

        public void SetWork(bool state)
        {
            isWorking = state;
            if(state)
                Console.WriteLine("<-Дизайнер освобождён от работы");
            else
                Console.WriteLine("<-Дизайнер занят");
        }
    }
}
