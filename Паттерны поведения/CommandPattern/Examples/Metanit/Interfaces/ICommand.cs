namespace CommandPattern.Examples.Metanit.Interfaces
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
