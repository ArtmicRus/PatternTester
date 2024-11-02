using ObserverPattern.Interfaces;

namespace ObserverPattern.PatternSourceWithoutEvents.Subject
{
    /// <summary>
    /// Сущность игрока за которой наблюдают
    /// </summary>
    internal class Player : ISubject
    {
        /// <summary>
        /// Текущее здоровье игрока
        /// </summary>
        private int _health;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="startHealth">Стартовое здоровье</param>
        public Player(int startHealth)
        {
            _health = startHealth;
        }

        /// <summary>
        /// Здоровье игрока
        /// </summary>
        public int Health 
        { 
            get => _health; 
            set
            {
                _health = value;
                Notify();
            } 
        }

        /// <summary>
        /// Все наблюдатели за здоровьем игрока
        /// </summary>
        private List<IObserver> Observers = new List<IObserver>();

        /// <inheritdoc/>
        public void Attach(IObserver observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        /// <inheritdoc/>
        public void Detach(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        /// <inheritdoc/>
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                if (observer != null)
                {
                    observer.HealthChanged();
                }
            }
        }
    }
}
