using DecoratorPattern.Examples.Youtube.BuilderLine.Abstraction;
using DecoratorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace DecoratorPattern.Examples.Youtube.BuilderLine.Realization
{
    internal class Encryptor : Shell
    {
        private readonly IProcessor processor;

        public Encryptor(IProcessor processor) : base(processor)
        {
            this.processor = processor;
        }

        public override void Process()
        {
            Console.WriteLine("Шифрование данных->");
            processor.Process();
        }
    }
}
