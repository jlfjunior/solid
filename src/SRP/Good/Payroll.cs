using System.Collections.Generic;

namespace SRP.Good
{
    public class Payroll
    {
        public ICollection<Employee> Employees { get; private set; }

        public Payroll()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public decimal GetNetValue()
        {
            var value = 0m;

            foreach (var employee in Employees)
            {
                value += employee.CalculateNetSalary();
            }

            return value;
        }

        public decimal GetTotalValue()
        {
            return GetNetValue() + GetTaxes();
        }

        public decimal GetTaxes()
        {
            var value = 0m;

            foreach (var employee in Employees)
            {
                value += employee.CalculateTax();
            }

            return value * 2;
        }
    }
}
