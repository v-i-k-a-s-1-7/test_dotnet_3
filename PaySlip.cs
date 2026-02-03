using System;
using System.Collections.Generic;
using System.Text;

namespace test_dotnet_3
{
    public class PaySlip
    {
        public string? EmployeeID { get; private set; }
        public string? EmployeeName { get; set; }
        public string? Department { get; private set; }
        public string? EmployeeType { get; private set; }
        public decimal BaseSalary { get; private set; }
        public decimal TaxAmount { get; private set; }
        public decimal NetSalary { get; set; }

        public PaySlip()
        {
        }
        public PaySlip(string employeeID, string employeeName, string department, string employeeType, decimal baseSalary, decimal taxAmount, decimal netSalary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Department = department;
            EmployeeType = employeeType;
            BaseSalary = baseSalary;
            TaxAmount = taxAmount;
            NetSalary = netSalary;
        }

<<<<<<< HEAD:PaySlip.cs
        public List<PaySlip> GetPaySlips()
        {
            return paySlips;
        }
=======
>>>>>>> c38c169 (Updated some Programs):test_dotnet_3/PaySlip.cs
    }
}
