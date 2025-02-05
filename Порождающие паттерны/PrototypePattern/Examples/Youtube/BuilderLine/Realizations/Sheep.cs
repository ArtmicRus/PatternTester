using PrototypePattern.Examples.Youtube.BuilderLine.Interfaces;

namespace PrototypePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Sheep : IAnimal
    {
        private string Name { get; set; }

        public Sheep() { }

        private Sheep(Sheep donor)
        {
            Name = donor.Name;
        }

        public IAnimal Clone()
        {
            return new Sheep(this);
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
