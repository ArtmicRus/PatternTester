using AbstractFactory.Examples.Metanit.Abstractions;

namespace AbstractFactory.Examples.Metanit.Realizations
{
    // класс меч
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
