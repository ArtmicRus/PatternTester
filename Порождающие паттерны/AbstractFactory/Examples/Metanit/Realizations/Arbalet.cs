using AbstractFactory.Examples.Metanit.Abstractions;

namespace AbstractFactory.Examples.Metanit.Realizations
{
    // класс арбалет
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
