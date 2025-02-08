using AdapterPattern.Examples.Metanit.Example2;
using AdapterPattern.Examples.Metanit.Example2.Adapter;
using AdapterPattern.Examples.Metanit.Example2.Interfaces;
using AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Interfaces;
using AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Realizations;
using AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Interfaces;
using AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Realizations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
        // Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.

        #region Metanit/Example2

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

        #endregion

        #region BuilderLine/Example_1

        float kg = 55.0f; // kg
        float lb = 55.0f; // Фунты

        IScales rScales = new RussianScales(kg);
        IScales bScales = new AdaptForBritishScales(new BritishScales(lb));

        Console.WriteLine(rScales.GetWeight());
        Console.WriteLine(bScales.GetWeight());

        #endregion

        #region BuilderLine/Example_2

        float kg_2 = 55.0f; // kg
        float lb_2 = 55.0f; // Фунты

        IScales_2 rScales_2 = new RussianScales_2(kg_2);
        IScales_2 bScales_2 = new AdaptForBritishScales_2(lb_2);

        Console.WriteLine(rScales_2.GetWeight());
        Console.WriteLine(bScales_2.GetWeight());

        rScales_2.Adjust();
        bScales_2.Adjust();

        #endregion
    }
}