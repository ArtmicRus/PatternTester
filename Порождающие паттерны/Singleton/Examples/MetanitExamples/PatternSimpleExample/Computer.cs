namespace Singleton.Examples.MetanitExamples.PatternSimpleExample
{
    /// <summary>
    /// Компьютер
    /// </summary>
    internal class Computer
    {
        /// <summary>
        /// Поле операционной системы компьютера
        /// </summary>
        public OS OS { get; set; }

        /// <summary>
        /// Запуск ОС
        /// </summary>
        /// <remarks>
        /// Каждый комп может запустить только одну ОС
        /// </remarks>
        /// <param name="osName">Имя ОС</param>
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
}
