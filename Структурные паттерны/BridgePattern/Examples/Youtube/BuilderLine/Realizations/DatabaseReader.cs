using BridgePattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BridgePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class DatabaseReader : IDataReader // Есть такой же системный интерфейс, зачем же он нужен?
    {
        public void Read()
        {
            Console.WriteLine("Данные из БД");
        }
    }
}
