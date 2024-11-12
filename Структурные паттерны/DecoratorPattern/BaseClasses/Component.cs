using DecoratorPattern.Interfaces;

namespace DecoratorPattern.BaseClasses
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
