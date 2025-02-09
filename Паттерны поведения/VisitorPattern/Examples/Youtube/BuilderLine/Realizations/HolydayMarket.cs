
using VisitorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace VisitorPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class HolydayMarket : IVisitor
    {
        public string value;

        public void Visit(Zoo zoo)
        {
            value = "Слон в зоопарке";
        }

        public void Visit(Cinema zoo)
        {
            value = "Кино - Властелин колец";
        }

        public void Visit(Circus zoo)
        {
            value = "Клоун в цирке";
        }
    }
}
