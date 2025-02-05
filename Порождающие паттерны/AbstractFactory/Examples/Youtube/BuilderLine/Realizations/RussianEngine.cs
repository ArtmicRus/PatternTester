using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class RussianEngine : IEngine
    {
        public void ReleaseEngine()
        {
            Console.WriteLine("Русский двигатель");
        }
    }
}
