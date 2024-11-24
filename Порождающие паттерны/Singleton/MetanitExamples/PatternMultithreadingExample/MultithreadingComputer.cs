namespace Singleton.MetanitExamples.PatternMultithreadingExample
{
    /// <summary>
    /// Компьютер
    /// </summary>
    internal class MultithreadingComputer
    {
        /// <summary>
        /// Поле операционной системы компьютера
        /// </summary>
        public MultithreadingOS OS { get; set; }

        /// <summary>
        /// Запуск ОС
        /// </summary>
        /// <remarks>
        /// Каждый комп может запустить только одну ОС
        /// </remarks>
        /// <param name="osName">Имя ОС</param>
        public void Launch(string osName)
        {
            OS = MultithreadingOS.getInstance(osName);
        }
    }
}
