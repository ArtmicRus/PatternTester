namespace VisitorPattern.Examples.Metanit.Interfaces
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
