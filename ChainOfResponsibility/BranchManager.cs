namespace DesignPatterns.ChainOfResponsibility
{
    public class BranchManager: BankEmployee
    {
        public BranchManager() : base("Branch manager")
        {

        }

        public override void Handle(Loan loan)
        {
            if ((loan.Amount > 50000 && loan.Amount <= 100000) || (loan.PeriodInMonths > 120 && loan.PeriodInMonths <= 360))
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
