namespace TemplateMethod.Examples.Youtube.BuilderLine.Abstractions
{
    internal class Transmitter
    {
        protected virtual void VoiceRecord() => Console.WriteLine("Запись фрагмента речи");
        protected virtual void Simpling() { }
        protected virtual void Digitization() { }
        protected virtual void Modulation() { }
        protected virtual void Transmission() => Console.WriteLine("Передача сигнала по радиоканалу");

        public void ProcessStart()
        {
            VoiceRecord();
            Simpling();
            Digitization();
            Modulation();
            Transmission();
        }
    }
}
