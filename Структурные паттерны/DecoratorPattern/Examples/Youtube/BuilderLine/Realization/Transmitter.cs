using DecoratorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace DecoratorPattern.Examples.Youtube.BuilderLine.Realization
{
    internal class Transmitter : IProcessor
    {
        private string _data;

        public Transmitter(string data)
        {
            _data = data;
        }

        public void Process()
        {
            Console.WriteLine("Данные: " + _data + " переданы по каналу связи");
        }
    }
}
