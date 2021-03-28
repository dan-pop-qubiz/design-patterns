namespace DesignPatterns.ChainOfResponsibility
{
    public class HeadClerk : BankEmployee
    {
        public HeadClerk(): base("Head Clerk")
        {

        }

        public override void Handle(Loan loan)
        {
            if ((loan.Amount > 1000 && loan.Amount <= 5000) || (loan.PeriodInMonths > 12 && loan.PeriodInMonths <= 48))
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