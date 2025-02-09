using VisitorPattern.Examples.Youtube.BuilderLine.Realizations;

namespace VisitorPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IVisitor
    {
        void Visit(Zoo zoo);
        void Visit(Cinema zoo);
        void Visit(Circus zoo);
    }
}
