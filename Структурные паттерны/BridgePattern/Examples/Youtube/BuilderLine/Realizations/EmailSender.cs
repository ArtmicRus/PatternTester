using BridgePattern.Examples.Youtube.BuilderLine.Abstractions;
using BridgePattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BridgePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class EmailSender : Sender
    {
        public EmailSender(IDataReader reader) : base(reader)
        {
        }

        public override void Send()
        {
            _reader.Read();
            Console.WriteLine("Отправка при помощи почты");
        }
    }
}
