using MediatorPattern.Examples.Youtube.BuilderLine.Abstractions;
using MediatorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MediatorPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Director : Emploee
    {
        private string text;
        public Director(IMediator mediator = null) : base(mediator)
        {
        }

        public void GiveCommand(string command)
        {
            text = command;
            if (text == "")
            {
                Console.WriteLine("->Директор знает что дизайнер уже работает");
            }
            else
            {
                Console.WriteLine("->Директор дал команду: " + text);
            }
            mediator.Notiry(this, text);
        }
    }
}
