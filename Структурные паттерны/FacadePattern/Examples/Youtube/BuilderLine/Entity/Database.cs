namespace FacadePattern.Examples.Youtube.BuilderLine.Entity
{
    internal class Database
    {
        public void Insert() => Console.WriteLine("Добавлеие товара в БД");
        public void Del() => Console.WriteLine("Удаление товара из БД");
    }
}
