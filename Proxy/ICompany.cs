using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public interface ICompany
    {
        List<string> GetEmployees();
        void AddEmployee(string employeeName);
    }
}
