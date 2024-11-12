namespace DecoratorPattern.Interfaces
{
    /// <summary>
    /// Интерфейс расширяемого функционала 
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Расширяемая операция
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("Base operation");
        }
    }
}
