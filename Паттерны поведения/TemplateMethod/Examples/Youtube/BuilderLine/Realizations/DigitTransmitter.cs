using TemplateMethod.Examples.Youtube.BuilderLine.Abstractions;

namespace TemplateMethod.Examples.Youtube.BuilderLine.Realizations
{
    internal class DigitTransmitter : Transmitter
    {
        protected override void Simpling()
        {
            Console.WriteLine("Дискритизация записанного фрагмента");
        }

        protected override void Digitization()
        {
            Console.WriteLine("Оцифровка");
        }

        protected override void Modulation()
        {
            Console.WriteLine("Модуляция цифрового сигнала");
        }
    }
}
