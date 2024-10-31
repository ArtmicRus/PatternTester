using ObserverPattern.Interfaces;
using ObserverPattern.PatternSource.Subject;

namespace ObserverPattern.PatternWithEvents.Observers
{
    /// <summary>
    /// Звуковой менеджер наблюдающий за изменением здоровьем игрока
    /// </summary>
    internal class SoundManager : IObserver
    {
        public SoundManager(Player player)
        {
            Player = player;
        }

        /// <inheritdoc/>
        private Player Player { get; set; }

        /// <summary>
        /// Изменение музыки при изменении здоровья
        /// </summary>
        /// <param name="health"></param>
        private void PlayMusic(int health)
        {
            Console.WriteLine("Обновление музыкальной композиции");
        }

        public void HealthChanged()
        {
            var health = Player.Health;
            PlayMusic(health);
        }
    }
}
