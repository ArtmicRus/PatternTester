using AbstractFactory.FactoryImplication;
using AbstractFactory.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // Абстрактная фабрика — это более сложный паттерн, который позволяет создавать целые семейства взаимосвязанных
        // или зависимых объектов без указания их конкретных классов. Она создает группу объектов,
        // которые связаны друг с другом. То есть она не ограничивается созданием одного продукта,
        // а создаёт целую серию продуктов, относящихся к одной тематике.

        IFactory carFactory = new CarFactory();
        IVehicle car = carFactory.CreateVehicle();
        IEngine carEngine = carFactory.CreateEngine();
        car.Drive(); // Еду на машине
        carEngine.Start(); // Запускаю двигатель автомобиля

        IFactory motorcycleFactory = new MotorcycleFactory();
        IVehicle motorcycle = motorcycleFactory.CreateVehicle();
        IEngine motorcycleEngine = motorcycleFactory.CreateEngine();
        motorcycle.Drive(); // Еду на мотоцикле
        motorcycleEngine.Start(); // Запускаю двигатель мотоцикла
    }
}