using AbstractFactory.Interfaces;

namespace AbstractFactory.EngineImplications
{
    /// <summary>
    /// Сущность двигателя машины
    /// </summary>
    internal class CarEngine : IEngine
    {
        /// <inheritdoc/>
        public void Start()
        {
            Console.WriteLine("Запускаю двигатель автомобиля");
        }
    }
}
