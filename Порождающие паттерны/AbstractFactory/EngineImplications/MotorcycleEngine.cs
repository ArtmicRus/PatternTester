using AbstractFactory.Interfaces;

namespace AbstractFactory.EngineImplications
{
    /// <summary>
    /// Сущность двигателя мотоцикла
    /// </summary>
    internal class MotorcycleEngine : IEngine
    {
        /// <inheritdoc/>
        public void Start()
        {
            Console.WriteLine("Запускаю двигатель мотоцикла");
        }
    }
}
