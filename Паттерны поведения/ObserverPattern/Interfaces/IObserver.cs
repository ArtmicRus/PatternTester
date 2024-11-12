namespace ObserverPattern.Interfaces
{
    /// <summary>
    /// Интерфейс подписчика(наблюдателя) на(за) изменениями в другом классе
    /// </summary>
    internal interface IObserver
    {
        /// <summary>
        /// Событие оповещающее об изменении от subject
        /// </summary>
        public void HealthChanged();
    }
}
