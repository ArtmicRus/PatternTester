using TemplateMethod.Examples.Youtube.BuilderLine.Abstractions;

namespace TemplateMethod.Examples.Youtube.BuilderLine.Realizations
{
    internal class AnalogTransmitter : Transmitter
    {
        protected override void Modulation()
        {
            Console.WriteLine("Модуляция аналогового сигнала");
        }
    }
}
