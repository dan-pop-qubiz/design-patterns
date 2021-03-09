using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class GeneralManager: BankEmployee
    {
        public GeneralManager() : base("General manager")
        {

        }

        public override void Handle(Loan loan)
        {
            OnLoanHandled(new LoanHandledEventArgs { BankEmployee = this, Loan = loan });   
        }
    }
}
