using AbstractFactory.Examples.Metanit.Abstractions;

namespace AbstractFactory.Examples.Metanit.Factory
{
    // класс абстрактной фабрики
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
