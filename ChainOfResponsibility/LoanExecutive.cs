using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class LoanExecutive : BankEmployee
    {
        public LoanExecutive() : base("Loan executive")
        {

        }

        public override void Handle(Loan loan)
        {
            if ((loan.Amount > 5000 && loan.Amount <= 10000) || (loan.PeriodInMonths > 48 && loan.PeriodInMonths <= 60))
            {
                OnLoanHandled(new LoanHandledEventArgs { BankEmployee = this, Loan = loan });
            }
            else if (NextHandler != null)
            {
                NextHandler.Handle(loan);
            }
        }
    }
}
