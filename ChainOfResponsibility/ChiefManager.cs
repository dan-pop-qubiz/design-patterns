using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ChiefManager: BankEmployee
    {
        public ChiefManager() : base("Chief manager")
        {

        }

        public override void Handle(Loan loan)
        {
            if ((loan.Amount > 100000 && loan.Amount <= 1000000))
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
