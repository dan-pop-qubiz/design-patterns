using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class LoanManager: BankEmployee
    {
        public LoanManager() : base("Loan manager")
        {

        }

        public override void Handle(Loan loan)
        {
            if ((loan.Amount > 10000 && loan.Amount <= 50000) || (loan.PeriodInMonths > 60 && loan.PeriodInMonths <= 120))
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
