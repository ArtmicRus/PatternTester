using ObserverPattern.PatternSourceWithoutEvents.Observers;
using ObserverPattern.PatternSourceWithoutEvents.Subject;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования,
        // который использует отношение "один ко многим".
        // В этом отношении есть один наблюдаемый объект и множество наблюдателей.
        // И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.
        Player player = new Player(100);

        player.Attach(new SoundManager(player));

        player.Health = 30;

        Thread.Sleep(5000);

        player.Attach(new HealthBar(player));

        player.Health = 60;
    }
}