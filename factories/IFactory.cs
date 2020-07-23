using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public interface IFactory<T>
    {
        List<T> Employees {get; set;}
        int MinEmployeeCount {get; set;}

        int MaxEmployeeCount {get; set;}

        void HireEmployee (T employee);

        void HireEmployees (List<T> employeeList);

    } 
}