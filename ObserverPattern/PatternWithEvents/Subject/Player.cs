using ObserverPattern.Interfaces;

namespace ObserverPattern.PatternWithEvents.Subject
{
    /// <summary>
    /// Сущность игрока за которой наблюдают
    /// </summary>
    internal class Player : ISubject
    {
        private int _health;

        public event Action HealthChanged;

        /// <summary>
        /// Здоровье игрока
        /// </summary>
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                HealthChanged.Invoke();
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
