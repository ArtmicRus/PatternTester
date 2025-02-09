using MediatorPattern.Examples.Youtube.BuilderLine.Abstractions;
using MediatorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MediatorPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Controller : IMediator
    {
        private Designer designer;
        private Director director;

        public Controller(Designer designer, Director director)
        {
            this.designer = designer;
            this.director = director;
            designer.SetMediator(this);
            director.SetMediator(this);
        }

        public void Notiry(Emploee emp, string msg)
        {
            if (emp is Director dir)
            {
                if (msg == "")
                {
                    designer.SetWork(false);
                }
                else
                {
                    designer.SetWork(true);
                }
            }
            else if (emp is Designer des)
            {
                if (msg == "дизайнер проектирует...")
                {
                    director.GiveCommand("");
                }
            }
        }
    }
}
