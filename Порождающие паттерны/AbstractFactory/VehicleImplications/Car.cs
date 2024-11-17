using AbstractFactory.Interfaces;

namespace AbstractFactory.VehicleImplications
{
    /// <summary>
    /// Сущность машины
    /// </summary>
    internal class Car : IVehicle
    {
        /// <inheritdoc/>
        public void Drive()
        {
            Console.WriteLine("Еду на машине");
        }
    }
}
