using VisitorPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace VisitorPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Zoo : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}