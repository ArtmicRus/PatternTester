using CommandPattern.Examples.Youtube.BuilderLine.Entity;
using CommandPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace CommandPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class ConveyorAdjustCommand : ICommand
    {
        private readonly Conveyor _conveyor;

        public ConveyorAdjustCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }

        public void Positive()
        {
            _conveyor.SpeedIncrease();
        }

        public void Negative()
        {
            _conveyor.SpeedDecrease();
        }
    }
}
