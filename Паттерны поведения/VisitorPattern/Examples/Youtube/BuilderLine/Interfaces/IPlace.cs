namespace VisitorPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IPlace
    {
        void Accept(IVisitor visitor);
    }
}
