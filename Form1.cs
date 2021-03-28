using DesignPatterns.AbstractFactory;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Mediator;
using DesignPatterns.Observer;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbstractFactory_Click(object sender, EventArgs e)
        {
            AbstractFactoryForm abstractFactoryForm = new AbstractFactoryForm();
            abstractFactoryForm.TopLevel = false;
            abstractFactoryForm.Parent = this;
            abstractFactoryForm.StartPosition = FormStartPosition.CenterParent;

            abstractFactoryForm.BringToFront();
            abstractFactoryForm.Show();
        }

        private void buttonSingleton_Click(object sender, EventArgs e)
        {
            SingletonForm singletonForm = new SingletonForm();
            singletonForm.TopLevel = false;
            singletonForm.Parent = this;
            singletonForm.StartPosition = FormStartPosition.CenterParent;

            singletonForm.BringToFront();
            singletonForm.Show();
        }

        private void buttonProxi_Click(object sender, EventArgs e)
        {
            ProxyForm proxyForm = new ProxyForm();
            proxyForm.TopLevel = false;
            proxyForm.Parent = this;
            proxyForm.StartPosition = FormStartPosition.CenterParent;

            proxyForm.BringToFront();
            proxyForm.Show();
        }

        private void buttonMediator_Click(object sender, EventArgs e)
        {
            MediatorForm mediatorForm = new MediatorForm();
            mediatorForm.TopLevel = false;
            mediatorForm.Parent = this;
            mediatorForm.StartPosition = FormStartPosition.CenterParent;

            mediatorForm.BringToFront();
            mediatorForm.Show();
        }

        private void buttonObserver_Click(object sender, EventArgs e)
        {
            ObserverForm observerForm = new ObserverForm();
            observerForm.TopLevel = false;
            observerForm.Parent = this;
            observerForm.StartPosition = FormStartPosition.CenterParent;

            observerForm.BringToFront();
            observerForm.Show();
        }

        private void buttonChainOfResponsibility_Click(object sender, EventArgs e)
        {
            ChainOfResponsibilityForm chainOfResponsibilityForm = new ChainOfResponsibilityForm();
            chainOfResponsibilityForm.TopLevel = false;
            chainOfResponsibilityForm.Parent = this;
            chainOfResponsibilityForm.StartPosition = FormStartPosition.CenterParent;

            chainOfResponsibilityForm.BringToFront();
            chainOfResponsibilityForm.Show();
        }
    }
}