using System.Collections.Generic;
using System.Linq;

namespace LSP.Bad
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
            return Employees.Sum(x => x.CalculateTax()) * 2;
        }
    }
}
