using DecoratorPattern.Examples.Unlnown.Interfaces;

namespace DecoratorPattern.Examples.Unlnown.Decorator
{
    /// <summary>
    /// Абстрактный декоратор
    /// </summary>
    public abstract class Decorator : IComponent
    {
        /// <summary>
        /// Расширяемый компонент
        /// </summary>
        protected readonly IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            // Декорация может быть реализована тут
            Console.WriteLine("Decoration before");
            _component.Operation();
            Console.WriteLine("Decoration after");
        }
    }
}
