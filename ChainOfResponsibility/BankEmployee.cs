using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class BankEmployee
    {
        public BankEmployee(string position)
        {
            Position = position;
        }

        public event EventHandler<LoanHandledEventArgs> LoanHandled = delegate { };

        public string Position { get; set; }

        public BankEmployee NextHandler { get; set; }

        public abstract void Handle(Loan loan);

        public void OnLoanHandled(LoanHandledEventArgs args)
        {
            LoanHandled(this, args);
        }
    }

    public class LoanHandledEventArgs: EventArgs
    {
        public BankEmployee BankEmployee { get; set; }
        public Loan Loan { get; set; }
    }

}