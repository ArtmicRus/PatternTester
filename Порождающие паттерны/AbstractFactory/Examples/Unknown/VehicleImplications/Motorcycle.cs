using AbstractFactory.Examples.Unknown.Interfaces;

namespace AbstractFactory.Examples.Unknown.VehicleImplications
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
