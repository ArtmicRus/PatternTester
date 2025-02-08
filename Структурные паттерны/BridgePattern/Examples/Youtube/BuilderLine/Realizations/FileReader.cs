using BridgePattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BridgePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class FileReader : IDataReader
    {
        public void Read()
        {
            Console.WriteLine("Данные из файла");
        }
    }
}
