using System;
using System.Collections.Generic;
using System.Text;

namespace test_dotnet_3
{
    public class ContractEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int DaysWorked { get; set; }

        public int  HoursWorked(int daysWorked)
        {
            int HoursWorked = DaysWorked * 8; // Assuming 8 working hours per day
            return HoursWorked;
        }

        public override decimal CalculateMonthlySalary()
        {
            // Implementation for calculating monthly salary for contract employees
            return HourlyRate * HoursWorked(DaysWorked);
        }

    }
}
