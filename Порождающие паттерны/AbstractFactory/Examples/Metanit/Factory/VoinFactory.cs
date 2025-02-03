using AbstractFactory.Examples.Metanit.Abstractions;
using AbstractFactory.Examples.Metanit.Realizations;

namespace AbstractFactory.Examples.Metanit.Factory
{
    // Фабрика создания бегущего героя с мечом
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
