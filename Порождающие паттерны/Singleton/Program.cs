using Singleton.MetanitExamples.PatternLazyExample;
using Singleton.MetanitExamples.PatternMultithreadingExample;
using Singleton.MetanitExamples.PatternMultithreadingExampleWithoutLock;
using Singleton.MetanitExamples.PatternSimpleExample;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Теория паттерна

        // Одиночка(Singleton, Синглтон) - порождающий паттерн, который гарантирует,
        // что для определенного класса будет создан только один объект,
        // а также предоставит к этому объекту точку доступа.

        // Вопрос: Когда надо использовать Синглтон?
        // Ответ: Когда необходимо, чтобы для класса существовал только один экземпляр

        // Синглтон позволяет создать объект только при его необходимости.
        // Если объект не нужен, то он не будет создан.
        // В этом отличие синглтона от глобальных переменных.

        #endregion

        #region Проверка работы MetanitExample/PatternSimpleExample

        Computer comp = new Computer();
        comp.Launch("Windows 8.1");
        Console.WriteLine(comp.OS.Name);

        // у нас не получится изменить ОС, так как объект уже создан    
        comp.OS = OS.getInstance("Windows 10");
        Console.WriteLine(comp.OS.Name);

        #endregion

        #region Проверка работы MetanitExample/PatternMultithreadingExample

        (new Thread(() =>
        {
            MultithreadingComputer comp2 = new MultithreadingComputer();
            comp2.OS = MultithreadingOS.getInstance("Windows 10");
            Console.WriteLine(comp2.OS.Name);

        })).Start();

        MultithreadingComputer comp3 = new MultithreadingComputer();
        comp3.Launch("Windows 8.1");
        Console.WriteLine(comp3.OS.Name);

        #endregion

        // Выше были рассмотрены общие стандартные реализации: потоконебезопасная и потокобезопасная реализации паттерна.
        // Но есть еще ряд дополнительных реализаций, которые можно рассмотреть.

        #region Проверка работы MetanitExample/PatternMultithreadingExampleWithoutLock

        (new Thread(() =>
        {
            MySingleton singleton1 = MySingleton.GetInstance();
            Console.WriteLine(singleton1.Date);
        })).Start();

        MySingleton singleton2 = MySingleton.GetInstance();
        Console.WriteLine(singleton2.Date);

        #endregion

        // Lazy-реализация

        #region Проверка работы MetanitExample/PatternLazyExample

        // Определение объекта синглтона в виде статического поля класса открывает нам дорогу к созданию
        // Lazy-реализации паттерна Синглтон, то есть такой реализации,
        // где данные будут инициализироваться только перед непосредственным использованием.
        // Поскольку статические поля инициализируются перед первым доступом к статическому членам класса
        // и перед вызовом статического конструктора (при его наличии).

        // Во-первых, класс синглтона может иметь множество статических переменных.
        // Возможно, мы вообще не будем обращаться к объекту синглтона,
        // а будем использовать какие-то другие статические переменные

        Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
        Console.WriteLine(MyLazySingleton.text);

        #endregion
    }
}