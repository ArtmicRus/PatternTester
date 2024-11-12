namespace AbstractFactory.Interfaces
{
    internal interface IFactory
    {
        IVehicle CreateVehicle();
        IEngine CreateEngine();
    }
}
