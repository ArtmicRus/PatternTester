using AbstractFactory.Interfaces;

namespace AbstractFactory.VehicleImplications
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Еду на машине");
        }
    }
}
