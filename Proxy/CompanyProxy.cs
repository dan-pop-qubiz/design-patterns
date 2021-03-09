using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class CompanyProxy : ICompany
    {
        private Company _company;
        private string _username = "dan";
        private string _password = "parola";
        private bool _isAuthenticated = false;

        public CompanyProxy()
        {
            
        }

        public void Authenticate(string username, string password)
        {
            _isAuthenticated = (username == _username && password == _password);
        }

        public void AddEmployee(string employeeName)
        {
            if (!_isAuthenticated)
            {
                throw new Exception("Not authorized");
            }

            Company company = GetCompany();
            company.AddEmployee(employeeName);
        }

        public List<string> GetEmployees()
        {
            if (!_isAuthenticated)
            {
                throw new Exception("Not authorized");
            }

            Company company = GetCompany();
            return company.GetEmployees();
        }

        private Company GetCompany()
        {
            if (_company == null)
            {
                _company = new Company();
            }
            return _company;
        }

    }
}
