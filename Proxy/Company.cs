using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Company : ICompany
    {
        private List<string> _employees = new List<string>() { "Ion Barbu", "Cristina Popa", "Eva Iacob" };

        public void AddEmployee(string employeeName)
        {
            _employees.Add(employeeName);
        }

        public List<string> GetEmployees()
        {
            return _employees;
        }
    }
}