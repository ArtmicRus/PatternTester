using FactoryPattern.Examples.Metanit.Abstractions;

namespace FactoryPattern.Examples.Metanit.Realizations
{
    // строит панельные дома
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
