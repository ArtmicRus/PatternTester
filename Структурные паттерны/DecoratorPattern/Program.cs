using DecoratorPattern.Examples.Unlnown.BaseClasses;
using DecoratorPattern.Examples.Unlnown.Decorator;
using DecoratorPattern.Examples.Youtube.BuilderLine.Abstraction;
using DecoratorPattern.Examples.Youtube.BuilderLine.Interfaces;
using DecoratorPattern.Examples.Youtube.BuilderLine.Realization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Декоратор (Decorator) представляет структурный шаблон проектирования,
        // который позволяет динамически подключать к объекту дополнительную функциональность.

        // Для определения нового функционала в классах нередко используется наследование.
        // Декораторы же предоставляет наследованию более гибкую альтернативу,
        // поскольку позволяют динамически в процессе выполнения определять новые возможности у объектов.

        #region Unknown

        var component = new Component();
        var concreteDecorator = new ConcreteDecorator(component);

        concreteDecorator.Operation();

        #endregion

        #region BuilderLine

        IProcessor transmitter = new Transmitter("12345");
        transmitter.Process();
        Console.WriteLine();

        Shell hammingCoder = new HammingCoder(transmitter);
        hammingCoder.Process();
        Console.WriteLine();

        Shell encoder = new Encryptor(hammingCoder);
        encoder.Process();

        #endregion
    }
}