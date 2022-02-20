using ISP.Good.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ISP.Good
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
            return Employees.Where(x => x is ISalary).Select(x => (ISalary)x).Sum(x => x.CalculateNetSalary());
        }

        public decimal GetTotalValue()
        {
            return GetNetValue() + GetTaxes();
        }

        public decimal GetTaxes()
        {
            return Employees.Where(x => x is ITaxable).Select(x => (ITaxable)x).Sum(x => x.CalculateTax()) * 2;
        }
    }
}
