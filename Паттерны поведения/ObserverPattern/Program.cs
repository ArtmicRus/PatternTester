using ObserverPattern.Examples.Unknown.PatternSourceWithoutEvents.Observers;
using ObserverPattern.Examples.Unknown.PatternSourceWithoutEvents.Subject;
using ObserverPattern.Examples.Youtube.BuilderLine.Realizations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования,
        // который использует отношение "один ко многим".
        // В этом отношении есть один наблюдаемый объект и множество наблюдателей.
        // И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.

        #region Unknown

        Player player = new Player(100);

        player.Attach(new SoundManager(player));

        player.Health = 30;

        Thread.Sleep(100);

        player.Attach(new HealthBar(player));

        player.Health = 60;

        #endregion

        #region BuilderLine

        Product product = new Product(400);

        Wholesale wholesale = new Wholesale(product);
        Buyer  buyer = new Buyer(product);

        product.ChangePrice(346);
        product.ChangePrice(237);


        #endregion
    }
}