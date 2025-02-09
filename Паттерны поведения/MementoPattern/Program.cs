using MementoPattern.Examples.Metanit.Entity;
using MementoPattern.Examples.Youtube.BuilderLine.Entity;

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта
            // за его пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции.

            #region Metanit

            Hero hero = new Hero();
            hero.Shoot(); // делаем выстрел, осталось 9 патронов
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // сохраняем игру

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            hero.RestoreState(game.History.Pop());

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            #endregion

            #region BuilderLine

            Exchange exchange = new Exchange(10,10);

            Memory memory = new Memory(exchange);

            exchange.GetDollars();
            exchange.GetEuro();

            Console.WriteLine("Продажа долларов Покупка евро");

            exchange.Sell();
            exchange.Buy();

            exchange.GetDollars();
            exchange.GetEuro();

            Console.WriteLine("Сохраняем состояние");
            memory.Backup();

            Console.WriteLine("Продажа долларов Покупка евро");
            exchange.Sell();
            exchange.Buy();

            exchange.GetDollars();
            exchange.GetEuro();

            Console.WriteLine("Восстоновим состояние");
            memory.Undo();

            exchange.GetDollars();
            exchange.GetEuro();

            #endregion
        }
    }
}
