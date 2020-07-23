using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class NuggetFactory : IFactory<FoodProcessor>
    {
        public List<FoodProcessor> Employees { get; set; } = new List<FoodProcessor>();
        public int MinEmployeeCount { get; set; }
        public int MaxEmployeeCount { get; set; }

        public void HireEmployee(FoodProcessor employee)
        {
            this.Employees.Add(employee);
        }

        public void HireEmployees(List<FoodProcessor> employeeList)
        {
            this.Employees.AddRange(employeeList);
        }
    }
}