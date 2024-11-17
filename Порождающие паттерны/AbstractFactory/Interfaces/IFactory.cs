namespace AbstractFactory.Interfaces
{
    /// <summary>
    /// Фабрика производства всего семейства объектов
    /// </summary>
    internal interface IFactory
    {
        /// <summary>
        /// Создание транспортного средства
        /// </summary>
        /// <returns>Объект с реализованным интерфейсом <see cref="IVehicle"/></returns>
        IVehicle CreateVehicle();

        /// <summary>
        /// Создание двигателя
        /// </summary>
        /// <returns>Объект с реализованным интерфейсом <see cref="IEngine"/></returns>
        IEngine CreateEngine();
    }
}
