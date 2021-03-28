using System;
using System.Collections.Generic;
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
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            _companyProxy.Authenticate(username, password);

            try
            {
                PopulateEmployeesList();

            }catch
            {
                MessageBox.Show("Not authorized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                employeeNameTextbox.Clear();

                PopulateEmployeesList();

                MessageBox.Show(newEmployeeName + " added!");
                
            }
            catch
            {
                MessageBox.Show("Not authorized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateEmployeesList()
        {
            employeesListBox.Items.Clear();
            List<string> employeeNames = _companyProxy.GetEmployees();
            employeeNames.ForEach(name => employeesListBox.Items.Add(name));
        }
    }
}