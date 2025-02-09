using CommandPattern.Examples.Youtube.BuilderLine.Entity;
using CommandPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace CommandPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class ConveyorWorkCommand : ICommand
    {
        private readonly Conveyor _conveyor;

        public ConveyorWorkCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }
        public void Positive()
        {
            _conveyor.On();
        }

        public void Negative()
        {
            _conveyor.Off();
        }
    }
}
