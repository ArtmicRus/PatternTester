using AdapterPattern.MetanitExamples.Example2.Adapter;
using AdapterPattern.MetanitExamples.Example2.Interfaces;
using AdapterPattern.MetanitExamples.Example2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
        // Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.

        // путешественник
        Driver driver = new Driver();
        // машина
        Auto auto = new Auto();
        // отправляемся в путешествие
        driver.Travel(auto);
        // встретились пески, надо использовать верблюда
        Camel camel = new Camel();
        // используем адаптер
        ITransport camelTransport = new CamelToTransportAdapter(camel);
        // продолжаем путь по пескам пустыни
        driver.Travel(camelTransport);
    }
}