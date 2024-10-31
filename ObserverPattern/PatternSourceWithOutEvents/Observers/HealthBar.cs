using ObserverPattern.Interfaces;
using ObserverPattern.PatternSource.Subject;

namespace ObserverPattern.PatternSourceWithOutEvents.Observers
{
    /// <summary>
    /// Сущность шкала здоровья которая подписано на изменение здоровья у игрока (Player)
    /// </summary>
    internal class HealthBar : IObserver
    {
        public HealthBar(Player player)
        {
            Player = player;
        }

        /// <inheritdoc/>
        private Player Player { get; set; }

        /// <summary>
        /// Обновление шкалы здоровья
        /// </summary>
        /// <param name="health"></param>
        private void UpdateUI(int health)
        {
            Console.WriteLine("Обновление шкалы здоровья");
        }

        /// <inheritdoc/>
        public void HealthChanged()
        {
            var health = Player.Health;
            UpdateUI(health);
        }
    }
}
