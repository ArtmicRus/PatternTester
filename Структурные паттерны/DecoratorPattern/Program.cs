using DecoratorPattern.BaseClasses;
using DecoratorPattern.Decorator;

internal class Program
{
    private static void Main(string[] args)
    {
        // Декоратор (Decorator) представляет структурный шаблон проектирования,
        // который позволяет динамически подключать к объекту дополнительную функциональность.

        // Для определения нового функционала в классах нередко используется наследование.
        // Декораторы же предоставляет наследованию более гибкую альтернативу,
        // поскольку позволяют динамически в процессе выполнения определять новые возможности у объектов.


        var component = new Component();
        var concreteDecorator = new ConcreteDecorator(component);

        concreteDecorator.Operation();
    }
}