using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern_v2.Dto;
using VisitorPattern_v2.Interfaces;

namespace VisitorPattern_v2.Visitor
{
    public class NetWorthVisior : IVisitor
    {
        public int Total;


        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }
    }
}
