namespace ObserverPattern.Examples.Unknown.Interfaces
{
    /// <summary>
    /// Интерфейс рассыльного (тот за кем наблюдают)
    /// </summary>
    internal interface ISubject
    {
        /// <summary>
        /// Добавить наблюдателя
        /// </summary>
        /// <param name="observer">Добавляемый наблюдатель</param>
        public void Attach(IObserver observer);

        /// <summary>
        /// Убрать наблюдателя
        /// </summary>
        /// <param name="observer">Убираемый наблюдатель</param>
        public void Detach(IObserver observer);

        /// <summary>
        /// Уведомляет всех наблюдателей (подписчиков на событие)
        /// </summary>
        public void Notify();
    }
}
