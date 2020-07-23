using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class SteelFactory : IFactory<SteelWorker>
    {
        public int MinEmployeeCount { get; set; }
       
        public int MaxEmployeeCount { get; set; }
        public List<SteelWorker> Employees { get; set; } = new List<SteelWorker>();

        public void HireEmployee(SteelWorker employee)
        {
            this.Employees.Add(employee);
        }

        public void HireEmployees(List<SteelWorker> employeeList)
        {
            this.Employees.AddRange(employeeList);

        }

   
    }
}