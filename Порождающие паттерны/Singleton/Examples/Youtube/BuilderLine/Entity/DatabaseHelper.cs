namespace Singleton.Examples.Youtube.BuilderLine.Entity
{
    internal class DatabaseHelper
    {
        private string data;
        private static DatabaseHelper databaseConnection;

        private DatabaseHelper() => Console.WriteLine("Подключение к БД");
        public static DatabaseHelper GetConnection()
        {
            if (databaseConnection == null)
                databaseConnection = new DatabaseHelper();
            return databaseConnection;
        }

        public string SelectData() => data;
        public void IncertData(string d)
        {
            Console.WriteLine("Новые данные: " + d + ", внесены в БД");
            data = d;
        }
    }
}
