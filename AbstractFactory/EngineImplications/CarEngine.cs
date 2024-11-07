using AbstractFactory.Interfaces;

namespace AbstractFactory.EngineImplications
{
    internal class CarEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Запускаю двигатель автомобиля");
        }
    }
}
