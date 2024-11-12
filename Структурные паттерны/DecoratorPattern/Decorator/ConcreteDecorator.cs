using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorator
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
