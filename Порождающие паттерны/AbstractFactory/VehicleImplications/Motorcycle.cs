using AbstractFactory.Interfaces;

namespace AbstractFactory.VehicleImplications
{
    /// <summary>
    /// Сущность машины
    /// </summary>
    internal class Motorcycle : IVehicle
    {
        /// <inheritdoc/>
        public void Drive()
        {
            Console.WriteLine("Еду на мотоцикле");
        }
    }
}
