using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.PatternSourceWithAbstractClasses.Factories;

internal class Program
{
    private static void Main(string[] args)
    {
        // Фабричный метод — это паттерн проектирования, который определяет интерфейс для создания объектов определенного типа,
        // позволяя подклассам изменять тип создаваемых объектов.
        // Этот паттерн часто используется, когда нужно создавать объекты разных типов,
        // но клиентский код не должен зависеть от конкретных реализаций этих объектов.

        VehicleFactory carFactory = new CarFactory();
        Vehicle vehicle = carFactory.CreateVehicle();
        vehicle.Drive(); // Еду на машине

        VehicleFactory motorcycleFactory = new MotorcycleFactory();
        vehicle = motorcycleFactory.CreateVehicle();
        vehicle.Drive(); // Еду на мотоцикле

        VehicleFactory bicycleFactory = new BicycleFactory();
        vehicle = bicycleFactory.CreateVehicle();
        vehicle.Drive(); // Катаюсь на велосипеде
    }
}