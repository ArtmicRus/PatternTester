using VisitorPattern.Examples.Metanit.Interfaces;

namespace VisitorPattern.Examples.Metanit.Realizations
{
    class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAc(this);
        }
    }
}
