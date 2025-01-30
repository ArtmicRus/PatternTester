using CommandPattern.Examples.Metanit.Interfaces;

namespace CommandPattern.Examples.Metanit.Entities
{
    internal class TVOnCommand : ICommand
    {
        TV tv;
        public TVOnCommand(TV tvSet)
        {
            tv = tvSet;
        }
        public void Execute()
        {
            tv.On();
        }
        public void Undo()
        {
            tv.Off();
        }
    }
}
