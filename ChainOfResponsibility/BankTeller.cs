namespace DesignPatterns.ChainOfResponsibility
{
    public class BankTeller : BankEmployee
    {
        public BankTeller() : base("Bank Teller")
        {
            
        }

        public override void Handle(Loan loan)
        {
            if (loan.Amount <= 1000 || loan.PeriodInMonths <= 12)
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
