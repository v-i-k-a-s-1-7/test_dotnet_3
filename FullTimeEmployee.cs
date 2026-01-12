using System;
using System.Collections.Generic;
using System.Text;

namespace test_dotnet_3
{
    public class FullTimeEmployee : Employee
    {
        private decimal Bonus { get; set; }
        private decimal PfAmount { get; set; }
        private decimal TaxRate { get; set; }
        public override decimal CalculateMonthlySalary()
        {
            // Implementation for calculating monthly salary for full-time employees
            return BaseSalary + Bonus - PfAmount - (BaseSalary * TaxRate);
        }


    }
}
