namespace OOP.Examples.Youtube.Ulbi_TV.Encapsulation
{
    /// <summary>
    /// Класс пример инкапсуляции 2
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Приватные поля доступ к которым осуществляется через свойства ИЛИ методы класса
        /// </summary>
        private readonly long _id;
        private string username;
        private string password;

        /// <summary>
        /// Конструктор генерирующий случайны Id
        /// </summary>
        public User(string username, string password)
        {
            this.password = password;
            this.username = username;

            Random random = new Random();
            _id = random.NextInt64();
        }

        /// <summary>
        /// Публичные свойства для работы с приватными полями
        /// </summary>
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public long Id => _id;
    }
}
