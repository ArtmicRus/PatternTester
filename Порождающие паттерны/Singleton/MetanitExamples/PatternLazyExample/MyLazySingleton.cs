namespace Singleton.MetanitExamples.PatternLazyExample
{
    /// <summary>
    /// Реализация LazySingleton
    /// </summary>
    internal class MyLazySingleton
    {
        public string Date { get; private set; }
        public static string text = "hello";

        /// <summary>
        /// Конструктор
        /// </summary>
        private MyLazySingleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        /// <summary>
        /// Получение объекта
        /// </summary>
        /// <returns></returns>
        public static MyLazySingleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return Nested.instance;
        }

        /// <summary>
        /// Класс для хранения экземпляра <see cref="MyLazySingleton"/>
        /// </summary>
        /// <remarks>
        /// Cтатическая переменная, которая представляет объект синглтона, определена во вложенном классе Nested. 
        /// Чтобы к этой переменной можно было обращаться из класса синглтона, она имеет модификатор internal, 
        /// в то же время сам класс Nested имеет модификатор private, что позволяет гарантировать, 
        /// что данный класс будет доступен только из класса Singleton.
        /// </remarks>
        private class Nested
        {
            internal static readonly MyLazySingleton instance = new MyLazySingleton();
        }
    }
}
