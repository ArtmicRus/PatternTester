using AbstractFactory.Interfaces;

namespace AbstractFactory.EngineImplications
{
    internal class MotorcycleEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Запускаю двигатель мотоцикла");
        }
    }
}
