using System;
using System.Collections.Generic;
using System.Text;

namespace test_dotnet_3
{
    public abstract class Employee
    {
        public string EmployeeID { get; private set; }
        public string? EmployeeName { get; private set; }
        public string? Department { get; private set; }
        public string? EmployeeType { get; private set; }
        public decimal BaseSalary { get; private set; }
        public abstract decimal CalculateMonthlySalary();


    }
}
