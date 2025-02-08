using DecoratorPattern.Examples.Unlnown.Interfaces;

namespace DecoratorPattern.Examples.Unlnown.Decorator
{
    /// <summary>
    /// Декоратор с дополнительной логикой
    /// </summary>
    internal class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            // Дополнительная логика декоратора
            Console.WriteLine("Concrete decoration before");
            base.Operation();
            Console.WriteLine("Concrete decoration after");
        }
    }
}
