using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class JapaneseEngine : IEngine
    {
        public void ReleaseEngine()
        {
            Console.WriteLine("Японский двигатель");
        }
    }
}
