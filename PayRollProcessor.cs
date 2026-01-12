using System;
using System.Collections.Generic;
using System.Text;

namespace test_dotnet_3
{
    public class PayRollProcessor
    {
        static List<Employee>? employees;
        static List<PaySlip>? paySlips;


        public PayRollProcessor(List<Employee> employees)
        {
            employees = employees;
            paySlips = new List<PaySlip>();
        }
        public void ProcessPayroll()
        {
            foreach (Employee employee in employees)
            {
                decimal monthlySalary = employee.CalculateMonthlySalary();
                // Logic to generate payslip or process payment
                PaySlip paySlip = new PaySlip()
                {
                    EmployeeName = employee.EmployeeName,
                    NetSalary = monthlySalary
                };
                paySlips.Add(paySlip);
            }
        }
        public List<PaySlip> GetPaySlips()
        {
            return paySlips;
        }
    }
}
