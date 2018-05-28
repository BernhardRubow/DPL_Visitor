using VisitorPattern_v2.Dto;

namespace VisitorPattern_v2.Interfaces
{
    public interface IVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }

    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }
}