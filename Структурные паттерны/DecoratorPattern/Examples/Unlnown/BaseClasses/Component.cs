using DecoratorPattern.Examples.Unlnown.Interfaces;

namespace DecoratorPattern.Examples.Unlnown.BaseClasses
{
    /// <summary>
    /// Класс который нуждается в дополнительном функционале
    /// </summary>
    internal class Component : IComponent
    {
        /// <inheritdoc/>
        public void Operation()
        {
            Console.WriteLine("Base operation");
        }
    }
}
