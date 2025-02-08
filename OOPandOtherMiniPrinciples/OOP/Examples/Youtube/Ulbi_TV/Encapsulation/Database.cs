namespace OOP.Examples.Youtube.Ulbi_TV.Encapsulation
{
    /// <summary>
    /// Класс пример инкапсуляции 3
    /// </summary>
    internal class Database
    {
        /// <summary>
        /// Приватные поля доступ к которым осуществляется через свойства ИЛИ методы класса
        /// </summary>
        private string url;
        private string port;
        private string username;
        private string password;
        private List<string> tables;

        public Database(string url, string port, string username, string password)
        {
            this.url = url;
            this.port = port;
            this.username = username;
            this.password = password;
            tables = new List<string>();
        }

        public void CreateNewTable(string tableName)
        {
            tables.Add(tableName);
        }

        public void ClearTable()
        {
            tables.Clear();
        }

        //public string Url { get => url; set => url = value; }
        //public string Port { get => port; set => port = value; }
        //public string Username { get => username; set => username = value; }
        //public string Password { get => password; set => password = value; }
        //public List<string> Tables { get => tables; }
    }
}
