using FactoryPattern.Examples.Metanit.Abstractions;

namespace FactoryPattern.Examples.Metanit.Realizations
{
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
