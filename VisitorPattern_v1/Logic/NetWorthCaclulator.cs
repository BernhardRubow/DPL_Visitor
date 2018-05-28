using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern_v1.Dto;

namespace VisitorPattern_v1.Logic
{
    public class NetWorthCaclulator
    {
        private Person _person;
        

        public NetWorthCaclulator()
        {
            _person = new Person();
            _person.BankAccounts.Add(new BankAccount() {Amount = 1000, MonthlyInterest = 0.01});
            _person.BankAccounts.Add(new BankAccount() {Amount = 2000, MonthlyInterest = 0.02});
            _person.RealEstates.Add(new RealEstate() {EstimatedValue = 79000, MonthlyRent = 500});
            _person.Loans.Add(new Loan() {Owed = 40000, MonthlyPayment = 40});
        }

        public int CalcNetWorth()
        {
            int networth = 0;

            networth += _person.BankAccounts.Sum(bankAccount => bankAccount.Amount);
            networth += _person.RealEstates.Sum(realEstate => realEstate.EstimatedValue);
            networth -= _person.Loans.Sum(loan => loan.Owed);

            return networth;
        }
    }
}
