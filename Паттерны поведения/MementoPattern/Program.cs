using MementoPattern.Examples.Metanit.Entity;

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта
            // за его пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции.

            Hero hero = new Hero();
            hero.Shoot(); // делаем выстрел, осталось 9 патронов
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // сохраняем игру

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            hero.RestoreState(game.History.Pop());

            hero.Shoot(); //делаем выстрел, осталось 8 патронов
        }
    }
}
