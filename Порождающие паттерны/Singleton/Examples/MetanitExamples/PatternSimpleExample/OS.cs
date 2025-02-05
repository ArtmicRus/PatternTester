namespace Singleton.Examples.MetanitExamples.PatternSimpleExample
{
    /// <summary>
    /// Операционная система компьютера
    /// </summary>
    internal class OS
    {
        /// <summary>
        /// Экземпляк ОС
        /// </summary>
        private static OS instance;

        /// <summary>
        /// Название ОС
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Наименование ОС</param>
        protected OS(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Получение представления ОС
        /// </summary>
        /// <param name="name">Имя ОС для получения</param>
        /// <returns>Экземпляр ОС</returns>
        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
