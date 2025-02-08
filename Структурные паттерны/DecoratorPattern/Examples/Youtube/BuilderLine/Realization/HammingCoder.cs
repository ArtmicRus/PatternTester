using DecoratorPattern.Examples.Youtube.BuilderLine.Abstraction;
using DecoratorPattern.Examples.Youtube.BuilderLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Examples.Youtube.BuilderLine.Realization
{
    internal class HammingCoder : Shell
    {
        private readonly IProcessor processor;

        public HammingCoder(IProcessor processor) : base(processor)
        {
            this.processor = processor;
        }

        public override void Process()
        {
            Console.WriteLine("Наложен помехоустойчивый код Хамминга->");
            processor.Process();
        }
    }
}
