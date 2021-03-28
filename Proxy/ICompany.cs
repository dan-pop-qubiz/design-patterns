using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public interface ICompany
    {
        List<string> GetEmployees();
        void AddEmployee(string employeeName);
    }
}
