using FactoryPattern.Examples.Metanit.Abstractions;
using FactoryPattern.Examples.Metanit.Realizations;
using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Factories;
using FactoryPattern.Examples.Youtube.BuilderLine.Interfaces;
using FactoryPattern.Examples.Youtube.BuilderLine.Realizations;
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

        #region PatternSourceWithAbstractClasses

        VehicleFactory carFactory = new CarFactory();
        Vehicle vehicle = carFactory.CreateVehicle();
        vehicle.Drive(); // Еду на машине

        VehicleFactory motorcycleFactory = new MotorcycleFactory();
        vehicle = motorcycleFactory.CreateVehicle();
        vehicle.Drive(); // Еду на мотоцикле

        VehicleFactory bicycleFactory = new BicycleFactory();
        vehicle = bicycleFactory.CreateVehicle();
        vehicle.Drive(); // Катаюсь на велосипеде

        #endregion

        #region Metanit

        Developer dev = new PanelDeveloper("ООО КирпичСтрой");
        House house2 = dev.Create();

        dev = new WoodDeveloper("Частный застройщик");
        House house = dev.Create();

        #endregion

        #region Youtube/BuilderLine

        IWorkShop creator = new CarWorkShop();
        IProduction car = creator.Create();

        creator = new TruckWorkShop();
        IProduction truck = creator.Create();

        car.Realise();
        truck.Realise();

        #endregion
    }
}