using VisitorPattern.Examples.Metanit.Realizations;

namespace VisitorPattern.Examples.Metanit.Interfaces
{
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}
