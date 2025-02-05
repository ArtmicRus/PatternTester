namespace Singleton.Examples.MetanitExamples.PatternMultithreadingExample
{
    /// <summary>
    /// Операционная система компьютера
    /// </summary>
    internal class MultithreadingOS
    {
        /// <summary>
        /// Экземпляк ОС
        /// </summary>
        private static MultithreadingOS instance;

        /// <summary>
        /// Название ОС
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Объект который блокирует доступ к ОС во время работы с ней
        /// </summary>
        private static object syncRoot = new object();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Наименование ОС</param>
        protected MultithreadingOS(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Получение представления ОС
        /// </summary>
        /// <param name="name">Имя ОС для получения</param>
        /// <returns>Экземпляр ОС</returns>
        public static MultithreadingOS getInstance(string name)
        {
            if (instance == null)
            {
                // Чтобы избежать одновременного доступа к коду из разных потоков
                // критическая секция заключается в блок lock.
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new MultithreadingOS(name);
                }
            }
            return instance;
        }
    }
}
