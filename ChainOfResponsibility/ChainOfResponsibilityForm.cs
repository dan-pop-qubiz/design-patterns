using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.ChainOfResponsibility
{
    public partial class ChainOfResponsibilityForm : Form
    {
        BankEmployee bankTeller = new BankTeller();
        BankEmployee headClerk = new HeadClerk();
        BankEmployee loanExecutive = new LoanExecutive();
        BankEmployee loanManager = new LoanManager();
        BankEmployee branchManager = new BranchManager();
        BankEmployee chiefManager = new ChiefManager();
        BankEmployee generalManager = new GeneralManager();
        Loan loan;

        public ChainOfResponsibilityForm()
        {
            InitializeComponent();
        }

        private void ChainOfResponsibilityForm_Load(object sender, EventArgs e)
        {
            bankTeller.NextHandler = headClerk;
            headClerk.NextHandler = loanExecutive;
            loanExecutive.NextHandler = loanManager;
            loanManager.NextHandler = branchManager;
            branchManager.NextHandler = chiefManager;
            chiefManager.NextHandler = generalManager;

            bankTeller.LoanHandled += LoanHandled;
            headClerk.LoanHandled += LoanHandled;
            loanExecutive.LoanHandled += LoanHandled;
            loanManager.LoanHandled += LoanHandled;
            branchManager.LoanHandled += LoanHandled;
            chiefManager.LoanHandled += LoanHandled;
            generalManager.LoanHandled += LoanHandled;
        }

        private void buttonHandle_Click(object sender, EventArgs e)
        {
            loan = new Loan();
            loan.Amount = int.Parse(textBoxAmount.Text);
            loan.PeriodInMonths = int.Parse(textBoxPeriod.Text);

            bankTeller.Handle(loan);
        }

        private void LoanHandled(object sender, LoanHandledEventArgs args)
        {
            string handler = args.BankEmployee.Position;
            MessageBox.Show("Loan handled by " + handler);
        }
    }
}
