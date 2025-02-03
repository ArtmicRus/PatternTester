using AbstractFactory.Examples.Metanit.Abstractions;
using AbstractFactory.Examples.Metanit.Realizations;

namespace AbstractFactory.Examples.Metanit.Factory
{
    // Фабрика создания летящего героя с арбалетом
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
