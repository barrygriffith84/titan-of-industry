using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class AutomobileFactory : IFactory<AutoWorker>
    {
        public List<AutoWorker> Employees { get; set; } = new List<AutoWorker>();
        public int MinEmployeeCount { get; set; }
        public int MaxEmployeeCount { get; set; }

        public void HireEmployee(AutoWorker employee)
        {
            this.Employees.Add(employee);
        }

        public void HireEmployees(List<AutoWorker> employeeList)
        {
            this.Employees.AddRange(employeeList);
            
        }
    }
}