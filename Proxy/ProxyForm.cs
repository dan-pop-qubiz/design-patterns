using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Proxy
{
    public partial class ProxyForm : Form
    {
        CompanyProxy _companyProxy = new CompanyProxy();

        public ProxyForm()
        {
            InitializeComponent();
        }

        private void viewEmployeesBtn_Click(object sender, EventArgs e)
        {
            employeesListBox.Items.Clear();

            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            _companyProxy.Authenticate(username, password);

            try
            {
                List<string> employeeNames = _companyProxy.GetEmployees();
                employeeNames.ForEach(name => employeesListBox.Items.Add(name));

            }catch(Exception ex)
            {
                MessageBox.Show("Not authorized!");
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            _companyProxy.Authenticate(username, password);

            try
            {
                string newEmployeeName = employeeNameTextbox.Text;
                _companyProxy.AddEmployee(newEmployeeName);

                MessageBox.Show(newEmployeeName + " added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not authorized!");
            }
        }
    }
}
