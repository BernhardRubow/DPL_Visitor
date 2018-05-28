using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern_v2.Dto;
using VisitorPattern_v2.Interfaces;
using VisitorPattern_v2.Visitors;

namespace VisitorPattern_v2.Logic
{
    public class NetWorthCaclulator
    {
        private Person _person;
        

        public NetWorthCaclulator()
        {
            _person = new Person();
            _person.Assets.Add(new BankAccount() {Amount = 1000, MonthlyInterest = 0.01});
            _person.Assets.Add(new BankAccount() {Amount = 2000, MonthlyInterest = 0.02});
            _person.Assets.Add(new RealEstate() {EstimatedValue = 79000, MonthlyRent = 500});
            _person.Assets.Add(new Loan() {Owed = 40000, MonthlyPayment = 40});
        }

        public int CalcNetWorth()
        {
            var networthVisitor = new NetWorthVisior();
            _person.Accept(networthVisitor);

            return networthVisitor.Total;
        }

        public double CalcIncome()
        {
            var incomeVisitor = new IncomeVisitor();
            _person.Accept(incomeVisitor);

            return incomeVisitor.Amount;
        }
    }
}
