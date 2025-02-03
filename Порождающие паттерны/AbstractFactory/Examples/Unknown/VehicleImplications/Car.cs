using AbstractFactory.Examples.Unknown.Interfaces;

namespace AbstractFactory.Examples.Unknown.VehicleImplications
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
