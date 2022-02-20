using System.Collections.Generic;
using System.Linq;

namespace LSP.Good
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
            return Employees.Sum(x => x.CalculateNetSalary());
        }

        public decimal GetTotalValue()
        {
            return GetNetValue() + GetTaxes();
        }

        public decimal GetTaxes()
        {
            var value = 0m;

            foreach (Tax item in Employees.Where(x => x is Tax))
            {
                value += item.CalculateTax();
            }

            return value * 2;
        }
    }
}
