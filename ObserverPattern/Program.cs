using ObserverPattern.PatternSourceWithoutEvents.Observers;
using ObserverPattern.PatternSourceWithoutEvents.Subject;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player(100);

        player.Attach(new SoundManager(player));

        player.Health = 30;

        Thread.Sleep(5000);

        player.Attach(new HealthBar(player));

        player.Health = 60;
    }
}