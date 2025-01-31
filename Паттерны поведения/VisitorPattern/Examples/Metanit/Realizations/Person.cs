using VisitorPattern.Examples.Metanit.Interfaces;

namespace VisitorPattern.Examples.Metanit.Realizations
{
    class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}
